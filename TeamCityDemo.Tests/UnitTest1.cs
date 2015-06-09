
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCityDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("abcd", "abcd");
        }

    }
}
