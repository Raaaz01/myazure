using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApp.UnitTests
{
    [TestClass]
    public class WebApp_UnitTests
    {
        [TestMethod]
        public void WebApp_DemoTest_1()
        {
            Assert.AreEqual(1, 2, "Number should be equal!");
        }
    }
}
