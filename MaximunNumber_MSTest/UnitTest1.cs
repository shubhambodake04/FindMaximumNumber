using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindMaximumNumber;

namespace MaximunNumber_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaximumInteger()
        {
            int result = Check.MaximumInteger(11, 22, 33);
            Assert.AreEqual(result, 33);
        }
    }
}
