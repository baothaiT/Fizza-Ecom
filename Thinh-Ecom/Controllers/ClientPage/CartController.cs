using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Thinh_Ecom.Data;
using System.Linq;
using Thinh_Ecom.Models;
using System.Collections.Generic;

namespace Thinh_Ecom.Controllers.ClientPage
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CartController
        [Route("cart")]
        [HttpGet]
        public ActionResult Index()
        {
            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (checkLogin)
            {
                //login
                var query = from a in _context.Products
                            join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                            join c in _context.Cart on b.pic_CartId equals c.cart_Id
                            join d in _context.AppUser on c.cart_UserID equals d.Id
                            select new { a, b, c, d };



                query = query.Where(x => x.d.Id == userId);

                var cartModelQuery = query
                    .Select(x => new CartModels()
                     {
                        cart_ProductId = x.a.pd_Id,
                        cart_ProductName = x.a.pd_Name,
                        cart_ProductPrice = x.a.pd_Price,
                        cart_ProductImg = x.a.pd_Img1,
                        cart_ProductQuantity = x.b.pic_amount

                     });

                ViewBag.Cart = cartModelQuery;

                ViewBag.SubToTal = 1;
                ViewBag.Discount = 1;
                ViewBag.Shipping = 1;
                ViewBag.Total = 1;

                return View();
            }

            return View();
        }

        // GET: CartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
        [Route("cart/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ICollection<CartModels> cartModels)
        {
            try
            {
                foreach (var itemProductInCart in cartModels)
                {
                    var queryCart = _context.ProductInCart.FirstOrDefault(a => a.pic_ProductId == itemProductInCart.cart_ProductId);

                    queryCart.pic_amount = itemProductInCart.cart_ProductQuantity;

                    _context.ProductInCart.Update(queryCart);
                }

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Delete/5
        [Route("cart/remove")]
        [HttpGet("pd_Id")]
        public ActionResult Remove(string pd_Id)
        {
            string namePc = Environment.MachineName;
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (checkLogin)
            {
                //Logined
                var queryProduct = _context.ProductInCart.FirstOrDefault(a=>a.pic_ProductId == pd_Id);

                _context.ProductInCart.Remove(queryProduct);
                _context.SaveChanges();
            }
            else
            {
                //Not login

            }
                
            return RedirectToAction(nameof(Index));
        }

        
    }
}
