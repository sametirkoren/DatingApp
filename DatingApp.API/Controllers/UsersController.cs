using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{

    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;


        public UsersController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        [Authorize]
        [HttpGet("{id}")]
        
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);

           
        }
    }
}
