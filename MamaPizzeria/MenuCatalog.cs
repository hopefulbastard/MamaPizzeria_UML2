using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    internal class MenuCatalog
    {

        public Dictionary<int, Pizza> _menu;

        public MenuCatalog()
        {
            _menu = new Dictionary<int, Pizza>();
        }

        public int PizzaCount
        {
            get { return _menu.Count; }
        }

        public void PrintMenu()
        {
            foreach (Pizza item in _menu.Values)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public Pizza MenuSearch(int PizzaNumber)
        {
            if (_menu.ContainsKey(PizzaNumber))
                return _menu[PizzaNumber];

            return null;
        }

        public void AddPizza(Pizza aPizza)
        {
            if (!_menu.ContainsKey(aPizza.PizzaNumber))
                _menu.Add(aPizza.PizzaNumber, aPizza);
        }

        public void DeletePizza(int PizzaNumber)
        {
            if (_menu.ContainsKey(PizzaNumber))
                _menu.Remove(PizzaNumber);
        }

        internal void UpdatePizza(int PizzaNumber, Pizza pizzaToUpdate)
        {
            if (_menu.ContainsKey(PizzaNumber))
                _menu[PizzaNumber] = pizzaToUpdate;

        }
    }
}
