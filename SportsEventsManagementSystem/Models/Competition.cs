using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsEventsManagementSystem.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public string Referee { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
    }
}