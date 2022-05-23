using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using xnes_hw.DAL;
using xnes_hw.Models;

namespace xnes_hw.Controllers.Api
{
    public class CustomersController : ApiController
    {      
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return CustomerHelper.GetCustomers();
        }

        [HttpGet]
        public IEnumerable<City> GetCities()
        {
            return CustomerHelper.GetCities();
        }

        // POST: api/Customers
        [HttpPost]
        public bool AddCustomer(Customer newCustomer)
        {
            return CustomerHelper.AddCustomers(newCustomer);
        }

       
       
    }
}
