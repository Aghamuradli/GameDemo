using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Products product)
        {
            Console.WriteLine("Product: " + product.Name + " added with a price of: " + product.Price);
        }

        public void Delete(Products product)
        {
            Console.WriteLine("Product deleted: " + product.Name);
        }

        public void Update(Products product)
        {
            Console.WriteLine("Product deleted: " + product.Name);
        }
    }
}
