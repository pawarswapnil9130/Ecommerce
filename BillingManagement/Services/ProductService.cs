﻿using Ekart.Models;
using System.Linq;

namespace Ekart.Services
{
    public class ProductService
    {
        private  EkartDbContext _ekartDb;

        public ProductService(EkartDbContext ekartDbContext)
        {
            _ekartDb = ekartDbContext;
        }


        public void AddProduct(Products product)
        {
            _ekartDb.Products.Add(product);
            _ekartDb.SaveChanges();
        }


        public IEnumerable<Products> GetAllProducts()
        {
            return _ekartDb.Products.ToList();  
        }


        public Products GetProductById(int productId)
        {
           return  _ekartDb.Products.FirstOrDefault();
           // return _ekartDb.Products.FirstOrDefault(p => p.ProductId == productId);
        }


        public void UpdateProduct(Products product)
        {
            _ekartDb.Products.Update(product);
            _ekartDb.SaveChanges();
        }


        public void DeleteProduct(int productId)
        {
            var productToDelete = _ekartDb.Products.FirstOrDefault(p => p.ProductId == productId);
            if (productToDelete != null)
            {
                _ekartDb.Products.Remove(productToDelete);
                _ekartDb.SaveChanges();
            }
        }
    }
}
