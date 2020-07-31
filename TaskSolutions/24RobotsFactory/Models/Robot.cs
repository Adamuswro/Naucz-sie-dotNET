using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24RobotsFactory.Models
{
    public class Robot
    {
        public string Id { get; set; }
        public RobotParameter Parameter { get; set; }

        public override string ToString()
        {
            return $"Robot {Id}. Function: {Parameter}";
        }
    }
}
