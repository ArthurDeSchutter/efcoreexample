using efcoreexample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace efcoreexample.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class OrderController : Controller
    {
        private readonly MyWebShopContext dbContext;
        public OrderController()
        {
            dbContext = new MyWebShopContext();
        }

        // GET: OrderController
        [HttpGet]
        public List<Order> Index()
        {
            return dbContext.Orders.ToList();
        }

        // GET: OrderController/Details/5
        [HttpGet("Details")]
        public Order Details(int id)
        {
            return dbContext.Orders.Where(x => x.Id == id).SingleOrDefault();
        }


        // POST: OrderController/Create
        [HttpPost]
        public HttpStatusCode Create(Order order)
        {
            var neworder =  new Order();
            neworder.CustomerId = order.CustomerId;
            neworder.Created = DateTime.Now;
            neworder.ItemId = order.ItemId;

            dbContext.SaveChanges();
            return HttpStatusCode.Created;
        }
    }
}
