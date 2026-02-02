using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Common.Repositories
{
    public interface IBookRepository<TBook>
    {
        //T pour un type générique (polymorphisme)
        public IEnumerable<TBook> Get();
        public TBook Get(Guid bookId);
        public Guid Create(TBook entity);
        public void Update(Guid bookId, TBook entity);
        public void Delete(Guid bookId);

    }
}
