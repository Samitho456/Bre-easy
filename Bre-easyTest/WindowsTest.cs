using Bre_easy;

namespace Bre_easyTest
{
    [TestClass]
    public sealed class WindowsTest
    {
        [TestMethod]
        public void TestCreateWindow()
        {
            Window window = new Window("Living Room Window", 120, 60, false);
            Assert.AreEqual("Living Room Window", window.WindowName);
            Assert.AreEqual(120, window.windowWidth);
            Assert.AreEqual(60, window.WindowHeight);
            Assert.AreEqual(false, window.IsOpen);
        }

        [TestMethod]
        public void TestTooShortWindowName()
        {
            Assert.ThrowsException<ArgumentException>(() => new Window("", 120, 60, false));
        }

        [TestMethod]
        public void TestTooLongLocationName()
        {
            string longName = new string('A', 256);
            Assert.ThrowsException<ArgumentException>(() => new Window(longName, 120, 60, false));
        }

        [TestMethod]
        public void TestToggleWindowOpen()
        {
            Window window = new Window("Bedroom Window", 100, 50, false);
            window.ToggleOpen();
            Assert.AreEqual(true, window.IsOpen);
            window.ToggleOpen();
            Assert.AreEqual(false, window.IsOpen);
        }
    }
}
