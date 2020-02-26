using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 550;
            int result = laba1.Program.Example(n);
            Assert.AreEqual(9, result);
        }
    }
}
