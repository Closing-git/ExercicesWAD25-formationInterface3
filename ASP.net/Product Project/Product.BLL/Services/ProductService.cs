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
        private readonly IStockEntryRepository<StockEntry> _stockEntryService;

        public ProductService(IProductRepository<DAL.Entities.Product> dalService, IStockEntryRepository<StockEntry> stockEntryService)
        {
            _dalService = dalService;
            _stockEntryService = stockEntryService;
        }

        public int Create(Product entity)
        {
            return _dalService.Create(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _dalService.Delete(id);
        }

        public IEnumerable<Product> Get()
        {
            return _dalService.Get().Select(product => product.ToBLL());
        }

        public Product Get(int id)
        {
            return _dalService.Get(id).ToBLL();
        }

        public void Update(int id, Product entity)
        {
            _dalService.Update(id, entity.ToDAL());
        }

        public int GetStock(int productId)
        {
            return _stockEntryService.Get()
                .Where(stockEntry => stockEntry.ProductId == productId)
                .Select(se => se.StockOperation)
                .Sum();
            
        }
    }
}
