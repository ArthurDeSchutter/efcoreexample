using Microsoft.AspNetCore.Mvc;

namespace efcoreexample.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        //try to make this controller

        // GET: ProductController
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        // GET: ProductController/Details/5
        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            return Ok();
        }

        // GET: ProductController/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return Ok();
        }

        // POST: ProductController/Create
        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: ProductController/Edit/5
        [HttpGet("Edit")]
        public IActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: ProductController/Edit/5
        [HttpPost("Edit")]

        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: ProductController/Delete/5
        [HttpGet("Delete")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
