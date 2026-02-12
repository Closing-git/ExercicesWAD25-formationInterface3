using ProjectProduct.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.DAL.Mappers
{
    internal static class Mapper
    {
        public static Product ToProduct(this IDataRecord record)
        {
            if(record == null) throw new ArgumentNullException(nameof(record));
            return new Product()
            {
                ProductId = (int)record[nameof(Product.ProductId)],
                Name = (string)record[nameof(Product.Name)],
                Description = (record[nameof(Product.Description)] is DBNull) ? null : (string?)(record[nameof(Product.Description)]),
                CurrentPrice = (decimal)record[nameof(Product.CurrentPrice)]
            };
        }

        public static StockEntry ToStockEntry (this IDataRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));
            return new StockEntry()
            {
                StockEntryId = (int)record[nameof(StockEntry.StockEntryId)],
                EntryDate = (DateTime)record[nameof(StockEntry.EntryDate)],
                StockOperation = (int)record[nameof(StockEntry.StockOperation)],
                ProductId = (int)record[nameof(StockEntry.ProductId)]
            };
        }
    }
}
