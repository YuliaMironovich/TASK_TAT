using System;
using System.Collections.Generic;

namespace test1_task4
{
    /// <summary>
    /// Class contains method which allow player make certain actions:
    /// take aim at assumed coordinate with the ship, and fire at this coordinate. 
    /// </summary>
    public class Player
    {
        private const string PLAYER_COORDINATE = "Enter your coordinate:";
        private const string DROWNING = "The ship is sunk.";
        private const string SLIP = "You missed, try again.";
        private const string INCORRECT_DATA = "You entered incorrect values for the coordinates.";

        /// <summary>
        /// Methods allow player to take aim: player input coordinate by the keyboard.
        /// </summary>
        /// <returns>Input player coordinate.</returns>
        public Coordinate TakeAim()
        {
            Console.WriteLine(PLAYER_COORDINATE);
            string coordinate = Console.ReadLine();
            char x = Char.ToUpper(coordinate.ToCharArray(0, 1)[0]);
            int y = Int32.Parse(coordinate.Substring(1));
            Coordinate playerCoordinate = new Coordinate(x, y);
            return playerCoordinate;
        }

        /// <summary>
        /// Method allow player to fire at assumed coordinate with the ship.
        /// </summary>
        /// <param name="playerCoordinate">Assumed coordinate of player with the ship.</param>
        /// <param name="listOfShips">List with all ships.</param>
        /// <returns>Shot result of the player. </returns>
        public List<Coordinate> Fire(Coordinate playerCoordinate, List<Coordinate> listOfShips)
        {
            if (playerCoordinate.X == '\0' || playerCoordinate.Y == 0)
            {
                Console.WriteLine(INCORRECT_DATA);
                return listOfShips;
            }
            if (listOfShips.Contains(playerCoordinate))
            {
                Console.WriteLine(DROWNING);
                listOfShips.RemoveAt(listOfShips.IndexOf(playerCoordinate));
            }
            else
            {
                Console.WriteLine(SLIP);
            }
            return listOfShips;
        }
    }
}
