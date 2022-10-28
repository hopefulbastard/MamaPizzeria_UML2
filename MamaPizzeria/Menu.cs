using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    internal class Menu
    {
        private MenuCatalog _menu;
        private CustomerList _customerList;

        public Menu(MenuCatalog menu, CustomerList customerList)
        {
            _menu = menu;
            _customerList = customerList;

        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------Big Mama Pizzeria-------------------");
            Console.WriteLine("\t1.\tTilføj pizza til MenuCatalog");
            Console.WriteLine("\t2.\tFjern pizza fra MenuCatalog");
            Console.WriteLine("\t3.\tOpdater pizza i MenuCatalog");
            Console.WriteLine("\t4.\tSøg efter en pizza i MenuCatalog ud fra PizzaNumber");
            Console.WriteLine("\t5.\tUdskriv alle pizzaer fra MenuCatalog");
            Console.WriteLine("\t-----------------------------------");
            Console.WriteLine("\t6.\tTilføj kunde til CustomerList");
            Console.WriteLine("\t7.\tFjern kunde fra CustomerList");
            Console.WriteLine("\t8.\tOpdater kunde i CustomerList");
            Console.WriteLine("\t9.\tSøg efter en kunde i CustomerList ud fra ID");
            Console.WriteLine("\t10.\tUdskriv alle kunder fra CustomerList");
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\tIndtast dit valg og tryk derefter enter for at bekræfte:");
            return ReadUserChoice();

        }

        public void Run()
        {
            int input = ShowMenu();
            while (input != 0)
            {
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        AddPizzaToMenu();
                        break;
                    case 2:
                        Console.Clear();
                        DeletePizzaFromMenu();
                        break;

                    case 3:
                        Console.Clear();
                        UpdateMenuPizza();
                        break;
                    case 4:
                        Console.Clear();
                        SearchMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Menu:");
                        _menu.PrintMenu();
                        break;
                    case 6:
                        Console.Clear();
                        AddCustomerToMenu();
                        break;
                    case 7:
                        Console.Clear();
                        DeleteCustomerFromMenu();
                        break;
                    case 8:
                        Console.Clear();
                        UpdateCustomer();
                        break;
                    case 9:
                        Console.Clear();
                        SearchCustomerList();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Customer list:");
                        _customerList.PrintCustomerList();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Der opstod en fejl.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                input = ShowMenu();
            }
        }

        private void AddPizzaToMenu()
        {
            Console.WriteLine("-----------Tilføj pizza til menuen-----------");
            Console.WriteLine("Angiv pizzanummer:");
            int PizzaNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv pizzanavn:");
            string PizzaName = Console.ReadLine();
            Console.WriteLine("Angiv pizza toppings:");
            string PizzaToppings = Console.ReadLine();
            Console.WriteLine("Angiv pizza pris:");
            double PizzaPrice = double.Parse(Console.ReadLine());
            Pizza newPizza = new Pizza(PizzaNumber, PizzaName, PizzaToppings, PizzaPrice);
            _menu.AddPizza(newPizza);

            Console.WriteLine("Pizzaen er tilføjet. Tryk enter for at gå tilbage til start.");
            Console.ReadLine();
        }

        private void DeletePizzaFromMenu()
        {
            Console.WriteLine("----------Slet pizza fra menuen-----------");
            Console.WriteLine("Angiv pizzanummer:");
            int PizzaNumber = int.Parse(Console.ReadLine());
            _menu.DeletePizza(PizzaNumber);

            Console.WriteLine("Pizzaen er slettet. Tryk enter for at gå tilbage til start.");
            Console.ReadLine();
        }

        private void UpdateMenuPizza()
        {
            Console.WriteLine("-----------Opdater pizza-----------");
            Console.WriteLine("Angiv pizzanummer:");
            int PizzaNumberOld = int.Parse(Console.ReadLine());
            Pizza pizza = _menu.MenuSearch(PizzaNumberOld);
            if (pizza == null)
            {
                Console.WriteLine("Denne pizza eksisterer ikke. Tryk enter for at gå tilbage til start.");
            }
            else
            {
                Console.WriteLine("-----------Opdater pizza-----------");
                Console.WriteLine("Nyt pizza nummer:");
                int PizzaNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Nyt pizza navn:");
                string PizzaName = Console.ReadLine();
                Console.WriteLine("Ny(e) pizza topping(s):");
                string PizzaToppings = Console.ReadLine();
                Console.WriteLine("Ny pizza pris:");
                double PizzaPrice = double.Parse(Console.ReadLine());
                Pizza updatedPizza = new Pizza(PizzaNumber, PizzaName, PizzaToppings, PizzaPrice);
                _menu.UpdatePizza(PizzaNumberOld, updatedPizza);
                Console.WriteLine("Pizzaen er opdateret. Tryk enter for at gå tilbage til start.");
                Console.ReadLine();

            }
        }

        private void SearchMenu()
        {
            Console.WriteLine("-----------Søg efter pizza-----------");
            Console.WriteLine("Angiv pizzanummer:");
            int PizzaNumber = int.Parse(Console.ReadLine());
            Pizza pizza = _menu.MenuSearch(PizzaNumber);
            if (pizza == null)
            {
                Console.WriteLine("Denne pizza eksisterer ikke. Tryk enter for at gå tilbage til start.");
            }
            else
            {
                Console.WriteLine(pizza);
                Console.WriteLine("Tryk enter for at gå tilbage til start.");

            }
        }

        private void AddCustomerToMenu()
        {
            Console.WriteLine("----------Tilføj kunde----------");
            Console.WriteLine("Angiv kundenavn:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Angiv telefonnummer:");
            string CustomerPhone = Console.ReadLine();
            Console.WriteLine("Angiv email:");
            string CustomerEmail = Console.ReadLine();
            Console.WriteLine("Angiv adresse:");
            string CustomerAddress = Console.ReadLine();

            Customer customer = new Customer(CustomerName, CustomerPhone, CustomerEmail, CustomerAddress);
            _customerList.AddCustomer(customer);
            Console.WriteLine("Kunden er tilføjet. Tryk enter for at gå tilbage til start.");
            Console.ReadLine();
        }

        private void DeleteCustomerFromMenu()
        {
            Console.WriteLine("----------Slet kunde----------");
            Console.WriteLine("Angiv kunde navn:");
            string CustomerName = Console.ReadLine();
            _customerList.DeleteCustomer(CustomerName);
            Console.WriteLine("Kunden er slettet. Tryk enter for at gå tilbage til start.");
        }

        private void UpdateCustomer()
        {
            Console.WriteLine("----------Opdater kunde----------");
            Console.WriteLine("Angiv kunde navn:");
            string CustomerName = Console.ReadLine();
            Customer customer = _customerList.CustomerSearch(CustomerName);

            if (customer == null)
            {
                Console.WriteLine("Denne kunde eksisterer ikke. Tryk enter for at gå tilbage til start.");
            }

            else
            {
                Console.WriteLine("----------Opdater kunde----------");
                Console.WriteLine(customer);
                Console.WriteLine("Nyt kunde navn:");

            }

        }

        private void SearchCustomerList()
        {
            Console.WriteLine("-----------Søg efter kunde-----------");
            Console.WriteLine("Angiv kunde navn:");
            string CustomerName = Console.ReadLine();
            Customer customer = _customerList.CustomerSearch(CustomerName);
            if (customer == null)
            {
                Console.WriteLine("Denne kunde eksisterer ikke. Tryk enter for at gå tilbage til start.");
            }
            else
            {
                Console.WriteLine(customer);
                Console.WriteLine("Tryk enter for at gå tilbage til start.");

            }
        }
    }
}
