using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Claims;
using Thinh_Ecom.Data;
using Thinh_Ecom.Entities;
using Thinh_Ecom.Models;
using System.Linq;

namespace Thinh_Ecom.Controllers.ClientPage
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

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
                //Transfer Data

                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };

                query = query.Where(x => x.d.Id == userId);

                string productIdList = "";
                string productNameList = "";
                string productPriceList = "";
                string productQuantityList = "";

                foreach (var item in query)
                {
                    productIdList += item.a.pd_Id + "|";
                    productNameList += item.a.pd_Name + "|";
                    productPriceList += item.a.pd_Price + "|";
                    productQuantityList += item.b.pic_amount + "|";
                }



                // Create Bill
                var createBill = new Bills()
                {
                    bill_Id = Guid.NewGuid().ToString(),
                    bill_ProductIdlist = productIdList,
                    bill_ProductNamelist = productNameList,
                    bill_ProductPricelist = productPriceList,
                    bill_QuantityList = productQuantityList,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Cash",
                    bill_Shipping = ShippingPrice(),
                    bill_Discount = DiscountPrice(),
                    bill_Note = "",
                    bill_UserId = userId

                };

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public void SendMail(string Mailto, string subject, string boddy)
        {
            var smtpacountJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Mail"];
            var smtppasswordJson = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("MailSettings")["Password"];

            String mailgui = smtpacountJson.ToString();
            string smtpacount = smtpacountJson.ToString();
            string smtppassword = smtppasswordJson.ToString();

            MailUtils.MailUtils.SendMailGoogleSmtp(
                mailgui,
                Mailto,
                subject,
                boddy,
                smtpacount,
                smtppassword

            ).Wait();
        }

        public int ShippingPrice()
        {
            //Calculator price

            return 1;
        }

        public int DiscountPrice()
        {
            //Calculator price
            var price = HttpContext.Session.GetString(KeySession.SessionCoupon);
            int discount = 0;
            return discount = (price is null) ? 0 : Int32.Parse(HttpContext.Session.GetString(KeySession.SessionCoupon)); ;
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
