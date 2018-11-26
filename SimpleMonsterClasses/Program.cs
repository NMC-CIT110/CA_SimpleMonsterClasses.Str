using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonsterSid(string name)
        {
            SeaMonster sid = new SeaMonster("Sid");

            sid.Weight = 2.5;
            sid.CanUseFreshwater = true;

            return sid;
        }

        static SeaMonster InitializeSeaMonsterSuzy()
        {
            SeaMonster suzy = new SeaMonster();

            suzy.Name = "Suzy";
            suzy.Weight = 1.2;
            suzy.CanUseFreshwater = true;

            return suzy;
        }

        static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {

        }

        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)
        {
            DisplayHeader("List of Sea Monsters");

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }

            DisplayContinuePrompt();
        }

        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)
        {

        }

        static void DisplayMenu()
        {
            //
            // instantiate sea monsters
            //
            SeaMonster suzy;
            suzy = InitializeSeaMonsterSuzy();
            SeaMonster sid;
            sid = InitializeSeaMonsterSid("Sid");

            //
            // add sea monsters to list
            //
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            seaMonsters.Add(suzy);
            seaMonsters.Add(sid);

            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Display All Sea Monsters");
                Console.WriteLine("\tB) User Add a Sea Monster");
                Console.WriteLine("\tC) ");
                Console.WriteLine("\tE) ");
                Console.WriteLine("\tF) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllSeaMonsters(seaMonsters);
                        break;

                    case "B":
                    case "b":

                        break;

                    case "C":
                    case "c":

                        break;

                    case "D":
                    case "d":

                        break;

                    case "E":
                    case "e":

                        break;

                    case "F":
                    case "f":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to Simple Monster Classes");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tThanks for using Simple Monster Classes.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
    }
}
