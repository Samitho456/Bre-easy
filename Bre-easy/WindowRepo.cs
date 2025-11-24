using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bre_easy
{
    public class WindowRepo : IRepo<Window>
    {
        private List<Window> _windowDb = new List<Window>();

        public WindowRepo() { }

        public void Add(Window obj)
        {
            
        
        }

        public IEnumerable<Window> GetAll()
        {
            throw new NotImplementedException();
        }

        public Window GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Window GetByLocation(int id)
        {
            throw new NotImplementedException();
        }

        public Window Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Window Update(int id, Window obj)
        {
            throw new NotImplementedException();
        }
    }
}
