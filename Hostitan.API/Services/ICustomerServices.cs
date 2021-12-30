using Hostitan.API.Models;

namespace Hostitan.API.Services
{
    public interface ICustomerServices
    {
        public List<Customers> GetAllCustomers();
        public Customers GetCustomerById(Guid id);
        public List<Customers> AddCustomer(Customers _newCustomer);
    }
}