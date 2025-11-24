namespace Bre_easy
{
    public class Window
    {
        private string _windowName;
        private int _windowWidth;
        private int _windowHeight;
        private bool _isOpen;

        public string WindowName
        {
            get { return _windowName; }
            set { _windowName = value; }
        }

        public int windowWidth
        {
            get { return _windowWidth; }
            set { _windowWidth = value; }
        }

        public int WindowHeight
        {
            get { return _windowHeight; }
            set { _windowHeight = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }
        public void ToggleOpen()
        {
            _isOpen = !_isOpen;
        }

        public Window(string WindowName, int WindowWidth, int WindowHeight, bool IsOpen)
        {
            _windowName = WindowName;
            _windowHeight = WindowHeight;
            _windowWidth = WindowWidth;
            _isOpen = IsOpen;
        }

    }
}
