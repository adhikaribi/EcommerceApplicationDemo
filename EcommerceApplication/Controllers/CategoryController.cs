using Infrastructure.Data;
using Service.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceApplication.Controllers
{
    public class CategoryController : Controller
    {
        //private IProductService _service = new ProductService(new ProductRepository());
        private IProductService _service;

        public CategoryController(IProductService service)
        {
            _service = service;
        }

        public ActionResult Lists(int id)
        {
            return View(_service.GetProductsByCategory(id));
        }
    }
}