using Hostitan.API.Models;

namespace Hostitan.API.Services
{
    public class CustomerServices : ICustomerServices
    {
          private static List<Customers> customers = new List<Customers>{
            new Customers("Azeem","Sarwar","RWP","azeem.sawar@gmail.com"),
            new Customers("Nadeem","Sarwar","RWP","nadeem.sawar@gmail.com"),
            new Customers("Naeem","Sarwar","RWP","naeem.sawar@gmail.com")
        };

        public List<Customers> GetAllCustomers()
        {
            return customers;
        }

        public Customers GetCustomerById(Guid id)
        {
            return customers.FirstOrDefault(c=>c.id == id);
        }

        public List<Customers> AddCustomer(Customers _newCustomer)
        {
            customers.Add(_newCustomer);
            return customers;
        }
    }
}