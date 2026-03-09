using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BLL.Entities
{
    public class StockEntry
    {

        private int _stockEntryId;

        public int StockEntryId
        {
            get
            {
                return _stockEntryId;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new FormatException("L'id ne peut pas être inférieur ou égal à 0");

                }
                _stockEntryId = value;
            }
        }
        public DateTime EntryDate { get; private set; }
        public int StockOperation { get; set; }

        private int _productId;
        public int ProductId
        {
            get
            {
                return _productId;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new FormatException("L'id ne peut pas être inférieur ou égal à 0");

                }
                _productId = value;
            }
        }

        public StockEntry(int stockEntryId, DateTime entryDate, int stockOperation, int productId)
        {
            StockEntryId = stockEntryId;
            EntryDate = entryDate;
            StockOperation = stockOperation;
            ProductId = productId;
        }


        public StockEntry(DateTime entryDate, int stockOperation, int productId)
        {
            EntryDate = entryDate;
            StockOperation = stockOperation;
            ProductId = productId;
        }
    }
}
