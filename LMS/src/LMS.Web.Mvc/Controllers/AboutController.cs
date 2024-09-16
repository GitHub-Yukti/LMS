using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LMS.Controllers;

namespace LMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
