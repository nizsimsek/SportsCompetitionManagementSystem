using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsEventsManagementSystem.Models
{
    public class SEMSInitilializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SEMSContext>
    {
        public void Data(SEMSContext context)
        {
            var users = new List<User>
            {
                new User{Id = 1, Username = "nizadmin", Email = "admin@admin.com", Password = "123", Name = "Nizamettin", Surname = "Şimşek", Role = "Admin" },
                new User{Id = 2, Username = "emir", Email = "user@user.com", Password = "123", Name = "Emir", Surname = "Şimşek", Role = "User" }
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var competitions = new List<Competition>
            {
                new Competition{Id = 101, Home = "Fenerbahçe", Away = "Galatasaray", Referee = "Ali Orhan", Date = DateTime.Parse("2021-08-08"), Time = "14:15", Type = "Futbol"},
                new Competition{Id = 102, Home = "VakıfBank", Away = "Eczacıbaşı", Referee = "Ahmet Erdem", Date = DateTime.Parse("2021-10-01"), Time = "20:15", Type = "Voleybol"},
                new Competition{Id = 103, Home = "Fenerbahçe Beko", Away = "FC Bayern Munich", Referee = "Danny Makkelie", Date = DateTime.Parse("2021-07-10"), Time = "12:00", Type = "Basketbol"},
                new Competition{Id = 104, Home = "Jiri Vesely", Away = "Yannick Hanfmann", Referee = "Roberto Bautista", Date = DateTime.Parse("2021-08-08"), Time = "11:00", Type = "Tenis"}
            };
            competitions.ForEach(c => context.Competitions.Add(c));
            context.SaveChanges();

            var players = new List<Player>
            {
                new Player{Id = 1, Name = "Altay", Surname = "Bayındır", UniformNumber = "1", Team = "Fenerbahçe", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1998-05-14")},
                new Player{Id = 2, Name = "Ozan", Surname = "Tufan", UniformNumber = "7", Team = "Fenerbahçe", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1995-03-23")},
                new Player{Id = 3, Name = "Fernando", Surname = "Muslera", UniformNumber = "1", Team = "Galatasaray", Nationality = "Arjantin", DateofBirth = DateTime.Parse("1986-06-16")},
                new Player{Id = 4, Name = "Radamel", Surname = "Falcao", UniformNumber = "36", Team = "Galatasaray", Nationality = "Kolombiya", DateofBirth = DateTime.Parse("1986-02-10")},
                new Player{Id = 5, Name = "Melis", Surname = "Gürkaynak", UniformNumber = "8", Team = "Vakıfbank", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1990-04-20")},
                new Player{Id = 6, Name = "Cansu", Surname = "Özbay", UniformNumber = "3", Team = "Vakıfbank", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1996-10-17")},
                new Player{Id = 7, Name = "Tuğba", Surname = "Şenoğlu", UniformNumber = "4", Team = "Vakıfbank", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1998-02-02")},
                new Player{Id = 8, Name = "Tijana", Surname = "Boskovic", UniformNumber = "3", Team = "Eczacıbaşı", Nationality = "Sırbistan", DateofBirth = DateTime.Parse("1997-03-08")},
                new Player{Id = 9, Name = "Hande", Surname = "Baladın", UniformNumber = "7", Team = "Eczacıbaşı", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1997-09-01")},
                new Player{Id = 10, Name = "Jordan", Surname = "Thompson", UniformNumber = "9", Team = "Eczacıbaşı", Nationality = "Amerika", DateofBirth = DateTime.Parse("1997-05-05")},
                new Player{Id = 11, Name = "Luigi", Surname = "Datome", UniformNumber = "2", Team = "Fenerbahçe Beko", Nationality = "İtalya", DateofBirth = DateTime.Parse("1987-11-27")},
                new Player{Id = 12, Name = "Melih", Surname = "Mahmutoğlu", UniformNumber = "7", Team = "Fenerbahçe Beko", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1990-05-12")},
                new Player{Id = 13, Name = "Paul", Surname = "Zipser", UniformNumber = "1", Team = "FC Bayern Munich", Nationality = "Almanya", DateofBirth = DateTime.Parse("1994-02-18")},
                new Player{Id = 14, Name = "Sasha", Surname = "Grant", UniformNumber = "8", Team = "FC Bayern Munich", Nationality = "İtalya", DateofBirth = DateTime.Parse("2002-02-15")},
                new Player{Id = 13, Name = "Jiri", Surname = "Vesely", UniformNumber = "1", Team = "", Nationality = "Çek Cumhuriyeti", DateofBirth = DateTime.Parse("1993-07-10")},
                new Player{Id = 14, Name = "Yannick", Surname = "Hanfmann", UniformNumber = "1", Team = "", Nationality = "Almanya", DateofBirth = DateTime.Parse("1991-11-13")}
            };
            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();

            var referees = new List<Referee>
            {
                new Referee{Id = 1, Name = "Ali", Surname = "Orhan", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1987-03-12"), MissionField = "Futbol" },
                new Referee{Id = 1, Name = "Ahmet", Surname = "Erdem", Nationality = "Türkiye", DateofBirth = DateTime.Parse("1993-04-22"), MissionField = "Voleybol" },
                new Referee{Id = 1, Name = "Danny", Surname = "Makkelie", Nationality = "Almanya", DateofBirth = DateTime.Parse("1979-03-02"), MissionField = "Basketbol" },
                new Referee{Id = 1, Name = "Roberto", Surname = "Bautista", Nationality = "Brezilya", DateofBirth = DateTime.Parse("1990-12-10"), MissionField = "Tenis" }
            };
            referees.ForEach(r => context.Referees.Add(r));
            context.SaveChanges();

            var scores = new List<Score>
            {
                new Score{Id = 1, CompId = 101, Home = "Fenerbahçe", Away = "Galatasaray", HomeScore = "3", AwayScore = "1", CompType = "Futbol"},
                new Score{Id = 2, CompId = 102, Home = "Vakıfbank", Away = "Eczacıbaşı", HomeScore = "3", AwayScore = "2", CompType = "Voleybol"},
                new Score{Id = 3, CompId = 103, Home = "Fenerbahçe Beko", Away = "FC Bayern Munich", HomeScore = "99", AwayScore = "102", CompType = "Basketbol"},
                new Score{Id = 4, CompId = 104, Home = "Jiri Vesely", Away = "Yannick Hanfmann", HomeScore = "3", AwayScore = "1", CompType = "Tenis"}
            };
            scores.ForEach(s => context.Scores.Add(s));
            context.SaveChanges();
        }
    }
}