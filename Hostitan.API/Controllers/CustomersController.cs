using Microsoft.AspNetCore.Mvc;
using Hostitan.API.Models;
using Hostitan.API.Services;
using System.Collections.Generic;
using System.Linq;

namespace Hostitan.API.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        public ICustomerServices customerServices;

        public CustomersController(ICustomerServices _CustomerService)
        {
            customerServices = _CustomerService;
        }

        [HttpGet]
        public ActionResult<Customers> GetCustomers(){
            return Ok(customerServices.GetAllCustomers());
        }        

        [HttpGet("{id}")]
        public ActionResult<Customers> GetCustomer(Guid id)
        {
            return Ok(customerServices.GetCustomerById(id));
        }

        [HttpPost]
        public ActionResult<Customers> AddCustomer(Customers _newCustomer)
        {
            return Ok(customerServices.AddCustomer(_newCustomer));
        }
    }
}