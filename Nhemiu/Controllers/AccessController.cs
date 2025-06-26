using Microsoft.AspNetCore.Mvc;
using Nhemiu.Models;

namespace Nhemiu.Controllers
{
    public class AccessController : Controller
    {
        DuAnTotNghiep2025Context db= new DuAnTotNghiep2025Context();
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(User user)
        {
            var u = db.Users.Where(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password) && x.Role == "Quản Lý").FirstOrDefault();
            var p = db.Users.Where(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password) && x.Role == "Khach hang").FirstOrDefault();
            if (u != null && p == null)
            {
                HttpContext.Session.SetString("Username", u.UserName.ToString());
                return RedirectToAction("Index", "Home");
            }
            else if (p != null && u == null)
            {
                HttpContext.Session.SetString("Username", p.UserName.ToString());
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
