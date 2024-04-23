using Ekart.Models;
using Ekart.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ekart.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allProducts = _productService.GetAllProducts();
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        //[HttpGet]
        //public IActionResult AddProduct()
        //{    
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
