using Microsoft.Practices.Unity;
using Persistence.Interfaces;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopSite.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;
        private IProductRepository _productMemoryRepository;

        public ProductsController([Dependency("ProductRepository")]IProductRepository productRepository,
            [Dependency("ProductMemoryRepository")] IProductRepository productMemoryRepository)
        {
            _productMemoryRepository = productMemoryRepository;
            _productRepository = productRepository;
        }
        // GET: Products
        public ActionResult Index()
        {
            HttpCookie cookie = HttpContext.Request.Cookies.Get("storageType");
            if (cookie.Value == "db")
                return View(_productRepository.GetAll());
            else return View(_productMemoryRepository.GetAll());
        }
        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SetStorage()
        {
            return View(_productRepository.GetAll());
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpCookie cookie = HttpContext.Request.Cookies.Get("storageType");
                    if (cookie.Value == "db")
                        _productRepository.Create(model);
                    else
                        _productMemoryRepository.Create(model);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception e)
            {
            }
            return View();
        }
    }
}
