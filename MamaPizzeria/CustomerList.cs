using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaPizzeria
{
    public class CustomerList
    {
        internal List<Customer> _customerList;

        public CustomerList()
        {
            _customerList = new List<Customer>();
        }

        public int CustomerListCount
        {
            get { return _customerList.Count; }
        }

        public void PrintCustomerList()
        {

            foreach (Customer item in _customerList)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }


        public Customer CustomerSearch(string customerName)
        {
            foreach (Customer item in _customerList)
            {
                if (customerName == item.CustomerName)
                    return item;
            }
            return null;
        }

        public Customer PhoneCheck(string customerPhone)
        {
            foreach (Customer item in _customerList)
            {
                if (customerPhone == item.CustomerPhone)
                    return item;
            }
            return null;
        }

        public Customer EmailCheck(string customerEmail)
        {
            foreach (Customer item in _customerList)
            {
                if (customerEmail == item.CustomerEmail)
                    return item;
            }
            return null;
        }

        public void AddCustomer(Customer aCustomer)
        {
            Customer existingCustomer = CustomerSearch(aCustomer.CustomerID().ToString());
            if (existingCustomer == null)
                _customerList.Add(aCustomer);
        }

        public void DeleteCustomer(string customerName)
        {
            Customer item = CustomerSearch(customerName);
            if (item != null) { _customerList.Remove(item); }
            else { return; }


        }
        public void UpdateCustomer(string OldCostumerName, Customer UpdatedCustomer)
        {
            int d = 0;
            while (d < _customerList.Count)
            {
                if (_customerList[d].CustomerName == OldCostumerName)
                {
                    _customerList[d] = UpdatedCustomer;
                    break;

                }

            }


        }
    }
}
