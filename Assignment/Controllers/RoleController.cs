﻿using Assignment.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Role
        public ActionResult RoleList()
        {
            var roleList = _db.Roles.ToList();
            return View(roleList);
        }

        [HttpGet]
        public ActionResult CreateRole()
        {
            var role = new IdentityRole();
            return View(role);
        }

        [HttpPost]
        public ActionResult CreateRole(IdentityRole identity)
        {
            _db.Roles.Add(identity);
            _db.SaveChanges();
            return RedirectToAction("RoleList");
        }
    }
}