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
    public class StockEntryService : IStockEntryRepository<StockEntry>
    {
        private readonly IStockEntryRepository<DAL.Entities.StockEntry> _dalService;

        public StockEntryService(IStockEntryRepository<DAL.Entities.StockEntry> dalService)
        {
            _dalService = dalService;
        }

        public int Create(StockEntry entity)
        {
            return _dalService.Create(entity.ToDAL());
        }

        public IEnumerable<StockEntry> Get()
        {
            return _dalService.Get().Select(stockEntry => stockEntry.ToBLL()) ;
        }

        public StockEntry Get(int id)
        {
            return _dalService.Get(id).ToBLL();
        }

        public IEnumerable<StockEntry> GetByProduct(int productId)
        {
            return _dalService.GetByProduct(productId).Select(stockEntry => stockEntry.ToBLL());
        }


    }
}
