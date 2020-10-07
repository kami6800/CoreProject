using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        NorthwindContext context = new NorthwindContext();

        //[Route("api/{controller=invoice}/incomplete/{id}")]
        //[HttpGet("{id}")]
        //public string GetIncompletedOrders(string id)
        //{
        //    //return context.Orders.Where(order => order.CustomerId == id).Where(order => order.ShippedDate != null).ToList();
        //    return "hi";
        //}

        //[Route("api/[controller]/incomplete/")]
        //[HttpGet]
        //public List<Orders> GetIncompletedOrders()
        //{
        //    return context.Orders.ToList();
        //}

        [Route("api/[controller]/incomplete/")]
        [HttpGet]
        public string GetIncompletedOrders()
        {
            return "context.orders.tolist();";
        }

        // GET: api/Invoice
        [HttpGet]
        public List<Invoices> Get()
        {
            return context.Invoices.ToList();
        }

        // GET: api/Invoice/5
        [HttpGet("{id}", Name = "Get")]
        public List<Invoices> Get(string id)
        {
            return context.Invoices.Where(invoice => invoice.CustomerId == id).ToList();
        }

        // POST: api/Invoice
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Invoice/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
