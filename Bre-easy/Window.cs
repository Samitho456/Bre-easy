namespace Bre_easy
{
    public class Window
    {
        private string _windowName;
        private string _location;
        private string _timeLastOpened;
        private bool _isOpen;

        public string WindowName
        {
            get { return _windowName; }
            set { _windowName = value; }
        }

        public string Location 
        { 
            get { return _location; } 
            set { _location = value; }
        }

        public DateTime TimeLastOpened
        {
            get { return _timeLastOpened; }
            set { _timeLastOpened = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public Window(string WindowName, string Location, DateTime TimeLastOpened, bool IsOpen)
        {
            _windowName = WindowName;
            _location = Location;
            _timeLastOpened = TimeLastOpened;
            _isOpen = IsOpen;
        }

    }
}
