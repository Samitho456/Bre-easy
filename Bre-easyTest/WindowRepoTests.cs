using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bre_easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bre_easy.Tests
{
    [TestClass()]
    public class WindowRepoTests
    {
        private IRepo<Window> _windowRepo;
        [TestInitialize]
        public void Setup()
        {
            _windowRepo = new WindowRepo();
            _windowRepo.Add(new Window(1, "Kitchen Window", 1, DateTime.Now.AddHours(-2), false));
            _windowRepo.Add(new Window(1, "Living Room Window", 2, DateTime.Now.AddHours(-1), true));
            _windowRepo.Add(new Window(1, "Bedroom Window", 3, DateTime.Now.AddHours(-3), false));

        }

        [TestMethod()]
        public void AddTest()
        {
            _windowRepo.Add(new Window(1, "Bathroom Window", 4, DateTime.Now, true));
            var allWindows = _windowRepo.GetAll();
            Assert.AreEqual(4, allWindows.Count());

        }

        [TestMethod()]
        public void GetAllTest()
        {
            var allWindows = _windowRepo.GetAll();
            Assert.AreEqual(3, allWindows.Count());
            Assert.IsTrue(allWindows.Any(w => w.WindowName == "Kitchen Window"));
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var window = _windowRepo.GetById(2);
            Assert.IsNotNull(window);
            Assert.AreEqual("Living Room Window", window.WindowName);
        }

        [TestMethod()]
        public void GetByLocationTest()
        {
            var window = _windowRepo.GetByLocation(3);
            Assert.IsNotNull(window);
            Assert.AreEqual("Bedroom Window", window.WindowName);
            Assert.AreEqual(3, window.LocationId);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var removedWindow = _windowRepo.Remove(1);
            Assert.IsNotNull(removedWindow);
            Assert.AreEqual("Kitchen Window", removedWindow.WindowName);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var updatedWindow = new Window(1, "Updated Living Room Window", 2, DateTime.Now, false);
            var result = _windowRepo.Update(2, updatedWindow);
            Assert.IsNotNull(result);
            Assert.AreEqual("Updated Living Room Window", result.WindowName);
        }
    }
}