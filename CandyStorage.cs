using System;
using System.Collections.Generic;
using System.Linq;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _candies = new List<Candy>()
        {
            new Candy() { Name = "Life Saver", Manufacturer = "WM. Wrigley Jr.", Type = "hard", Date = DateTime.Now.AddYears(1) },
            new Candy() { Name = "Twix", Manufacturer = "Mars, Incorporated", Type = "chocolate", Date = DateTime.Now.AddDays(5) },
            new Candy() { Name = "AirHeads", Manufacturer = "Perfetti Van Melle", Type = "chewy", Date = DateTime.Now.AddDays(10) },
            new Candy() { Name = "Jolly Rancher", Manufacturer = "Hershey", Type = "hard", Date = DateTime.Now.AddHours(1) },
            new Candy() { Name = "Snickers", Manufacturer = "Mars, Incorporated", Type = "chocolate", Date = DateTime.Now.AddDays(7) },
            new Candy() { Name = "Laffy Taffy", Manufacturer = "Nestle", Type = "chewy", Date = DateTime.Now.AddDays(12) },
            new Candy() { Name = "Jawbreaker", Manufacturer = "Palmer Candy Company", Type = "hard", Date = DateTime.Now.AddDays(42) },
            new Candy() { Name = "Kit Kat", Manufacturer = "Nestle", Type = "chocolate", Date = DateTime.Now.AddDays(22) },
            new Candy() { Name = "Sweet Tarts", Manufacturer = "Nestle", Type = "chewy", Date = DateTime.Now },
            new Candy() { Name = "Dum Dum", Manufacturer = "Akron Candy Company", Type = "hard", Date = DateTime.Now.AddDays(15) },
            new Candy() { Name = "M&M's", Manufacturer = "Mars, Incorporated", Type = "chocolate", Date = DateTime.Now},
            new Candy() { Name = "Big League Chew", Manufacturer = "Mars, Incorporated", Type = "chewy", Date = DateTime.Now.AddHours(22)  }
        };


        public IList<string> GetNames()
        {
            return _candies.Select(c => c.Name).Distinct().ToList();
        }
        public IList<string> GetCandyTypes()
        {
            return _candies.Select(c => c.Type).Distinct().ToList();
        }

        internal void SaveNewCandy(ConsoleKey key)
        {
            throw new NotImplementedException();
        }
    }
}