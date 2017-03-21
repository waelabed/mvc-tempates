using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_app5.Models
{
    public class TeamVm
    {
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string img { get; set; }
        public HttpPostedFileBase imgAttach { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string GooglePlusUrl { get; set; }
        
    }
}