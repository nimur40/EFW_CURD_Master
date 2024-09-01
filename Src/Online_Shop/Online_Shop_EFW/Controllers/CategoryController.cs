using Microsoft.AspNetCore.Mvc;
using Online_Shop_EFW.Data;
using Online_Shop_EFW.Models;

namespace Online_Shop_EFW.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            List<Category> objCategoryList=_db.Categories.ToList(); 
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(obj.Name==obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display cannot exactly math the name");
            }
            if (obj.Name.ToString()=="test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }
            if ( ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            
            return View(obj);
        }
    }
}
