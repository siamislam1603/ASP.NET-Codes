using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels.Dtos;
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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        //GET /api/Customer/1
        public CustomerDto GetCustomer(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Customer, CustomerDto>(customer);
        }
        //POST /api/customers
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            context.Customers.Add(customer);
            context.SaveChanges();
            customerDto.id = customer.id;
            return customerDto;
        }
        //PUT /api/customer/1
        [HttpPut]
        public void UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDb = context.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(customerDto, customerInDb);
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
