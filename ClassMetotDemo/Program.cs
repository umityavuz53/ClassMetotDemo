using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Musteri()
            {
                ID = 53,
                Name = "Umit",
                SurName = "Yavuz"
            };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.ListCustomer(customer);
            musteriManager.AddCustomer(customer);
            musteriManager.RemoveCustomer(customer);

            Console.ReadLine();
        }
    }
}
