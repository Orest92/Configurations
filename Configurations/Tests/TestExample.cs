using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations
{
    [TestFixture]
    public class TestExample
    {
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(2 + 2 == 4, "Always passing");
        }
    }
}
