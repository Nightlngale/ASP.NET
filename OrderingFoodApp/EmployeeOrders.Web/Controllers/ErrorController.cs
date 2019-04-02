using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOrders.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
			var exception = HttpContext.Features.Get<IExceptionHandlerFeature>();
			ViewData["StatusCode"] = HttpContext.Response.StatusCode;
			ViewData["Message"] = exception.Error.Message;
			return View();
        }

		public IActionResult AccessDenied()
		{
			return View();
		}

	}
}