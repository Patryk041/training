using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Toci.Web.Training.Primary.Models
{
    public class FrogieModel
    {
        public string Warrior; // { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public int Test { get; set; }
    }
}