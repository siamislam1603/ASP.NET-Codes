using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels.Models;

namespace ViewModels.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private MyDBContext context;
        public CustomersController()
        {
            context = new MyDBContext();
        }
        //GET /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        //GET /api/Customer/1
        public Customer GetCustomer(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return customer;
        }
        //POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }
        //PUT /api/customer/1
        [HttpPut]
        public void UpdateCustomer(int id,Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDb = context.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            customerInDb.name = customer.name;
            customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            customerInDb.membershipTypeId = customer.membershipTypeId;
            customerInDb.birthdate = customer.birthdate;
            context.SaveChanges();
        }
        //DELETE /api/customer/1
        [HttpDelete]
        public void deleteCustomer(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
