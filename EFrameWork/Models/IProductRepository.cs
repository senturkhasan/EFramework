using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFrameWork.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
        public Product GetById(int productId);
        void UpdateProduct(Product product);
        void DeleteProduct(int Productid);
    }
}
