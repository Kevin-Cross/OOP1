using System;
using System.Collections.Generic;
using Utilities;

namespace Lab1
{
    class Program
    {

        static List<Media> medias = new List<Media>();
        static void Main(string[] args)
        {
            MenuChoice c = MenuChoice.AddMovie;
            while (c != MenuChoice.Quit)
            {
                Console.WriteLine("Please choose from the following:");
                var menuchoice = Enum.GetValues(typeof(MenuChoice));
                foreach (var i in menuchoice)
                    Console.WriteLine($"  [{i:D}] {i:G}");
                Console.Write("Your choice: ");
                Enum.TryParse(Console.ReadLine(), out c);
                switch (c)
                {
                    
                    

                    case MenuChoice.AddMovie:
                        Movie m1 = new Movie(ConsoleHelpers.ReadInt("Enter Movie ID: ", 1, 999999), ConsoleHelpers.ReadString("Enter Movie TItle: ", 1, 15), ConsoleHelpers.ReadString("Enter Movie Publisher: ", 1, 15), ConsoleHelpers.ReadString("Enter Movie Creator: ", 1, 15), ConsoleHelpers.ReadDate("Enter Movie Publish Date: ", new DateTime(1878, 01, 02), new DateTime(2099, 12, 31)), ConsoleHelpers.ReadInt("Enter Movie RunTime: ", 1, 999999), ConsoleHelpers.ReadEnum<Ratings>("Enter Movie Rating: "));
                        medias.Add(m1);
                        break;
                    case MenuChoice.AddBook:
                        Book b1 = new Book(ConsoleHelpers.ReadInt("Enter Book ID: ", 1, 999999), ConsoleHelpers.ReadString("Enter Book TItle: ", 1, 15), ConsoleHelpers.ReadString("Enter Book Publisher: ", 1, 15),ConsoleHelpers.ReadString("Enter Book Author: ", 1, 15),ConsoleHelpers.ReadDate("Enter Book Publish Date: ", new DateTime(1878, 01, 02), new DateTime(2099, 12, 31)),ConsoleHelpers.ReadInt("Enter Pages: ", 1, 999999),ConsoleHelpers.ReadEnum<ReadingLevel>("Enter Reading Level: "));
                        medias.Add(b1);
                        break;
                    case MenuChoice.AddGame:
                        Game g1 = new Game(ConsoleHelpers.ReadInt("Enter Game ID: ", 1, 999999), ConsoleHelpers.ReadString("Enter Game TItle: ", 1, 15), ConsoleHelpers.ReadString("Enter Game Publisher: ", 1, 15), ConsoleHelpers.ReadString("Enter Game Creator: ", 1, 15), ConsoleHelpers.ReadDate("Enter Game Publish Date: ", new DateTime(1878, 01, 02), new DateTime(2099, 12, 31)), ConsoleHelpers.ReadInt("Enter Play time: ", 1, 999999), ConsoleHelpers.ReadEnum<Platform>("Enter Game Platform: "));
                        medias.Add(g1);
                        break;
                   
                            
                }
                foreach (Media i in medias)
                {
                    i.Print();
                }
                Console.WriteLine("Press <ENTER> to continue...");
                Console.ReadLine();

            }



            Console.WriteLine("Press <ENTER> to quit...");
            Console.ReadLine();
        }
    }
}
