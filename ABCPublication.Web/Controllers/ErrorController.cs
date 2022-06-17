using ABCPublication.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABCPublication.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodehandler(int statusCode)
        {
            var errorModel = new ErrorViewModel();
            switch (statusCode)
            {
                case 404:
                    errorModel.StatusCode = 404;
                    errorModel.ErrorMessage = "Sorry, the resource you requested could not be found!";
                    break;
            }
            return View("NotFound", errorModel);
        }
    }
}
