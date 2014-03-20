using System.Configuration;
using System.Web.Mvc;
using ALM.Demo.Models.Home;

namespace ALM.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var environment = ConfigurationManager.AppSettings["environment"];
            var message = string.Format("Hello world from {0}", environment);
            var version = GetType().Assembly.GetName().Version.ToString();
            var model = new IndexModel
            {
                Message = message,
                Version = version
            };
            return View(model);
        }
    }
}