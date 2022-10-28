using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    public class Pizza
    {
        private int _pizzaNumber;
        private string _pizzaName;
        private string _pizzaToppings;
        private double _pizzaPrice;


        public int PizzaNumber
        {
            get { return _pizzaNumber; }
        }

        public string PizzaName
        {
            get { return _pizzaName; }
        }

        public string PizzaToppings
        {
            get { return _pizzaToppings; }
        }

        public double PizzaPrice
        {
            get { return _pizzaPrice; }
        }

        public Pizza(int pizzaNumber, string pizzaName, string pizzaToppings, double pizzaPrice)
        {
            _pizzaNumber = pizzaNumber;
            _pizzaName = pizzaName;
            _pizzaToppings = pizzaToppings;
            _pizzaPrice = pizzaPrice;
        }

        public override string ToString()
            {
            return $"Number: {PizzaNumber}\nName: {PizzaName}\nPizza toppings: {PizzaToppings}\nPizza price: {PizzaPrice}";
            }
    }
}
