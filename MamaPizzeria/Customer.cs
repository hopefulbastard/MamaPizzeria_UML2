using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    public class Customer
    {
        private int _customerID;
        private string _customerName;
        private string _customerPhone;
        private string _customerEmail;
        private string _customerAddress;

        public int CustomerID()
        {
            Random customerIDRandom = new Random();
            int customerID = customerIDRandom.Next(100, 1001);
            return customerID;
        }

        public string CustomerName
        {
            get { return _customerName; }
        }

        public string CustomerPhone
        {
            get { return _customerPhone; }
        }

        public string CustomerEmail
        {
            get { return _customerEmail; }
        }

        public string CustomerAddress
        {
            get { return _customerAddress; }
        }

        public Customer(string customerName, string customerPhone, string customerEmail, string customerAddress)
        {
            _customerID = CustomerID();
            _customerName = customerName;
            _customerPhone = customerPhone;
            _customerEmail = customerEmail;
            _customerAddress = customerAddress;
        }

        public override string ToString()
        {
            return $"Customer ID: {CustomerID()}\nName: {CustomerName}\nPhone: {CustomerPhone}\nEmail: {CustomerEmail}\nAddress: {CustomerAddress}";
        }
    }
}
