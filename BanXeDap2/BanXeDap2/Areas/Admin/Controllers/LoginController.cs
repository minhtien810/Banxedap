﻿using BanXeDap2.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using BanXeDap2.Common;

namespace BanXeDap2.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.PassWord));
                if (result==1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.ten_admin;
                    userSession.UserID = user.id_admin;
                    Session.Add(CommonConstants.USER_SESSION,userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if(result==0)
                    ModelState.AddModelError("", "Tai khoan khong ton tai.");
                else if (result == -1)
                    ModelState.AddModelError("", "Mat khau khong dung.");
                else
                {
                    ModelState.AddModelError("", "Dang nhap khong thanh cong.");
                }
            }
            return View("Index");          
            
        }
    }
}