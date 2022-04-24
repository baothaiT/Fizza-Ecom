using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Thinh_Ecom.Data;
using Thinh_Ecom.Entities;
using System.Linq;

namespace Thinh_Ecom.Controllers.AdminPage.Staff
{
    [Authorize(Roles = "Admin, Staff")]
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
            //Query Academic Year 
            var categoriesYearQuery = _context.Categories;

            List<SelectListItem> AcademicYearList = new List<SelectListItem>();
            foreach (var categories in categoriesYearQuery)
            {
                var itemCategories = new SelectListItem { Value = categories.cg_Id, Text = categories.cg_Name };
                AcademicYearList.Add(itemCategories);
            }
            ViewBag.idea_CategoriesId = AcademicYearList;

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
                    pd_ReducePrice = products.pd_ReducePrice,
                    pd_ShortDescription = products.pd_ShortDescription,
                    CategoriesFK = products.CategoriesFK


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

            //Query Current Categories
            var queryCurrentCategories = _context.Categories.FirstOrDefault(a => a.cg_Id == queryProduct.CategoriesFK);
            ViewBag.CurrentCategories = queryCurrentCategories;
            //List Categories
            var queryCategoriesList = _context.Categories.Where(a => a.cg_Id != queryCurrentCategories.cg_Id);
            ViewBag.CategoriesList = queryCategoriesList;
            
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
                var queryProduct = _context.Products.Find(products.pd_Id);
                queryProduct.pd_Name = products.pd_Name;
                queryProduct.pd_Description = products.pd_Description;
                queryProduct.pd_Img1 = products.pd_Img1;
                queryProduct.pd_Price = products.pd_Price;
                queryProduct.pd_ReducePrice = products.pd_ReducePrice;
                queryProduct.pd_ShortDescription = products.pd_ShortDescription;
                queryProduct.CategoriesFK = products.CategoriesFK;

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
        public ActionResult Delete(int id, Products products)
        {
            try
            {
                var queryProduct = _context.Products.Find(products.pd_Id);
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
