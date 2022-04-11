using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Thinh_Ecom.Controllers.AdminPage.Staff
{
    [Authorize(Roles = "admin,staff")]
    public class CategoriesManagementController : Controller
    {
        // GET: CategoriesManagementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoriesManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesManagementController/Create
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

        // GET: CategoriesManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesManagementController/Edit/5
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

        // GET: CategoriesManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesManagementController/Delete/5
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
