using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Individual
            CustomerIndividual customerIndividual = new CustomerIndividual
            {
                CustomerNo = "12345",
                Name = "Tahir",
                Surname = "Esirgen",
                IdentificationNumber = "5135310",
                Id = 1
            };
            //Coorporate
            CustomerCoorporate customerCoorporate = new CustomerCoorporate
            {
                Id = 2,
                CustomerNo = "526512",
                CompanyName = "Deneme12",
                TaxNo = "651153"
            };

            //Customer classı hem customerIndividual hemde customerCoorporate referansını tutabilir. Aynızamanda Polymorphism
            Customer customer = new CustomerIndividual();
            Customer customer1 = new CustomerCoorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customerIndividual);
            customerManager.Add(customerCoorporate);
            customerManager.Add(customer);
            customerManager.Add(customer1);

        }
    }
}
