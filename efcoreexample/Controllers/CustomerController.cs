using efcoreexample.Models;
using Microsoft.AspNetCore.Mvc;


namespace efcoreexample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly MyWebShopContext dbContext;
        public CustomerController() {
            dbContext = new MyWebShopContext();
        }

        // GET: CustomerController
        [HttpGet]
        public IActionResult Index()
        {
            var result = dbContext.Customers.ToList();
            return Ok(result);
        }

        // GET: CustomerController/Details/5
        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var result =  dbContext.Customers.Where(x => x.Id == id).SingleOrDefault();
            return Ok(result);
        }

        // POST: CustomerController/Create
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            var newcustomer = new Customer();
            newcustomer.Name = customer.Name;
            newcustomer.Adress = customer.Adress;

            dbContext.Customers.Add(newcustomer);
            dbContext.SaveChanges();
            return Ok();

        }


    }
}
