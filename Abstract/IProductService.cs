using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IProductService
    {
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
    }
}
