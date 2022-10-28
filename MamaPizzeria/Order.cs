using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    internal class Order
    {

        private int _orderID;
        private Pizza _orderPizza;
        private Customer _orderCustomer;
        private DateTime _dateTime;
        private double _price;

        public int OrderID()
        {
            Random orderIDRandom = new Random();
            int orderID = orderIDRandom.Next(100, 1001);
            return orderID;
        }

        public Pizza OrderPizza
        {
            get { return _orderPizza; }
            set { _orderPizza = value; }
        }

        public Customer OrderCustomer
        {
            get { return _orderCustomer; }
            set
            {
                _orderCustomer = value;
            }
        }

        DateTime DateTime = DateTime.Now;

        public double Price
        {
            get { return _price; }
        }

        public Order(Pizza orderPizza, Customer orderCustumer, DateTime dateTime)
        {
            _orderID = OrderID();
            _orderPizza = orderPizza;
            _orderCustomer = orderCustumer;
            _dateTime = dateTime;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}\n \nPizza:\n{OrderPizza}\n\nCUstumer:\n{OrderCustomer}\nDate and time: {DateTime}\nPrice: {OrderPizza.PizzaPrice}";
        }

    }

}
