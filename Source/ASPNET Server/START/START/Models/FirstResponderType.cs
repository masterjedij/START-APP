using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace START.Models
{
    public class FirstResponderType
    {
        public int ID { get; set; }

        [Display(Name = "First Responder")]
        public string FirstResponder { get; set; }
    }
}