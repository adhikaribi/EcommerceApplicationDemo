using System.Web.Mvc;
using Service.Interfaces;
using Services;
using Infrastructure.Data;

namespace EcommerceApplication.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _service;
        private IProductService _pservice;

        public HomeController(ICategoryService service, IProductService pservice)
        {
            _service = service;
            _pservice = pservice;
        }

        public ActionResult Index()
        {
            return View(_service.GetCategories());
        }

        public JsonResult SearchProducts(string productname)
        {
            return Json(_pservice.SearchProductsByName(productname), JsonRequestBehavior.AllowGet);
        }
    }
}