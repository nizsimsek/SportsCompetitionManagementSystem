using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsEventsManagementSystem.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UniformNumber { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Team { get; set; }
    }
}