using Microsoft.AspNetCore.Mvc;
using Nhemiu.Models;

namespace Nhemiu.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        DuAnTotNghiep2025Context db= new DuAnTotNghiep2025Context();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Danhsach")]
        public IActionResult SanPham()
        {
            var lstSP= db.SanPhams.ToList();
            return View(lstSP);
        }
        [Route("ThemSanPham")]
        [HttpGet]
        public IActionResult ThemSanPham()
        {

            return View();
        }
        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPham(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                sanPham.IdSp= Guid.NewGuid();
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("danhsach");
            }
            return View(sanPham);
        }

        public IActionResult ThongKe()
        {
            return View();
        }
    }
}
