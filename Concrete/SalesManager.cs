using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void SellTo(GamePlayer gamer, Products product)
        {
            Console.WriteLine("Product: " + product.Name + " is sold to: " + gamer.FirstName + " with a price of: " + product.Price);
        }
    }
}
