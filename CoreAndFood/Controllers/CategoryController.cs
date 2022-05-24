using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();

        CategoryRepository categoryRepository = new CategoryRepository();
        //[Authorize]
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(x => x.CategoryName == p));
            }
            return View(categoryRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category ctg)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("CategoryAdd");
            //}
            categoryRepository.TAdd(ctg);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryGet(int id)
        {
            var x=categoryRepository.TGet(id);
            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryID = x.CategoryID,
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x=categoryRepository.TGet(p.CategoryID);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            //x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryDelete(int id)
        {
            //var x = categoryRepository.TGet(id);
            //x.Status=false;
            //categoryRepository.TUpdate(x);
            categoryRepository.TDelete(new Category { CategoryID = id });
            return RedirectToAction("Index");
        }
        public IActionResult CategoryDetail(int id)
        {
            var value=c.Foods.Where(c => c.CategoryID == id).ToList();
            var value2 = c.Categories.Where(x => x.CategoryID == id).
                Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.category = value2;
            ViewBag.value = value;
            return View(value);
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
