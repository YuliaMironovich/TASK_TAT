using System;
using System.Collections.Generic;

namespace test1_task4
{
    /// <summary>
    /// Main class of the program which realized the "Sea battle" game.
    /// The playeer enters coordinate by the keyboard.
    /// If the coordinate entered from the console coincides with the ship's coordinate, it is considered sunk.
    /// The game continues as long as all the ships will not be sunk. 
    /// At the end of the game, the number of sunken ships and the number of shots required are displayed.
    /// </summary>
    class EntryPoint
    {
        private const string ERROR = "\nCheck your input data.";
        private const string END = "Congratulations! You drowned all the ships. You needed next numbers of shots: ";
        private const string REITERATION = "You entered this coordinate.";
        /// <summary>
        /// This method is the input point of the "Sea battle" program.
        /// </summary>
        static void Main()
        {
            bool continueProgram = true;
            while(continueProgram)
            {
                try
                {
                    Field field = new Field();
                    List <Coordinate> listOfCoordinates = new List<Coordinate>();
                    List<Coordinate> listOfShips = new List<Coordinate>();
                    List<Coordinate> listOfPlayerCoordinates = new List<Coordinate>();
                    Player player = new Player();
                    listOfCoordinates = field.Create();
                    listOfShips = field.SetShips(listOfCoordinates);
                    int countOfShots = 0;
                    while(listOfShips.Count > 0)
                    {
                        Coordinate playerCoordinate = player.TakeAim();
                        if(!listOfPlayerCoordinates.Contains(playerCoordinate))
                        {
                            listOfPlayerCoordinates.Add(playerCoordinate);
                            listOfShips = player.Fire(playerCoordinate, listOfShips);                    
                            countOfShots++;
                        }
                        else
                        {
                            Console.WriteLine(REITERATION);
                        }               
                    }
                    Console.WriteLine(END + countOfShots);
                    continueProgram = false;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e + ERROR);
                    continue;
                }
            }
        }
    }
}
