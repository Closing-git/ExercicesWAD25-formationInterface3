using ProjectProduct.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BLL.Mappers
{
    internal static class Mapper
    {
        #region Product
        public static BLL.Entities.Product ToBLL(this DAL.Entities.Product entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            BLL.Entities.Product product = new BLL.Entities.Product(
                entity.ProductId,
                entity.Name,
                entity.Description,
                entity.CurrentPrice
                );
            return product;
        }

        public static DAL.Entities.Product ToDAL(this BLL.Entities.Product entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new DAL.Entities.Product()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Description = entity.Description,
                CurrentPrice = entity.CurrentPrice,
            };
        }
        #endregion

        #region StockEntry
        public static BLL.Entities.StockEntry ToBLL(this DAL.Entities.StockEntry entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            BLL.Entities.StockEntry stockEntry = new BLL.Entities.StockEntry(
                entity.StockEntryId,
                entity.EntryDate,
                entity.StockOperation,
                entity.ProductId
                );
            return stockEntry;
        }

        public static DAL.Entities.StockEntry ToDAL(this BLL.Entities.StockEntry entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            return new DAL.Entities.StockEntry()
            {
                StockEntryId = entity.StockEntryId,
                EntryDate = entity.EntryDate,
                StockOperation = entity.StockOperation,
                ProductId = entity.ProductId,
            };
        } 
        #endregion
    }
}