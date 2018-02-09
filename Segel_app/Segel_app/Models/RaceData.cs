using System;
using System.Collections.Generic;
using System.Text;

namespace Segel_app.Models
{
    class RaceData
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }

        public RaceData(string name, DateTime startTime)
        {
            Name = name;
            StartTime = startTime;
        }
    }
}
