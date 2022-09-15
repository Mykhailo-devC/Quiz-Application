﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizProject.Models;
using QuizProject.Models.DTO;
using QuizProject.Functions;
using Microsoft.AspNetCore.Cors;

namespace QuizProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly QuizContext _context;

        public UsersController(QuizContext context)
        {
            _context = context;
        }
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            _context.CreatedTests.Load();
            return await _context.Users.Include(u => u.UserTestCount).ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (!Methods.ElemExists<User>(id, _context))
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<int>> PutUser(int id, UserUpdateDTO userUpdto)
        {

            try
            {
                if (!Methods.ElemExists<User>(id, _context))
                {
                    return NotFound();
                }
                int[] res = Methods.GetScore(userUpdto.userAnswers, userUpdto.Test, userUpdto.Score, _context).Result;

                var editUser = await _context.Users.FindAsync(id);

                editUser.Login = userUpdto.Login;
                editUser.Password = userUpdto.Password;
                editUser.Score = res[0];
                if (!_context.UserTests.Where(e => e.UserId == editUser.Id).Any(u => u.TestTried == userUpdto.Test))
                {
                    var testtried = new UserTestCount
                    {
                        TestTried = userUpdto.Test,
                        Time = userUpdto.Time,
                        Result = res[1],
                        UserId = id,
                        TriesCount = 1,
                    };
                    _context.UserTests.Add(testtried);
                    _context.SaveChanges();
                    if (res[1] == 100)
                    {
                        await Methods.ChangeStatistic(userUpdto.Test, editUser.Login, testtried.TriesCount, _context);
                    }
                    
                }
                else
                {
                    var testTried =  await _context.UserTests.Where(e => e.UserId == editUser.Id).FirstOrDefaultAsync(e => e.TestTried == userUpdto.Test);
                    testTried.Time = userUpdto.Time;
                    testTried.Result = res[1];
                    if (testTried.TriesCount == 0)
                    {
                        testTried.TriesCount = 1;
                    }
                    else
                    {
                        testTried.TriesCount += 1;
                    }
                    if (res[1] == 100)
                    {
                        await Methods.ChangeStatistic(userUpdto.Test, editUser.Login,  testTried.TriesCount, _context);
                    }
                }
                
                await Methods.ChangeStatistic(userUpdto.Test, _context);
                await _context.SaveChangesAsync();
                return res[1];
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Methods.ElemExists<User>(id, _context))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(UserDTO userdto)
        {
            var user = new User
            {
                Login = userdto.Login,
                Password = userdto.Password,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(Methods.UserToDTO(user));
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDTO>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (!Methods.ElemExists<User>(id, _context))
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Methods.UserToDTO(user);
        }
    }
}
