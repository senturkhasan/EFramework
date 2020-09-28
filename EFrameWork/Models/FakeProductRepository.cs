﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFrameWork.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product(){ProductId=1,Name="Samsung S5",Price=2000,Category="Telefon"},
            new Product(){ProductId=1,Name="Samsung S6",Price=3000,Category="Telefon"},
            new Product(){ProductId=1,Name="Samsung S7",Price=4000,Category="Telefon"},
            new Product(){ProductId=1,Name="Samsung S8",Price=5000,Category="Telefon"}


        }.AsQueryable();
        public void CreateProduct(Product product)
        {

        }

        public void DeleteProduct(int Productid)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
