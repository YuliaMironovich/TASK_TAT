using System.Text;

namespace test1_task3
{
    /// <summary>
    /// Class contains information about automobile:
    /// brand, model, type(sedan, estate,SUV), price.
    /// </summary>
    public class Automobile
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public Automobile(string brand, string model, string type, int price)
        {
            Brand = brand;
            Model = model;
            Type = type;
            Price = price;
        }

        /// <summary>
        /// Override method ToString.
        /// </summary>
        /// <returns>Information about automobile.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Brand + " ");
            stringBuilder.Append(Model + " ");
            stringBuilder.Append(Type + " ");
            stringBuilder.Append(Price);
            return stringBuilder.ToString();
        }
    }
}
