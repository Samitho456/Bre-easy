using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bre_easy
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public Location() { }
        public Location(int id, string locationName)
        {
            Id = id;
            LocationName = locationName;
        }

        public override string ToString()
        {
            return $"Location Id: {Id}, Location Name: {LocationName}";
        }
    }
}
