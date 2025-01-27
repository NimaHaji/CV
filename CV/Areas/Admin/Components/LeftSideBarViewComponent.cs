using Microsoft.AspNetCore.Mvc;

namespace CV.Areas.Admin.ViewComponents
{
    public class LeftSideBarViewComponent : ViewComponent
    {
        #region Method
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("LeftSideBar");
        }
        #endregion
    }
}