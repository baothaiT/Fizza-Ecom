using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Thinh_Ecom.Controllers.ClientPage
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetailController
        [Route("/productdetail/{id:guid}")]
        [HttpGet]
        public ActionResult Index()

        {
            return View();
        }

        // GET: ProductDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductDetailController/Create
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

        // GET: ProductDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductDetailController/Edit/5
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

        // GET: ProductDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductDetailController/Delete/5
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
