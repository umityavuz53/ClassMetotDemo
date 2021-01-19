using System;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        /// <summary>
        /// Add New customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Musteri customer)
        {
            Console.WriteLine(string.Format("Added new Customer: {0} {1}", customer.Name, customer.SurName));
        }

        /// <summary>
        /// Delete to Customer
        /// </summary>
        /// <param name="customer"></param>
        public void RemoveCustomer(Musteri customer)
        {
            Console.WriteLine(string.Format("Removed Customer: {0} {1}", customer.Name, customer.SurName));
        }

        /// <summary>
        /// List Customer
        /// </summary>
        /// <param name="customer"></param>
        public void ListCustomer(Musteri customer)
        {
            Console.WriteLine(string.Format("The CustomerList: {0} {1}", customer.Name, customer.SurName));
        }
    }
}
