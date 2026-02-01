using ProjectLibrary.BLL.Entities;
using ProjectLibrary.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Services
{
    //Penser à ajouter une référence au DAL dans les dépendances 
    public class BookService
    {
        //On récupère le book service du DAL
        private readonly DAL.Services.BookService _dalService;

        public BookService(DAL.Services.BookService dalService)
        {
            _dalService = dalService;
        }


        //On met en place le CRUD, mais dans le BLL cette fois
        //Bien prendre l'objet Book de la BLL (pas DAL)
        public IEnumerable<Book> Get()
        {
            //book=> book.ToBLL() pour chaque book transforme le en book de BLL grace au mapper
            return _dalService.Get().Select(book => book.ToBLL());
        }

        public Book Get(Guid bookId)
        {
            return _dalService.Get(bookId).ToBLL();
        }

        //Transformer nos entity BLL en entity DAL pour qu'ils puissent être créé dans le DAL aussi
        public Guid Create(Book entity)
        {
            return _dalService.Create(entity.ToDAL());
        }

        public void Update(Guid bookId, Book newData)
        {
            _dalService.Update(bookId, newData.ToDAL()); 
        }

        public void Delete(Guid bookId)
        {
            _dalService.Delete(bookId);
        }
    }
}
