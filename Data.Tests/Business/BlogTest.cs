using Core.Business;
using Core.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests.Business
{
    [TestClass]
    public class BlogTest
    {
        [TestMethod]
        [TestCategory("BlogTest")]
        public void GetAll()
        {
            IEnumerable<Post> post = Blog.GetAll();
            Assert.IsNotNull(post);
        }

    }
}
