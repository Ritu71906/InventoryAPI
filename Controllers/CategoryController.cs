using InventoryAPI.Data;
using InventoryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/category
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return _context.Categories.ToList();
        }

        // POST: api/category
        [HttpPost]
        public ActionResult<Category> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
        }
    }
}
