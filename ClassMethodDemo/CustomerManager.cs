using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added :  {0} {1}", customer.FirstName, customer.LastName);
        }
        
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated :  {0} {1}", customer.FirstName, customer.LastName);
        }
        
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted :  {0} {1}", customer.FirstName, customer.LastName);
        }
    }
}
