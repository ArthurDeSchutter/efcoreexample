using efcoreexample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace efcoreexample.Controllers
{
    public class OrderController : Controller
    {
        private readonly MyWebShopContext dbContext;
        public OrderController()
        {
            dbContext = new MyWebShopContext();
        }

        // GET: OrderController
        public List<Order> Index()
        {
            return dbContext.Orders.ToList();
        }

        // GET: OrderController/Details/5
        public Order Details(int id)
        {
            return dbContext.Orders.Where(x => x.Id == id).SingleOrDefault();
        }


        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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
