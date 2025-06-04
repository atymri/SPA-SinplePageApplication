using System.Web.Mvc;

namespace SPA.Controllers
{
    public class HomeController : Controller
    {
        // TODO: Make a DTO as soon as possible
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult List()
        {
            return PartialView();
        }

        public PartialViewResult Add()
        {
            return PartialView();
        }

        public PartialViewResult Edit(int id)
        {
            return PartialView(id);
        }

    }
}