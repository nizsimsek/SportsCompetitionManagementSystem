using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsEventsManagementSystem.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int CompId { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public string HomeScore { get; set; }
        public string AwayScore { get; set; }
        public string CompType { get; set; }
    }
}