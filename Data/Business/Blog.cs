using Core.Contexts;
using Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public class Blog
    {
        static PostContext postContext;

        static Blog()
        {
            postContext = new PostContext();
        }

        public static IEnumerable<Post> GetAll()
        {
            IEnumerable<Post> post = postContext.GetAll();

            return post;
        }
    }
}
