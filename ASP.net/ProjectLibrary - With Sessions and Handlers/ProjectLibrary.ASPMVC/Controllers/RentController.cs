using Microsoft.AspNetCore.Mvc;
using ProjectLibrary.ASPMVC.Handlers;
using ProjectLibrary.ASPMVC.Handlers.Filters;
using ProjectLibrary.ASPMVC.Mappers;
using ProjectLibrary.ASPMVC.Models.Book;
using ProjectLibrary.ASPMVC.Models.Rent;
using ProjectLibrary.BLL.Entities;
using ProjectLibrary.Common.Repositories;

namespace ProjectLibrary.ASPMVC.Controllers
{
    public class RentController : Controller
    {
        private readonly RentSessionManager _rentSession;
        private readonly IBookRepository<BLL.Entities.Book> _bllService;

        public RentController(IBookRepository<BLL.Entities.Book> bllService, RentSessionManager rentSession)
        {
            _bllService = bllService;
            _rentSession = rentSession;

        }

        [TypeFilter<EmptyBasketFilter>]
        public IActionResult Index()
        {
            if (_rentSession.Basket is null)
            {
                return RedirectToAction("Index", "Book", null);
            }
            else
            {
                IEnumerable<RentBook> basket;
                basket = _rentSession.Basket;

                Guid bookId;
                List<string> titles = new List<string>();

                foreach (RentBook book in basket)
                {
                    bookId = book.BookId;
                    Book bllBook = _bllService.Get(bookId);
                    string title = bllBook.Title;
                    titles.Add(title);
                }
                _rentSession.Titles = titles;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Rent(Guid id)
        {
            DetailsViewModel model = _bllService.Get(id).ToDetails();
            RentBook book = new RentBook(id, DateTime.Now);
            try
            {
                if (!ModelState.IsValid) throw new InvalidOperationException("Le formulaire n'est pas valide.");
                _rentSession.AddBook(book);

                return RedirectToAction("Index", "Rent", null);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Remove(Guid id)
        {

            try
            {
                if (!ModelState.IsValid) throw new InvalidOperationException("Le formulaire n'est pas valide.");
                _rentSession.RemoveBook(id);

                return RedirectToAction("Index", "Rent", null);
            }
            catch
            {
                return View();
            }
        }

    }
}
