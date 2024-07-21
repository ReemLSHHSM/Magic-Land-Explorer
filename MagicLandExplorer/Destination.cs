using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    internal class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }

        public Destination(string name, string type, string location, TimeSpan duration, string description)
        {
            Name = name;
            Type = type;
            Location = location;
            Duration = duration;
            Description = description;
        }
    }
}
