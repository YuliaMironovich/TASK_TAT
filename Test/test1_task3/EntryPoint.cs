using System;
using System.Collections.Generic;

namespace test1_task3
{
    /// <summary>
    /// Main class of the program which sortes automobile list.
    /// Count and data of automobiles is entered by keyboard.
    /// After input data of automobile is checked for the validity and then 
    /// if all data is valid, the list of automobiles is sorted by price, type and brand.
    /// </summary>
    class EntryPoint
    {
        public const string COUNT = "input the count of automobile for sorting:";
        public const string BRAND = "input the brand:";
        public const string MODEL = "input the model:";
        public const string TYPE = "input the type (sedan, estate, SUV):";
        public const string PRICE = "input the price:";
        public const string MESSAGE = "Your price and type are not correct. Enter other values.";
        public const string ERROR = "/nCheck your input data.";
        /// <summary>
        /// This method is the input point of the automobile sorted program.
        /// </summary>
        static void Main()
        {
            List<Automobile> listOfAutomobile = new List<Automobile>();
            bool continueProgram = true;
            string brand, model, type;
            int price;
            while(continueProgram)
            {
                try
                {
                    ValidatorOfAutomobileParameters validatorOfParameters = new ValidatorOfAutomobileParameters();
                    Console.WriteLine(COUNT);
                    int countOfAutomobiles = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < countOfAutomobiles; i++)
                    {
                        Console.WriteLine(BRAND);
                        brand = Console.ReadLine();
                        Console.WriteLine(MODEL);
                        model = Console.ReadLine();
                        Console.WriteLine(TYPE);
                        type = Console.ReadLine();
                        Console.WriteLine(PRICE);
                        price = Int32.Parse(Console.ReadLine());
                        if (validatorOfParameters.IsValid(type, price))
                        {
                            Automobile automobile = new Automobile(brand, model, type, price);
                            listOfAutomobile.Add(automobile);
                        }
                        else
                        {
                            Console.WriteLine(MESSAGE);
                            continue;
                        }
                    }
                    listOfAutomobile.Sort(new AutomobileSorter());
                    foreach (Automobile automobile in listOfAutomobile)
                    {
                        Console.WriteLine(automobile.ToString());
                    }
                    continueProgram = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + ERROR);
                    continue;
                }
            }
        }
    }
}
