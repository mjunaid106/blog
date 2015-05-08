using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tests
{
    public class TestBase
    {
        [TestInitialize]
        public void Init()
        {
            Services.AutoMapperConfig.RegisterMappings();
        }
    }
}
