using Microsoft.AspNetCore.Mvc;
using Hostitan.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hostitan.API.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        private static List<Customers> customer = new List<Customers>{
            new Customers("Azeem","Sarwar","RWP","azeem.sawar@gmail.com"),
            new Customers("Nadeem","Sarwar","RWP","nadeem.sawar@gmail.com"),
            new Customers("Naeem","Sarwar","RWP","naeem.sawar@gmail.com")
        };


        [HttpGet]
        public ActionResult<Customers> GetCustomers(){
            return Ok(customer);
        }        

        [HttpGet("{id}")]
        public ActionResult<Customers> GetCustomer(Guid id)
        {
            return Ok(customer.FirstOrDefault(c => c.id == id));
        }

        [HttpPost]
        public ActionResult<Customers> AddCustomer(Customers _newCustomer)
        {
            customer.Add(_newCustomer);

            return Ok(customer);
        }
    }
}