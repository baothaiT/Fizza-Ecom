using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Thinh_Ecom.Entities;
using Thinh_Ecom.Models;

namespace Thinh_Ecom.Controllers.ClientPage
{
    [Authorize]
    public class CheckoutController : Controller
    {
        // GET: CheckoutController
        [Route("/checkout")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckoutController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }



        // POST: CheckoutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CheckoutModels checkoutModels)
        {
            try
            {
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Create Bill
                var createBill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_ProductIdlist = "",
                    bill_ProductNamelist = "",
                    bill_ProductPricelist = "",
                    bill_QuantityList = "",
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Cash",
                    bill_Shipping = 0,
                    bill_Discount = 0,
                    bill_Note = "",
                    bill_UserId = "userId"

                };

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckoutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckoutController/Edit/5
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

        // GET: CheckoutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckoutController/Delete/5
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
