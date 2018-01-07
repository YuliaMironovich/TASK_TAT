namespace test1_task3
{
    /// <summary>
    /// Class contains method which checks for validity of the entered automobile parameters.
    /// </summary>
    public class ValidatorOfAutomobileParameters
    {
        /// <summary>
        /// Method checks for validity of the automobile parameters.
        /// </summary>
        /// <param name="type">Type of automobile which can only takes the following string values: sedan, estate, SUV.</param>
        /// <param name="price">Price of automobile which can takes the values more than 0.</param>
        /// <returns>True if parameters are valid, false if parameters are not valid.</returns>
        public bool IsValid(string type, int price)
        {
            return (IsValidType(type) && IsValidPrice(price));
        }

        /// <summary>
        /// Method checks for validity of the automobile type.
        /// </summary>
        /// <param name="type">type of automobile which can only takes the following string values: sedan, estate, SUV</param>
        /// <returns>true if type is valid, false if type is not valid</returns>
        private bool IsValidType(string type)
        {
            bool typeValidation = false;
            if(type.ToLower() == "sedan" || type.ToLower() == "estate" || type.ToUpper() == "SUV")
            {
                typeValidation = true;
            }
            return typeValidation;              
        }

        /// <summary>
        /// Method checks for validity of the automobile price.
        /// </summary>
        /// <param name="price">Price of automobile which can takes the values more than 0.</param>
        /// <returns>True if price is valid, false if price is not valid.</returns>
        private bool IsValidPrice(int price)
        {
            bool priceValidation = false;
            if (price > 0)
            {
                priceValidation = true;
            }
            return priceValidation;
        }
    }
}
