using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels.Dtos;
using System.Data.Entity;
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
        public IHttpActionResult GetCustomers()
        {
            var customerDto= context.Customers
                .Include(c=>c.membershipType)
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>);
            return Ok(customerDto);
        }

        //GET /api/Customer/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }
        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            context.Customers.Add(customer);
            context.SaveChanges();
            customerDto.id = customer.id;
            return Created(new Uri(Request.RequestUri+"/"+customer.id),customerDto);
        }
        //PUT /api/customer/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customerInDb = context.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDb == null)
                return NotFound();
            Mapper.Map(customerDto, customerInDb);
            context.SaveChanges();
            return Ok();
        }
        //DELETE /api/customer/1
        [HttpDelete]
        public IHttpActionResult deleteCustomer(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                return NotFound();
            context.Customers.Remove(customer);
            context.SaveChanges();
            return Ok();
        }
    }
}
