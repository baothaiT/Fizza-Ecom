using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Thinh_Ecom.Data;
using System.Linq;
using Thinh_Ecom.Models;

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
            // Get Data Of User
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            // Query Data Bill and User Table

            var queryBill = from a in _context.Bills
                            join b in _context.Users on a.bill_UserId equals b.Id
                            select new { a, b };

            // // Start Proccess Product Name


            // // End Proccess Product Name

            var DataForHistoryModel = queryBill.Select(x => new PaymentManagement()
            {
                PaymentId = x.a.bill_Id,
                Date = x.a.bill_DatetimeOrder,
                Status_Confirm = x.a.bill_Confirmation,
                Name_Product = "Product Name",
                Type_Payment = x.a.bill_PaymentMethod,
                UserName = x.b.UserName,
                Check_Receive = true,
                Price = x.a.bill_PaidTotal

            });
            return View(DataForHistoryModel);
        }

        // GET: PaymentManagementController/Details/5
        [Route("paymentconfirm")]
        [HttpGet("{id}")]
        public ActionResult Confirmed(string id)
        {

            var queryPayment = _context.Bills.FirstOrDefault(a => a.bill_Id == id);
            queryPayment.bill_Confirmation = true;

            _context.Bills.Update(queryPayment);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
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
