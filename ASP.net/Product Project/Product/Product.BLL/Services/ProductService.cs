using ProjectProduct.BLL.Entities;
using ProjectProduct.BLL.Mappers;
using ProjectProduct.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BLL.Services
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly IProductRepository<DAL.Entities.Product> _dalService;
        public int Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
