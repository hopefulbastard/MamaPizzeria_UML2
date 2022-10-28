namespace MamaPizzeria
{

    public class Program
    {
        public static void Main(string[] arcs)
        {

            CustomerList customerList = new CustomerList();
            MenuCatalog menuCatalog = new MenuCatalog();
            Menu menu = new Menu(menuCatalog, customerList);

            Customer c1 = new Customer("Jens", "+4512345678", "hej@hej.hej", "Gade 1, 0001 Bynavn");
            Customer c2 = new Customer("Bent", "+4512345678", "hej@hej.hej", "Gade 1, 0001 Bynavn");
            Customer c3 = new Customer("Lars", "+4512345678", "hej@hej.hej", "Gade 1, 0001 Bynavn");

            //Console.WriteLine("Antal kunder før AddCustomer:");
            //Console.WriteLine(customerList.CustomerListCount);

            customerList.AddCustomer(c1);
            customerList.AddCustomer(c2);
            customerList.AddCustomer(c3);

            //Console.WriteLine("Antal kunder efter AddCustomer:");
            //Console.WriteLine(customerList.CustomerListCount);
            //Console.WriteLine("Oversigt over alle kunder i listen:");
            //customerList.PrintCustomerList();

            //Console.WriteLine("Test af CustomerSearch:");
            //Customer existingCustomer = customerList.CustomerSearch("Jens");
            //if (existingCustomer != null)
            //{
            //    Console.WriteLine(existingCustomer.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Kunde ikke fundet.");
            //}

            //Console.WriteLine("Antal kunder før DeleteCustomer:");
            //Console.WriteLine(customerList.CustomerListCount);

            //customerList.DeleteCustomer("Bent");
            //customerList.DeleteCustomer("Lars");

            //Console.WriteLine("Antal kunder efter DeleteCustomer:");
            //Console.WriteLine(customerList.CustomerListCount);

            //Console.WriteLine("Test af CustomerEdit. Kunde før CustomerEdit:");
            //customerList.PrintCustomerList();

            //Customer updatedCustomer = new Customer(6590, "Kirsten", "+4512345678", "hej@hej.hej", "Gade 100, 0001 Bynavn");
            //customerList.UpdateCustomer(6590, updatedCustomer);

            //Console.WriteLine("Kunde efter CustomerEdit:");
            //customerList.PrintCustomerList();



            //Console.WriteLine("Antal pizzaer før AddPizza:");
            //Console.WriteLine(menu.PizzaCount);

            Pizza p1 = new Pizza(1, "Margherita", "Tomato and cheese.", 69);
            Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese and ham", 75);
            Pizza p3 = new Pizza(3, "Cappricciosa", "Tomato, cheese, ham and mushrooms.", 80);

            menuCatalog.AddPizza(p1);
            menuCatalog.AddPizza(p2);
            menuCatalog.AddPizza(p3);

            //Console.WriteLine("Antal pizzaer efter AddPizza:");
            //Console.WriteLine(menu.PizzaCount);
            //Console.WriteLine("Oversigt over alle pizzaer på menuen:");
            //menu.PrintMenu();

            //Console.WriteLine("Test af MenuSearch:");
            //menu.MenuSearch(1);

            //Console.WriteLine("Antal pizzaer før DeletePizza:");
            //Console.WriteLine(menu.PizzaCount);

            //menu.DeletePizza(2);
            //menu.DeletePizza(3);

            //Console.WriteLine("Antal pizzaer efter DeletePizza:");
            //Console.WriteLine(menu.PizzaCount);

            //Console.WriteLine("Test af PizzaEdit. Pizza før PizzaEdit:");
            //menu.PrintMenu();

            //Pizza updatedPizza = new Pizza(1, "Romana", "Tomato, cheese, ham, bacon & onion.", 78);
            //menu.UpdatePizza(1, updatedPizza);

            //Console.WriteLine("Pizza efter PizzaEdit:");
            //menu.PrintMenu();

            //Order o1 = new Order(p1, c1, DateTime.Now);
            //Order o2 = new Order(p2, c2, DateTime.Now);
            //Order o3 = new Order(p3, c3, DateTime.Now);

            menu.Run();
        }
    }

}