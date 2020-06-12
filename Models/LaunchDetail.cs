using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceX_Launch.Models
{
    public class LaunchDetail: DynamicObject
    {
        public LaunchDetail()
        {
            PayloadRank = 0;
            PayloadMass = 0;
            LaunchStatus = "TBT";
        }
        public string LaunchDate { get; set; }
        public string LaunchTime { get; set; }
        public string RocketName { get; set; }
        public string LaunchStatus { get; set; }
        public int PayloadMass { get; set; }
        public int PayloadRank { get; set; }
    }
}
