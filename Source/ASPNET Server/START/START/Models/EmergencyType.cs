using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace START.Models
{
    public class EmergencyType
    {
        public int ID { get; set; }

        [Display(Name = "Emergency Type")]
        public string Emergency { get; set; }
    }
}