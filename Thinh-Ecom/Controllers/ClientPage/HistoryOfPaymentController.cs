using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;

namespace Thinh_Ecom.Controllers.ClientPage
{
    public class HistoryOfPaymentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoryOfPaymentController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HistoryOfPaymentController
        [Route("paymenthistory")]
        public ActionResult Index()
        {
            // Active Color Payment
            ViewBag.ActiveClassPaymentHistory = "current-list-item";
            return View();
        }

        // GET: HistoryOfPaymentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoryOfPaymentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoryOfPaymentController/Create
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

        // GET: HistoryOfPaymentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoryOfPaymentController/Edit/5
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

        // GET: HistoryOfPaymentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoryOfPaymentController/Delete/5
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
