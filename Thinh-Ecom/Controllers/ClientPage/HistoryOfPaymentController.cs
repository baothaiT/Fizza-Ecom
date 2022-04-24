using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;
using System.Linq;
using System.Security.Claims;
using Thinh_Ecom.Models;
using Microsoft.AspNetCore.Authorization;

namespace Thinh_Ecom.Controllers.ClientPage
{
    [Authorize]
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
            // Get Data Of User
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Active Color Payment
            ViewBag.ActiveClassPaymentHistory = "current-list-item";

            // Query Data Bill and User Table

            var queryBill = from a in _context.Bills
                            join b in _context.Users on a.bill_UserId equals b.Id
                            select new { a, b };

            queryBill = queryBill.Where(a => a.b.Id == userId);

            // // Start Proccess Product Name


            // // End Proccess Product Name

            var DataForHistoryModel = queryBill.Select(x => new HistoryPaymentModels()
            {
                PaymentId = x.a.bill_Id,
                Date = x.a.bill_DatetimeOrder,
                Status_Confirm = x.a.bill_Confirmation,
                Name_Product = "Product Name",
                Type_Payment = x.a.bill_PaymentMethod,
                Check_Receive = true,
                Price = x.a.bill_PaidTotal

            });

            return View(DataForHistoryModel);
        }

    }
}
