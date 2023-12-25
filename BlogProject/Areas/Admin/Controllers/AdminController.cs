using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Areas.Admin.Controllers
{
    //[Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Home/Index.cshtml");
        }

        public ActionResult Blogs()
        {
            return View("~/Areas/admin/views/home/Blogs.cshtml");
        }

        public ActionResult Sliders()
        {
            return View("~/Areas/admin/views/home/Sliders.cshtml");
        }
    }
}
