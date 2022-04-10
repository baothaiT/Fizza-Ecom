using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;
using System.Linq;
using Thinh_Ecom.Models;
using Thinh_Ecom.Function;
using Microsoft.EntityFrameworkCore;
using Thinh_Ecom.Entities;
using System.Threading.Tasks;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

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
        [HttpGet("{Search}")]
        public ActionResult Index(string Search, string sortOrder, string currentFilter, int? pageNumber)
        {
            //Query Food
            var queryFood = from a in _context.Products
                            join b in _context.Categories on a.CategoriesFK equals b.cg_Id
                            select new { a, b };
            if (Search != null)
            {
                queryFood = queryFood.Where(a => a.a.pd_Name.Contains(Search));
            }

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


        [Authorize]
        // POST: PizzaController/Delete/5
        [Route("addtocart")]
        [HttpGet("pd_Id")]
        public async Task<IActionResult> AddToCart(Products products, string pd_Id)
        {

            try
            {
                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);
                string cartId = Guid.NewGuid().ToString();


                if (checkLogin)
                {
                    // Logined
                    // Query cart
                    var queryCart = _context.Cart.FirstOrDefault(a => a.cart_UserID == userId.ToString());

                    // Check Cart
                    if (queryCart == null)
                    {
                        //Create cart 
                        var cartCreate = new Cart()
                        {
                            cart_Id = cartId,
                            cart_UserID = userId
                        };
                        _context.Cart.Add(cartCreate);
                    }
                    else
                    {
                        cartId = queryCart.cart_Id;
                    }

                    //Create ProductInCart
                    var ProductInCartCreate = new ProductInCart()
                    {
                        pic_CartId = cartId,
                        pic_ProductId = pd_Id.ToString(),
                        pic_amount = 1,
                    };
                    _context.ProductInCart.Add(ProductInCartCreate);


                    await _context.SaveChangesAsync();
                }
                else
                {
                    ///// No logined
                    ///// Create Device in DB
                    //var deviceQuery = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                    //if (deviceQuery == null)
                    //{
                    //    string DeviceId = Guid.NewGuid().ToString();
                    //    var AddDevice = new Device()
                    //    {
                    //        deviceId = DeviceId,
                    //        deviceName = namePc
                    //    };
                    //    _context.Devices.Add(AddDevice);
                    //    await _context.SaveChangesAsync();
                    //}
                    ///// Create Device in DB
                    //var deviceQueryre = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                    ////Create cart
                    //var CartsDevice = new CartsDevice()
                    //{
                    //    cartd_Id = cartId,
                    //    cartd_DeviceId = deviceQueryre.deviceId
                    //};

                    //_context.CartsDevice.Add(CartsDevice);
                    //var ProductInCartDevices = new ProductInCartDevices()
                    //{
                    //    picd_CartId = cartId,
                    //    picd_ProductId = productid.ToString(),
                    //    picd_amount = quantityProduct
                    //};

                    //_context.ProductInCartDevices.Add(ProductInCartDevices);
                    //await _context.SaveChangesAsync();
                }
                return Redirect("/cart");
            }
            catch
            {
                return Redirect("/cart");
            }

        }
    }
}
