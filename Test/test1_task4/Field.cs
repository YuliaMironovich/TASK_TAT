using System;
using System.Collections.Generic;

namespace test1_task4
{
    /// <summary>
    /// Class contains methods whick allow to create the field with 10*10 coordinates.
    /// Such field is called horizontally from "A" letter to "J" letter alphabetically
    /// and vertically from 1 to 10.
    /// Maximum numbers of ships in context of condition - 25.
    /// </summary>
    public class Field
    {
        private const char MINLETTER = 'A';
        private const char MAXLETTER = 'J';
        private const int MINNUMBER = 1;
        private const int MAXNUMBER = 10;
        private const int MAXSHIPNUMBER = 25;

        /// <summary>
        /// Method creates list of coordinates which are contained in field.
        /// </summary>
        /// <returns>This list of coordinates.</returns>
        public List<Coordinate> Create()
        {
            List<Coordinate> listOfCoordinate = new List<Coordinate>();
            for (int i = MINLETTER; i <= MAXLETTER; i++)
            {
                for (int j = MINNUMBER; j <= MAXNUMBER; j++)
                {
                    
                    char x = (char)i;
                    int y = j;
                    Coordinate coordinate = new Coordinate(x, y);
                    listOfCoordinate.Add(coordinate);
                }
            }
            return listOfCoordinate;
        }

        /// <summary>
        /// Method arranges ships on the field.
        /// Each ship occupies one cage and can not be located in the next cage with another ship.
        /// </summary>
        /// <param name="listOfCoordinates">List of coordinates in which we can arrange a ship.</param>
        /// <returns>List coordinates in which arranged arbitrary number of ships.</returns>
        public List<Coordinate> SetShips(List<Coordinate> listOfCoordinates)
        {
            Random random = new Random();
            List<Coordinate> listOfShips = new List<Coordinate>();
            int countOfShips = random.Next(1, MAXSHIPNUMBER);
            int temp = 0;
            while(listOfCoordinates.Count > 0 && temp <= countOfShips)
            {
                Coordinate ship = listOfCoordinates[random.Next(0, listOfCoordinates.Count - 1)];
                listOfShips.Add(ship);
                listOfCoordinates = SetShipBorders(listOfCoordinates, ship);
                temp++;
            }
            return listOfShips;
        }

        /// <summary>
        /// Method arrages the borders of each set ship that other ship can not be located in the next cage with set ship.
        /// </summary>
        /// <param name="listOfCoordinates">List of coordinates in which set the borders. </param>
        /// <param name="ship">This is the ship which just set in the field.</param>
        /// <returns>List of unoccupied coordinates.</returns>
        private List<Coordinate> SetShipBorders(List<Coordinate> listOfCoordinates, Coordinate ship)
        {
            for (int i = ship.X - 1; i <= ship.X + 1; i++)
            {
                for (int j = ship.Y - 1; j <= ship.Y + 1; j++)
                {
                    char x = (char)i;
                    int y = j;
                    Coordinate coordinateOfShipBorder = new Coordinate(x, y);
                    if (listOfCoordinates.Contains(coordinateOfShipBorder))
                    {
                        listOfCoordinates.RemoveAt(listOfCoordinates.IndexOf(coordinateOfShipBorder));
                    }
                }
            }
            return listOfCoordinates;
        }
    }
}
