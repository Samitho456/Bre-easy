namespace Bre_easy
{
    public class Window
    {
        private string _windowName;

        public string WindowName
        {
            get { return _windowName; }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Window name must be 2 or more characters.");
                }
                _windowName = value;
            }
        }

        public int LocationId { get; set; }

        public DateTime TimeLastOpened { get; set; }

        public bool IsOpen { get; set; }

        public Window(string windowName, int locationId , DateTime timeLastOpened, bool isOpen)
        {
            WindowName = windowName;
            LocationId = locationId;
            TimeLastOpened = timeLastOpened;
            IsOpen = isOpen;
        }

    }
}
