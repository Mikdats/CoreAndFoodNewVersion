using CoreAndFood.Data.Models;
using CoreAndFood.Data.Models.Dto;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context c = new Context();
        public IActionResult Index(int page=1 )
        {
            
            //return View(foodRepository.TList());
            var result = (from p in c.Foods
                          join d in c.Categories
                          on p.CategoryID equals d.CategoryID
                          select new FoodIViewDto
                          {
                              FoodID = p.FoodID,
                              Name = p.Name,
                              Description = p.Description,
                              Price = p.Price,
                              ImageURL = p.ImageURL,
                              Stock = p.Stock,
                              CategoryNameView = d.CategoryName
                          }).ToList();
            return View(result.ToPagedList(page,5));
        }
        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> CategoryList=(from x in c.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                 Text=x.CategoryName,
                                                 Value=x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cl = CategoryList;
            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult FoodDelete(int id)
        {
            foodRepository.TDelete(new Food { FoodID=id});
            return RedirectToAction("Index");
        }
        public IActionResult FoodGet(int id)
        {
            var x=foodRepository.TGet(id);
            List<SelectListItem> CategoryList = (from y in c.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = y.CategoryName,
                                                     Value = y.CategoryID.ToString()
                                                 }).ToList();
            ViewBag.cl = CategoryList;
            Food p = new Food()
            {
                FoodID=x.FoodID,
                CategoryID = x.CategoryID,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                Description = x.Description,
                ImageURL=x.ImageURL
            };
            return View(p);
        }
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.TGet(p.FoodID);
            x.Name = p.Name;
            x.Price = p.Price;
            x.Stock = p.Stock;
            x.Description = p.Description;
            x.ImageURL = p.ImageURL;
            x.CategoryID = p.CategoryID;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
       

    }
}
