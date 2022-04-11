using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thinh_Ecom.Data;
using Thinh_Ecom.Models;
using Thinh_Ecom.Entities;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Thinh_Ecom.Controllers.AdminPage.Admin
{
    [Authorize(Roles =  "admin")]
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
            var queryUsers = _context.AppUser;
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
                queryUsers.UserName = appUser.UserName;
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

                //Remove User
                _context.AppUser.Remove(queryUsers);
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
