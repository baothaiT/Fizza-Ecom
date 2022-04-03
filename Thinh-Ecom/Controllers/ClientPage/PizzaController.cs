using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;
using System.Linq;
using Thinh_Ecom.Models;
using Thinh_Ecom.Function;
using Microsoft.EntityFrameworkCore;

namespace Thinh_Ecom.Controllers.ClientPage
{
    public class PizzaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PizzaController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: PizzaController
        [Route("/pizza")]
        [HttpGet]
        public ActionResult Index(string sortOrder, string currentFilter, int? pageNumber)
        {
            //Query Food
            var queryFood = from a in _context.Products
                            join b in _context.Categories on a.CategoriesFK equals b.cg_Id
                            select new { a, b };

            // Insert data into model
            var FoodModelQuery = queryFood
                .Select(x => new FoodModels()
                {
                    Id = x.a.pd_Id,
                    Img = x.a.pd_Img1,
                    Name = x.a.pd_Name,
                    Price = x.a.pd_Price,
                    CategoriesName = x.b.cg_Name,
                    Discount = x.a.pd_ReducePrice
                });


            //Query Categories Name

            var queryCategories = _context.Categories;
            ViewBag.Categories = queryCategories;

            //Paging
            int pageSize = 8;
            return View(PaginatedList<FoodModels>.Create(FoodModelQuery.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
