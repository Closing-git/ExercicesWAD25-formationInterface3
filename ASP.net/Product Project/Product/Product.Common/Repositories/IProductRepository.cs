using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Common.Repositories
{
    public interface IProductRepository<TProduct> : ICRUDRepository<TProduct, int>
    {
    }
}
