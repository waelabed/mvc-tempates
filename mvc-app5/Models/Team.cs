using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_app5.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string img { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string GooglePlusUrl { get; set; }
    }
}