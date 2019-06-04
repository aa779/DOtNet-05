﻿using DOtNet_05.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace DotNet_05.Controllers
{
    [Authorize]
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var userId = User.Identity.GetUserId();

            bool exists = _context.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == dto.FolloweeId);

            if (exists)
                return BadRequest("The following already exists.");

            var following = new Models.Following
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId
            };
            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }

    }
}
