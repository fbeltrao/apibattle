
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerAPI.Data;
using CustomerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository repository;
        

        public CustomerController(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        // Gets the list of customers
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var list = new List<CustomerModel>();
            foreach (var dto in await this.repository.GetAll())
            {
                list.Add(new CustomerModel(dto));
            }
            
            return Ok(list);
        }



        // Creates a customer
        [HttpPost]
        public IActionResult Create([FromBody]CustomerModel customer)
        {
            if (customer == null)
                return this.BadRequest("Invalid customer");
    

            return Created($"/{customer.ID}", customer);

        }

        // Updates the customer
        [HttpPatch]
        public IActionResult Update(int customerID, [FromBody]CustomerModel customer)
        {

            return this.Ok(customer);

        }
    
        [HttpDelete]
        public IActionResult Delete(int customerID)
        {
            return Ok();
        }

        // Validates if the order can 
        public IActionResult ValidateOrder(int customerID, OrderProcessModel order)
        {

            return Ok();
        }

    }
}