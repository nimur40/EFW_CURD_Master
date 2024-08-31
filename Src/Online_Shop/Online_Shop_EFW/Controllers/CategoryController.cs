﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
