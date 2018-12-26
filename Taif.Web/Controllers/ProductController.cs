using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taif.Data.Entities.Product;
using Taif.Services.ProductService;

namespace Taif.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly IproductService _Service;

        //inject dependency 
        public ProductController(IproductService Service)
        {
            _Service = Service;
        }

        // GET: Product
        public ActionResult Index()
        {
            var Products = _Service.List();
            return View(Products);
        }
    }
}