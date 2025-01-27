using Microsoft.AspNetCore.Mvc;

namespace CV.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBaseController:Controller
    {
        protected string SuccessMessage = "Seucces";
        protected string ErrorMessage = "Error";
    }
}
