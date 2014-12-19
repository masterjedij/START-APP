using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace START.Models
{
    public class EventsDb : DbContext
    {
        public EventsDb() : base("name=DefaultConnection") { }
        
        public DbSet<EmergencyType> Emergency { get; set; }

        public DbSet<FirstResponderType> FirstResponder { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}