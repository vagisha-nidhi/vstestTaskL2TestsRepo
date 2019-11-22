using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod6()
        {
            Assert.Inconclusive();
        }
    }
}
