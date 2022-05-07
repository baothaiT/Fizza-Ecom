using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;
using Thinh_Ecom.Models;
using Thinh_Ecom.Entities;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Thinh_Ecom.Controllers.AdminPage.Admin
{
    [Authorize(Roles =  "Admin")]
    public class AdminUsersManagementController : Controller
    {

        public UsersModel usersModel;
        private readonly ApplicationDbContext _context;
        public AdminUsersManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminUsersManagementController
        [Route("/usersmanagement")]
        [HttpGet]
        public ActionResult Index()
        {
            // Print list Users
            var queryUsers = from a in _context.AppUser select a;
            queryUsers = queryUsers.Where(a => a.IsDelete != true);
            return View(queryUsers);
        }

        // GET: AdminUsersManagementController/Details/5
        [Route("/usersmanagement/details/{id:guid}")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            //Print information or user
            var queryUsers = _context.AppUser.Find(id);

            return View(queryUsers);
        }

        // GET: AdminUsersManagementController/Edit/5
        [Route("/usersmanagement/edit/{id:guid}")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            // Edit Users
            var queryUsers = _context.AppUser.Find(id);

            return View(queryUsers);
        }

        // POST: AdminUsersManagementController/Edit/5
        [Route("/usersmanagement/edit/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, AppUser appUser)
        {
            try
            {
                //Edit information or user
                var queryUsers = _context.AppUser.Find(appUser.Id);
                queryUsers.FirstName = appUser.FirstName;
                queryUsers.LastName = appUser.LastName;

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminUsersManagementController/Delete/5
        [Route("/usersmanagement/delete/{id:guid}")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            //Print information of user
            var queryUsers = _context.AppUser.Find(id);
            return View(queryUsers);
        }

        // POST: AdminUsersManagementController/Delete/5
        [Route("/usersmanagement/delete/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, AppUser appUser)
        {
            try
            {
                //Find user by id
                var queryUsers = _context.AppUser.Find(appUser.Id);
                queryUsers.IsDelete = true;
                queryUsers.EmailConfirmed = false;
                //Remove User
                _context.AppUser.Update(queryUsers);
                _context.SaveChanges();
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminUsersManagementController/Delete/5
        [Route("/usersmanagement/roleinuser/{id:guid}")]
        [HttpGet]
        public ActionResult RoleInUser(string id)
        {
            //Query Categories 
            var roleQuery = _context.AppRole;

            List<SelectListItem> roleList = new List<SelectListItem>();
            foreach (var roles in roleQuery)
            {
                var itemRole = new SelectListItem { Value = roles.Id, Text = roles.Name };
                roleList.Add(itemRole);
            }
            ViewBag.RoleList = roleList;

            //Print information of user
            var queryUsers = _context.AppUser.Find(id);
            return View(queryUsers);
        }

        // POST: AdminUsersManagementController/Delete/5
        [Route("/usersmanagement/roleinuser/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoleInUser(string id, AppUser appUser)
        {
            try
            {
                //Find user by id
                var queryUsers = _context.AppUser.Find(appUser.Id);
                queryUsers.IsDelete = true;
                queryUsers.EmailConfirmed = false;
                //Remove User
                _context.AppUser.Update(queryUsers);
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
