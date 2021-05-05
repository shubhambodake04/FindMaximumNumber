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
            int result = Check<int>.Maximum(11, 22, 33);
            Assert.AreEqual(result, 33);
        }

        [TestMethod]
        public void MaximumFloat()
        {
            float result = Check<float>.Maximum(4.8f, 2.7f, 3.9f);
            Assert.AreEqual(result, 4.8f);
        }

        [TestMethod]
        public void MaximumString()
        {
            string result = Check<string>.Maximum("shubham","amol","ravi");
            Assert.AreEqual(result, "shubham");
        }
    }
}
