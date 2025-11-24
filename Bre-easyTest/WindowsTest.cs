using Bre_easy;

namespace Bre_easyTest
{
    [TestClass]
    public sealed class WindowsTest
    {
        [TestMethod]
        public void TestCreateWindow()
        {
            Window window = new Window("Living Room Window", 1, DateTime.Now ,false);
            Assert.AreEqual("Living Room Window", window.WindowName);
            Assert.AreEqual(1, window.LocationId);
            Assert.AreEqual(false, window.IsOpen);
        }

        [TestMethod]
        public void TestTooShortWindowName()
        {
            Assert.ThrowsException<ArgumentException>(() => new Window("", 1, DateTime.Now, false));
        }



    }
}
