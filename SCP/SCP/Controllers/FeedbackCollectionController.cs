using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCP.Context;
using SCP.Model;
using SCP.ViewModels;

namespace SCP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackCollectionController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public FeedbackCollectionController(DatabaseContext context)
        {
            _context = context;
        }

        [Route("GetByPosts")]
        [HttpGet]
        public async Task<ActionResult<FeedbackCollectionViewModel>> GetByPosts()
        {
            List<Posts> master = _context.Posts
                .Include(d => d.PostDetails).ToList();
                

            var postRecord = (from m in master
                               select new
                               {
                                   m.Id,
                                   m.PostTitle,
                                   PostDetails = (from q1 in m.PostDetails
                                                    select new
                                                    {
                                                        q1.Id,
                                                        q1.Admin,
                                                        q1.CommentDate,
                                                        q1.Comments
                                                    }).ToList()
                               }).ToList();

            return Ok(postRecord);
        }

    }
}
