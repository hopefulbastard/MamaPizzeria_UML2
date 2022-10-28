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


        internal Customer CustomerSearch(string customerName)
        {
            foreach (Customer item in _customerList)
            {
                if (customerName == item.CustomerName)
                    return item;
            }
            return null;
        }

        internal void AddCustomer(Customer aCustomer)
        {
            Customer existingCustomer = CustomerSearch(aCustomer.CustomerIDMethod().ToString());
            if (existingCustomer == null)
                _customerList.Add(aCustomer);
        }

        internal void DeleteCustomer(string customerName)
        {
            Customer item = CustomerSearch(customerName);
            _customerList.Remove(item);

        }
        internal void UpdateCustomer(int customerID, Customer UpdatedCustomer)
        {
            int d = 0;
            while (d < _customerList.Count)
            {
                if (_customerList[d].CustomerIDMethod() == customerID)
                {
                    _customerList[d] = UpdatedCustomer;
                    break;
                }
                d++;
            }

        }


    }
}
