using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Model;
using Service;
namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService user)
        {
            userService = user;
        }
        // GET: User
        public ActionResult login(string name, string pw)
        {
            ViewBag.login = userService.Login(name, pw);
            return View(nameof(login));
        }

        // GET: User
        public ActionResult register(string name, string pw)
        {
            ViewBag.register = userService.Register(name, pw);
            return View();
        }



    }
}