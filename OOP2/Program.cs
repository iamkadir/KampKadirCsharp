using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.TcNo = "27493064090";
            customer1.Name = "Kadir";
            customer1.FirstName = "Kaya";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.ıo";
            customer2.TaxNo = "9876543210";


            Customer customer3 = new IndividualCustomer();      // Burda dikkat edersek müsteri gercek müsteriyi de tutabiliyor tüzel müşteriyi de tutabiliyor
            Customer customer4 = new CoorporateCustomer();      // Yani müsteri classı hem gercek müsterinin referansını tutabiliyor hem de tüzel müşterinin

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(customer1);
            customerManeger.Add(customer2);
            customerManeger.Add(customer3);
            customerManeger.Add(customer4);


                
                 

        }
    }
}
