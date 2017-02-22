using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ProductLister
{
    [Route("/products")]
    public class ProductsController
    {
        private static List<Product> _products = new List<Product>(new[] { 
            new Product() {Id=1,Name="Computer"},
            new Product() {Id=2,Name="Radio"},
            new Product() {Id=3,Name="Apple"},
            new Product() {Id=4,Name="Phone"}
            });
        
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}