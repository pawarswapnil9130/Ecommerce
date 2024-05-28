using Ekart.Models;
using Ekart.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
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
            IEnumerable<Products> allProducts = _productService.GetAllProducts();
             var newProduct = new Products
            {
                ProductId = 1,
                Name = "book",
                Description = "Spritual Book",
                Price = 123.00m,
                QuantityInStock = 10,
                CategoryId = 1,
                imageUrl = "https://wisdomtreeindia.com/images/product/Yogic-Secrets-of-the-Dark-Goddess.jpg",
                Discount = 0,
                Warrenty = 1
            };
            List<Products> productList = allProducts.ToList();
            productList.Add(newProduct);
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItem(Products product)
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
