﻿using System;

namespace candy_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SetupNewApp();
            var userInput = MainMenu(db);

            while (userInput.Key != ConsoleKey.D0)
            {
                userInput = MainMenu(db);
                if (userInput.Key == ConsoleKey.D2)
                {
                    var candyTypeMenu = new View()
                        .AddMenuOption("What type of candy would you like?");
                        Console.Write(candyTypeMenu.GetFullMenu());
                    DisplayCandyTypes(db);
                    
                }
            }
        }

        internal static CandyStorage SetupNewApp()
        {
            Console.Title = "Cross Confectioneries Incorporated";

            var db = new CandyStorage();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            return db;
        }

        internal static ConsoleKeyInfo MainMenu(CandyStorage db)
        {
            View mainMenu = new View()
                .AddMenuOption("Add new candy")
                .AddMenuOption("Eat candy")
                .AddMenuText("Press 0 to exit.");
            Console.Write(mainMenu.GetFullMenu());
            var userOption = Console.ReadKey();
            return userOption;
        }

        internal static void AddNewCandy(CandyStorage db)
        {
            var candyTypes = db.GetCandyTypes();
            var newCandyMenu = new View()
                .AddMenuText("What type of candy did you get?")
                .AddMenuOptions(candyTypes);
            Console.Write(newCandyMenu.GetFullMenu());

            var selectedCandyType = Console.ReadKey();
            db.SaveNewCandy(selectedCandyType.Key);

        }
           
        //***********EAT CANDY**************************//
            internal static void DisplayCandyTypes(CandyStorage db)
            {
                var candyType = db.GetCandyTypes();
                var candyTypeMenu = new View()
                    .AddMenuText("Which type of candy would you like?")
                    .AddMenuOptions(candyType);
                Console.Write(candyTypeMenu.GetFullMenu());

                var selectedType = Console.ReadKey().KeyChar.ToString();
            
                DisplayCandyNames(db);
            

            Console.ReadKey();                
            }

        internal static void DisplayCandyNames(CandyStorage db)
        {
            var candyName = db.GetNames();
            var candyNameMenu = new View()
                .AddMenuText("Select from the following:")
                .AddMenuOptions(candyName);
            Console.Write(candyNameMenu.GetFullMenu());
            Console.ReadKey();
        }
    }
}
