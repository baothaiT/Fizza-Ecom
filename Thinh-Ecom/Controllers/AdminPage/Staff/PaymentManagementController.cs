using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;

namespace Thinh_Ecom.Controllers.AdminPage.Staff
{
    public class PaymentManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PaymentManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HistoryOfPaymentController
        [Route("paymentmanagement")]
        public ActionResult Index()
        {
            return View();
        }


        // GET: PaymentManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaymentManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentManagementController/Create
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

        // GET: PaymentManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaymentManagementController/Edit/5
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

        // GET: PaymentManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaymentManagementController/Delete/5
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
