using EcommerceAppDomain.Entities;
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
    public class ProductController : Controller
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        // GET: Product
        public ActionResult Detail(int id)
        {
            return View(_service.GetProductById(id));
        }

        public ActionResult GetProduct(int id)
        {
            return View(_service.GetProductById(id));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Update(Product product)
        {
            _service.UpdateProduct(product);
            return RedirectToAction("Detail", new { id = product.productId });
        }
    }
}