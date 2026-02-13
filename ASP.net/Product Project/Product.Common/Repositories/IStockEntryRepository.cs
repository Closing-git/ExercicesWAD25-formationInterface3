using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Common.Repositories
{
    public interface IStockEntryRepository<TStockEntry> 
    {
        public IEnumerable<TStockEntry> Get();
        public TStockEntry Get(int id);
        public int Create(TStockEntry entity);

        public IEnumerable<TStockEntry> GetByProduct(int productId);
    }
}
