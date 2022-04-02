using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Thinh_Ecom.Data;
using Thinh_Ecom.Entities;

namespace Thinh_Ecom.Controllers.AdminPage.Staff
{
    public class ProductsManagementController : Controller
    {

        public readonly ApplicationDbContext _context;
        public ProductsManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ProductsManagementController
        [Route("productsmanagement")]
        public ActionResult Index()
        {
            var queryProduct = _context.Products;
            return View(queryProduct);
        }

        // GET: ProductsManagementController/Details/5
        [Route("productsmanagement/details/{id:guid}")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            //Print information of product
            var queryProduct = _context.Products.Find(id);
            return View(queryProduct);
        }

        // GET: ProductsManagementController/Create
        [Route("productsmanagement/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products products)
        {
            try
            {
                var productInfo = new Products()
                {
                    pd_Id = Guid.NewGuid().ToString(),
                    pd_Name = products.pd_Name,
                    pd_Description = products.pd_Description,
                    pd_Img1 = products.pd_Img1,
                    pd_Price = products.pd_Price,
                    pd_ReducePrice = products.pd_ReducePrice

                };
                _context.Products.Add(productInfo);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsManagementController/Edit/5
        [Route("productsmanagement/edit/{id:guid}")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            //Print information of product
            var queryProduct = _context.Products.Find(id);
            return View(queryProduct);
        }

        // POST: ProductsManagementController/Edit/5
        [Route("productsmanagement/edit/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Products products)
        {
            try
            {
                //Edit info of product
                var queryProduct = _context.Products.Find(id);
                queryProduct.pd_Name = products.pd_Name;
                queryProduct.pd_Description = products.pd_Description;
                queryProduct.pd_Img1 = products.pd_Img1;
                queryProduct.pd_Price = products.pd_Price;
                queryProduct.pd_ReducePrice = products.pd_ReducePrice;

                _context.Products.Update(queryProduct);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsManagementController/Delete/5
        [Route("productsmanagement/delete/{id:guid}")]
        [HttpGet]
        public ActionResult Delete(string id)
        {

            var queryProduct = _context.Products.Find(id);
            return View(queryProduct);
        }

        // POST: ProductsManagementController/Delete/5
        [Route("productsmanagement/delete/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var queryProduct = _context.Products.Find(id);
                _context.Products.Remove(queryProduct);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
