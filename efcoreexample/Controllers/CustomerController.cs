using efcoreexample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace efcoreexample.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MyWebShopContext dbContext;
        public CustomerController() {
            dbContext = new MyWebShopContext();
        }

        // GET: CustomerController
        public List<Customer> Index()
        {
            return dbContext.Customers.ToList();
        }

        // GET: CustomerController/Details/5
        public Customer Details(int id)
        {
            return dbContext.Customers.Where(x => x.Id == id).SingleOrDefault();
        }

        // GET: CustomerController/Create

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public HttpStatusCode Create(Customer customer)
        {
            var newcustomer = new Customer();
            newcustomer.Name = customer.Name;
            newcustomer.Adress = customer.Adress;

            dbContext.Customers.Add(newcustomer);
            dbContext.SaveChanges();
            return HttpStatusCode.Created;

        }

    }
}
