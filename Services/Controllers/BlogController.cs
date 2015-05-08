using AutoMapper;
using Core.Business;
using Core.Contexts;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controllers
{
    public class BlogController : ApiController
    {
        public IEnumerable<Post> GetAllPosts(User user)
        {
            IEnumerable<Core.DataContracts.Post> posts = Blog.GetAll();
            return Mapper.Map<IEnumerable<Post>>(posts);
        }

        public IEnumerable<Post> GetPosts(User user, DateTime startDate, DateTime endDate)
        {
            //IEnumerable<Post> posts = MongoContext.GetPosts(user.Username, startDate, endDate);
            //return posts;
            return null;
        }
    }
}
