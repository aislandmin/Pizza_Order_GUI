using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaGUI
{
    public enum PizzaSize { Small, Medium, Large, X_large }

    internal class Pizza
    {
        static decimal COST_PER_TOPPING = 0.75m;
        /* alternative:
         * priceList.Add(PizzaSize.X_large, 14.99m);
         * priceList[PizzaSize.X_large] = 14.99m;
         */
        static Dictionary<PizzaSize, decimal> priceList = new Dictionary<PizzaSize, decimal>()
        {
            [PizzaSize.Small] = 9.99m,
            [PizzaSize.Medium] = 10.99m,
            [PizzaSize.Large] = 11.99m,
            [PizzaSize.X_large] = 12.99m
        };

        public decimal Price
        {
            get => priceList[Size] + (Toppings.Count - 1) * COST_PER_TOPPING;
        }
        public DayTime Time { get; set; }
        public PizzaSize Size { get; set; }
        public List<string> Toppings { get; set; }
        public Pizza(PizzaSize size, List<string> toppings)
        {
            Size = size;
            Toppings = new List<string>(toppings);
            Time = Utils.Now;
        }
        public Pizza(PizzaSize size)
        {
            Size = size;
            Toppings = new List<string> { "Cheese" };
            Time = Utils.Now;
        }

        public string[] CreateRow()
        {
            return new string[]
            {
                    Time.ToString(),
                    Price.ToString("C2"), // Format Price as Currency
                    Size.ToString(),
                    string.Join(",", Toppings) // Join Toppings as a comma-separated string
            };
        }
    }
}
