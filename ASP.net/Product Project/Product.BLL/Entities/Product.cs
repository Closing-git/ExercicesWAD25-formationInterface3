using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.BLL.Entities
{
    public class Product
    {

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


        public string Name { get; private set; }
        public string? Description { get; set; }

        private decimal _currentPrice;
        public decimal CurrentPrice
        {
            get
            {
                return _currentPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Le prix ne peut pas être inférieur à 0");
                }
            }
        }
 

        public Product(int productId, string name, string? description, decimal currentPrice)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            CurrentPrice = currentPrice;
        }
        public Product(string name, string? description, decimal currentPrice)
        {
            Name = name;
            Description = description;
            CurrentPrice = currentPrice;
        }


    }
}
