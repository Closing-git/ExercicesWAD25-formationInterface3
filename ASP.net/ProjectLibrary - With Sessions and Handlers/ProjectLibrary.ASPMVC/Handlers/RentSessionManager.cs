using Newtonsoft.Json.Linq;
using System.Text.Json;
using ProjectLibrary.ASPMVC.Models.Rent;


namespace ProjectLibrary.ASPMVC.Handlers
{
    public class RentSessionManager
    {
        private readonly ISession _session;
        public RentSessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public IEnumerable<string> Titles;

        public IEnumerable<RentBook> Basket
        {
            get
            {
                if (_session.GetString(nameof(Basket)) is null)
                {
                    Basket = new List<RentBook>();

                }
                return JsonSerializer.Deserialize<RentBook[]>(_session.GetString(nameof(Basket)));
            }
            private set
            {
                _session.SetString(nameof(Basket), JsonSerializer.Serialize(value));
            }
        }

        public void AddBook(RentBook book)
        {

            List<RentBook> books = new List<RentBook>(Basket);
            for (int i = 0; i < books.Count; i++)
            {
                //Vérifier que le livre n'est pas déjà dans le basket
                if (Basket.ElementAt(i).BookId == book.BookId)
                {
                    return;
                }
            }
            books.Add(book);
            Basket = books;
        }

        public void RemoveBook(Guid id)
        {

            List<RentBook> books = new List<RentBook>(Basket);
            books.Remove(books.SingleOrDefault(item => item.BookId == id));
            Basket = books;
        }
    }
}
