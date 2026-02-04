using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Services;
using ProjectLibrary.BLL.Entities;

//Créer un alias pour ne pas avoir deux mêmes noms pour des objets différents
using BLLEntities = ProjectLibrary.BLL.Entities;
using DALEntities = ProjectLibrary.DAL;
using DALService = ProjectLibrary.DAL.Services;
using BLLService = ProjectLibrary.BLL.Services;


namespace ProjectLibrary.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ne pas oublier pour tester de faire clic droit sur Dépendances et ajouterune référence au projet
            //Pour ajouter le projet qu'on veut tester
            #region Test DAL
            DALService.BookService dalService = new DALService.BookService();
            #region Get ALL

            //IEnumerable<Book> library = service.Get();

            //foreach (Book book in library)
            //{
            //    Console.WriteLine($"{book.Title} écrit par {book.Author}");
            //}
            #endregion
            #region Get by ID

            //Console.WriteLine("Entrez un ID");
            //Guid id = Guid.Parse(Console.ReadLine());
            //Book livre = service.Get(id);
            //Console.WriteLine($"{livre.Title} écrit par {livre.Author}"); 
            #endregion
            #region Create

            //Book bookToAdd = new Book();
            //Console.WriteLine("Entrez un titre");
            //bookToAdd.Title = Console.ReadLine();
            //Console.WriteLine("Entrez un Auteur");
            //bookToAdd.Author = Console.ReadLine();
            //Console.WriteLine("Entrez une Date de sortie");
            //bookToAdd.ReleaseDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez ISBN");
            //bookToAdd.ISBN = Console.ReadLine();

            //bookToAdd.BookId = service.Create(bookToAdd);
            //Console.WriteLine($"Livre ajouté : {bookToAdd.ReleaseDate.ToShortDateString()}, titre : {bookToAdd.Title}");
            #endregion
            #region Update

            //Console.WriteLine("Entrez un ID");
            //Guid idToUpdate = Guid.Parse(Console.ReadLine());
            //Book bookToUpdate = service.Get(idToUpdate);
            //Console.WriteLine($"{bookToUpdate.Title} écrit par {bookToUpdate.Author}");


            //Console.WriteLine("Entrez un titre");
            //bookToUpdate.Title = Console.ReadLine();
            //Console.WriteLine("Entrez un Auteur");
            //bookToUpdate.Author = Console.ReadLine();
            //Console.WriteLine("Entrez une Date de sortie");
            //bookToUpdate.ReleaseDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Entrez ISBN");
            //bookToUpdate.ISBN = Console.ReadLine();


            //service.Update(idToUpdate, bookToUpdate);

            //bookToUpdate = service.Get(idToUpdate);
            //Console.WriteLine($"{bookToUpdate.Title} écrit par {bookToUpdate.Author}");
            #endregion

            #region Delete
            //Console.WriteLine("Entrez un ID");
            //Guid idToDelete = Guid.Parse(Console.ReadLine());
            //Book bookToDelete = service.Get(idToDelete);
            //Console.WriteLine($"{bookToDelete.Title} écrit par {bookToDelete.Author}");
            //service.Delete(idToDelete);
            #endregion
            #endregion


            #region Test BLL (sans DAL)
            #region Test de la classe Book dans BLL

            //BLLEntities.Book book = new BLLEntities.Book("Lord of the ring 2", "JRR TOLKIEN", "9852123654879", new DateTime(1980,12,12));


            //Console.WriteLine($"{book.Title} est écrit par {book.Author}. Statut :" + (book.IsActive? " disponible" : " non disponible")) ;

            //book.Disable();

            //Console.WriteLine($"{book.Title} est écrit par {book.Author}. Statut :" + (book.IsActive ? " disponible" : " non disponible"));


            #endregion
           
            //Créer le service BLL en prenant en paramètre le service DAL
            BLLService.BookService bllService = new BLLService.BookService(dalService);

            #region Test du GetAll
            //IEnumerable<BLLEntities.Book> library = bllService.Get();

            //foreach (BLLEntities.Book book in library)
            //{
            //    Console.WriteLine($"{book.Title} écrit par {book.Author}");
            //}

            #endregion

            #region Test Get by ID
            //Console.WriteLine("Entrez un ID");
            //Guid id = Guid.Parse(Console.ReadLine());
            //BLLEntities.Book livre = bllService.Get(id);
            //Console.WriteLine($"{livre.Title} écrit par {livre.Author}");

            #endregion


            #region Create

            Console.WriteLine("Entrez un titre");
            string title = Console.ReadLine();
            Console.WriteLine("Entrez un Auteur");
            string? author = Console.ReadLine();
            Console.WriteLine("Entrez une Date de sortie");
            DateTime releaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entrez ISBN");
            string? ISBN = Console.ReadLine();

            BLLEntities.Book newBook = new BLLEntities.Book(title, author, ISBN, releaseDate);
            
            Guid bookID = bllService.Create(newBook);
            newBook = bllService.Get(bookID);

            Console.WriteLine($"Livre ajouté : {newBook.ReleaseDate.ToShortDateString()}, titre : {newBook.Title}");
            #endregion
            #endregion
        }
    }
}
