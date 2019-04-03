using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;

namespace BanXeDap2.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(admin admin)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Insert(admin);
                if (id > 0)
                {
                    return RedirectToAction("User", "Index");
                }
                else
                {
                    ModelState.AddModelError("", "Them User thanh cong");
                }
            }
            return View("Index");
        }
    }
}