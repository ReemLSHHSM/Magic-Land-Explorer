using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ShowTime")]
        public string ShowTime { get; set; }
        public Destination(string name, string type, string location, string duration, string description, string showTime)
        {
            Name = name;
            Type = type;
            Location = location;
            Duration = duration;
            Description = description;
            ShowTime = showTime;
        }
    }
}
