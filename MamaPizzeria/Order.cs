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

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
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

        public Order(int orderID, Pizza orderPizza, Customer orderCustumer, DateTime dateTime)
        {
            _orderID = orderID;
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
