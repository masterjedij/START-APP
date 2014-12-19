using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace START.Models
{
    public class Event
    {
        public int ID { get; set; }

        [Display(Name = "Date")]
        [Required]
        public DateTime IncidentDate { get; set; }

        [Display(Name = "Time")]
        [Required]
        public DateTime IncidentTime { get; set; }

        [Display(Name = "IP Address")]
        [Required]
        public double IPAddress { get; set; }

        [Display(Name = "User ID")]
        [Required]
        public string UserID { get; set; }

        public int FirstResponderTypeId { get; set; }

        public IList<int> FirstResponderTypeIds { get; set; }

        [Display(Name = "First Responders")]
        [Required]
        public virtual FirstResponderType FirstResponder { get; set; }

        public int EmergencyTypeId { get; set; }

        public IList<int> EmergencyTypeIds { get; set; }

        [Display(Name = "Emergency Type")]
        [Required]
        public virtual EmergencyType Emergency { get; set; }

    }
}