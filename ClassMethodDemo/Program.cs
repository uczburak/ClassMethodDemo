using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                FirstName = "Burak",
                LastName = "UCUZ",
                Id = 11,
                CityOfBirth = "Mardin",
                DateOfBirth = Convert.ToDateTime("03.06.1995"),
                PhoneNumber = "905438860047",
                NationalityId = "324546345678"
            };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer);
        }
    }
}
