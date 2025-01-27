using Microsoft.AspNetCore.Mvc;

namespace CV.Web.Areas.Admin.Controllers
{
    public class HomeController:AdminBaseController
    {
        #region Index
        public IActionResult Index()
        {
            ViewData["Title"] = "داشبورد";
            return View();
        }
        #endregion
    }
}
