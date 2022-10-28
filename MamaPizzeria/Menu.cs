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
            Console.WriteLine("\t1.\tAdd a pizza to MenuCatalog");
            Console.WriteLine("\t2.\tRemove a pizza from MenuCatalog");
            Console.WriteLine("\t3.\tUpdate a pizza in MenuCatalog");
            Console.WriteLine("\t4.\tUse PizzaNumber to search for a pizza");
            Console.WriteLine("\t5.\tSee all pizzas in PizzaCatalog");
            Console.WriteLine("\t-----------------------------------");
            Console.WriteLine("\t6.\tAdd customer to CustomerList");
            Console.WriteLine("\t7.\tRemove customer from CustomerList");
            Console.WriteLine("\t8.\tUpdate customer in CustomerList");
            Console.WriteLine("\t9.\tUse Customer name to search for a customer");
            Console.WriteLine("\t10.\tSee all customers in CustomerList");
            Console.WriteLine("\tPress 0 to end.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\tType the number of the command you want to execute and hit enter to confirm:");
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
                        Console.WriteLine("Something went wrong, please try again.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                input = ShowMenu();
            }
        }

        private void AddPizzaToMenu()
        {
            Console.WriteLine("-----------Add a pizza to the menu-----------");
            Console.WriteLine("Add pizza number:");
            int PizzaNumber = int.Parse(Console.ReadLine());

            Pizza pizza = _menu.MenuSearch(PizzaNumber);

            if (pizza == null)
            {
                Console.WriteLine("Add pizza name:");
                string PizzaName = Console.ReadLine();
                Console.WriteLine("Add toppings:");
                string PizzaToppings = Console.ReadLine();
                Console.WriteLine("Add price:");
                double PizzaPrice = double.Parse(Console.ReadLine());
                Pizza newPizza = new Pizza(PizzaNumber, PizzaName, PizzaToppings, PizzaPrice);
                _menu.AddPizza(newPizza);

                Console.WriteLine("The pizza has been successfully added. Hit enter to return to the menu.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It seems this pizza already exists. Try another pizza number or edit a pizza instead. Hit enter to return to the menu.");
            }

        }

        private void DeletePizzaFromMenu()
        {
            Console.WriteLine("----------Delete pizza from menu-----------");
            Console.WriteLine("Pizza number to be deleted:");
            int PizzaNumber = int.Parse(Console.ReadLine());

            Pizza pizza = _menu.MenuSearch(PizzaNumber);

            if (pizza != null)
            {
                _menu.DeletePizza(PizzaNumber);

                Console.WriteLine("The pizza has been deleted. Hit enter to return to menu.");
            }
            else
            {
                Console.WriteLine("This pizza could not be found. Try creating a pizza instead or try again. Hit enter to return to the menu.");
            }

        }

        private void UpdateMenuPizza()
        {
            Console.WriteLine("-----------Update a pizza-----------");
            Console.WriteLine("Pizza number to be updated:");
            int PizzaNumberOld = int.Parse(Console.ReadLine());
            Pizza pizza = _menu.MenuSearch(PizzaNumberOld);
            if (pizza == null)
            {
                Console.WriteLine("This pizza could not be found. Try creating a pizza instead or try again. Hit enter to return to the menu.");
            }
            else
            {
                Console.WriteLine("-----------Update pizza-----------");
                Console.WriteLine(pizza);
                Console.WriteLine("New pizza number:");
                int PizzaNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("New pizza name:");
                string PizzaName = Console.ReadLine();
                Console.WriteLine("New pizza topping(s):");
                string PizzaToppings = Console.ReadLine();
                Console.WriteLine("New pizza price:");
                double PizzaPrice = double.Parse(Console.ReadLine());
                Pizza updatedPizza = new Pizza(PizzaNumber, PizzaName, PizzaToppings, PizzaPrice);
                _menu.UpdatePizza(PizzaNumberOld, updatedPizza);
                Console.WriteLine("The pizza has been updated. Hit enter to return to the menu.");

            }
        }

        private void SearchMenu()
        {
            Console.WriteLine("-----------Look up pizza-----------");
            Console.WriteLine("Pizza number:");
            int PizzaNumber = int.Parse(Console.ReadLine());
            Pizza pizza = _menu.MenuSearch(PizzaNumber);
            if (pizza == null)
            {
                Console.WriteLine("This pizza doesn't exist. Try creating a pizza instead or try again. Hit enter to return to the menu.");
            }
            else
            {
                Console.WriteLine(pizza);
                Console.WriteLine("Hit enter to return to the menu.");

            }
        }

        private void AddCustomerToMenu()
        {
            Console.WriteLine("----------Add customer----------");
            Console.WriteLine("Add customer name:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Add phone number:");
            string CustomerPhone = Console.ReadLine();
            Customer testPhone = _customerList.PhoneCheck(CustomerPhone);
            if (testPhone != null)
            {
                Console.WriteLine("This customer phone number already exists. Try editing a customer instead or try again. Hit enter to return to menu.");
            }
            else
            {
                Console.WriteLine("Add email:");
                string CustomerEmail = Console.ReadLine();
                Customer testEmail = _customerList.EmailCheck(CustomerEmail);

                if (testEmail != null)
                {
                    Console.WriteLine("This customer email already exists. Try editing a customer instead or try again. Hit enter to return to menu.");
                }
                else
                {
                    Console.WriteLine("Add address:");
                    string CustomerAddress = Console.ReadLine();

                    Customer customer = new Customer(CustomerName, CustomerPhone, CustomerEmail, CustomerAddress);
                    _customerList.AddCustomer(customer);
                    Console.WriteLine("The customer has been added. Hit enter to return to the menu.");

                }
            }
        }

        private void DeleteCustomerFromMenu()
        {
            Console.WriteLine("----------Remove customer----------");
            Console.WriteLine("Customer name:");
            string CustomerName = Console.ReadLine();
            Customer customerDeleted = _customerList.CustomerSearch(CustomerName);
            if (customerDeleted != null)
            {
                _customerList.DeleteCustomer(CustomerName);
                Console.WriteLine("This customer has been deleted. Hit enter to return to menu.");

            }
            else
            {
                Console.WriteLine("This customer does not exist. Try adding a customer or try again. Hit enter to return to menu.");
            }

        }

        private void UpdateCustomer()
        {
            Console.WriteLine("----------Update customer----------");
            Console.WriteLine("Customer old name:");
            string OldCustomerName = Console.ReadLine();
            Customer OldCustomer = _customerList.CustomerSearch(OldCustomerName);

            if (OldCustomer == null)
            {
                Console.WriteLine("This customer does not exist. Try adding a customer or try again. Hit enter to return to menu.");
            }

            else
            {
                Console.WriteLine("----------Update customer----------");
                Console.WriteLine(OldCustomer);
                Console.WriteLine("New customer name:");
                string NewCustomerName = Console.ReadLine();
                Console.WriteLine("New customer phone:");
                string NewCustomerPhone = Console.ReadLine();
                Customer phoneTest = _customerList.PhoneCheck(NewCustomerPhone);
                if (phoneTest != null)
                {
                    Console.WriteLine("This phone is already linked to another customer and can't be used more than once. Hit enter to return to menu and try again.");
                }
                else
                {
                    Console.WriteLine("New customer email:");
                    string NewCustomerEmail = Console.ReadLine();
                    Customer emailTest = _customerList.EmailCheck(NewCustomerEmail);
                    if (emailTest != null)
                    {
                        Console.WriteLine("This email is already linked to a customer and can't be used more than once. Hit enter to return to menu and try again.");
                    }
                    else
                    {
                        Console.WriteLine("New customer address:");
                        string NewCustomerAddress = Console.ReadLine();

                        Customer updatedCustomer = new Customer(NewCustomerName, NewCustomerPhone, NewCustomerEmail, NewCustomerAddress);

                        _customerList.UpdateCustomer(OldCustomerName, updatedCustomer);
                        Console.WriteLine("The customer has been edited.");
                        Console.WriteLine("Old information:");
                        Console.WriteLine(OldCustomer);
                        Console.WriteLine("Updated information:");
                        Console.WriteLine(updatedCustomer);
                    }
                }


            }

        }

        private void SearchCustomerList()
        {
            Console.WriteLine("-----------Look up customer-----------");
            Console.WriteLine("Look up customer by name:");
            string CustomerName = Console.ReadLine();
            Customer customer = _customerList.CustomerSearch(CustomerName);
            if (customer == null)
            {
                Console.WriteLine("This customer does not exist. Try creating a customer or try again. Hit space to return to menu.");
            }
            else
            {
                Console.WriteLine("Result of your search:");
                Console.WriteLine(customer);
                Console.WriteLine("Hit enter to return to menu.");

            }
        }
    }
}
