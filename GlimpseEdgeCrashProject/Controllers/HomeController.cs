using System.Web.Mvc;
using EdgeJs;

namespace GlimpseEdgeCrash.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var func = @"
                return function(data, callback) {
                  return callback(null, {
                    ""Greeting"" : ""Hello Edge.js World!""
                  });
                }
";

			var greetingFunc = Edge.Func(func);
			dynamic greetingObj = greetingFunc(new object()).Result;

			ViewBag.Greeting = greetingObj.Greeting;
			return View();
		}
	}
}