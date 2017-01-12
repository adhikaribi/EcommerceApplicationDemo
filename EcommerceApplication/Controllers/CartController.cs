using Domain.Entities;
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
    public class CartController : Controller
    {
        //private ICartService _service = new CartService(new CartRepository());
        private ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        public ActionResult CartDetail()
        {
            return View(_service.GetCartItems());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void AddItem(CartProduct item)
        {
            _service.AddCartItem(item);
        }

        public ActionResult DeleteItem(int id)
        {
            _service.DeleteItem(id);
            return RedirectToAction("CartDetail");
        }
    }
}