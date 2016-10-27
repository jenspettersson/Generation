using System.Web.Mvc;
using Generation.WordReverser;

namespace Generation.Excercise.Web.Controllers
{
    public class ReverserController : Controller
    {
        private Reverser _reverser;

        public ReverserController()
        {
            _reverser = new Reverser();
        }

        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Test(string word)
        {
            return Json(_reverser.Reverse(word));
        }
    }
}