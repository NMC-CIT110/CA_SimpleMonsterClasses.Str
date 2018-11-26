using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SimpleMonsterClasses
{
    class Program
    {
        // *********************************************************
        //
        // [add comment block]
        //
        // *********************************************************
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        /// <summary>
        /// instantiate and initialize sid the sea monster
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>SeaMonster object</returns>
        static SeaMonster InitializeSeaMonsterSid(string name)
        {

        }

        /// <summary>
        /// instantiate and initialize suzy the sea monster
        /// </summary>
        /// <returns>SeaMonster object</returns>
        static SeaMonster InitializeSeaMonsterSuzy()
        {

        }

        /// <summary>
        /// display all information about a sea monster
        /// </summary>
        /// <param name="seaMonster">SeaMonster object</param>
        static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {

        }

        /// <summary>
        /// display a list of all sea monsters
        /// </summary>
        /// <param name="seaMonsters">list of SeaMonster</param>
        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)
        {

        }

        /// <summary>
        /// display a screen to get a new sea monster from the user
        /// </summary>
        /// <param name="seaMonsters">list of SeaMonster</param>
        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)
        {

        }

        /// <summary>
        /// display menu and process user menu choices
        /// </summary>
        static void DisplayMenu()
        {
            //
            // instantiate sea monsters
            //

            //
            // add sea monsters to list
            //

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

        #region HELPER METHODS

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

        #endregion


    }
}
