using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Entities
{
    public class Book
    {
        #region Propriétés
        public Guid BookId { get; private set; }
        public string Title { get; set; }
        public string? Author { get; set; }


        private string? _isbn;
        public string? ISBN
        {
            get { return _isbn; }
            set
            {
                if (value is null)
                {
                    _isbn = value;
                    return;
                }
                if (value.Length > 13) throw new FormatException();
                if (!Regex.IsMatch(value, @"^[\dX]*$")) ;
                _isbn = value;

            }
        }
        public DateTime ReleaseDate { get; private set; }

        public DateTime? _disabledDate;
        //Si le livre est actif (bool), alors la disabledDate est null.
        public bool IsActive { get { return _disabledDate is null; } }
        public DateTime RegisteredDate { get; private set; }


        #endregion

        #region Constructeur

        public Book(Guid bookId, string title, string? author, string? isbn, DateTime releaseDate, DateTime registeredDate, DateTime? disabledDate)
        {
            BookId = bookId;
            Author = author;
            Title = title;
            _isbn = isbn;
            ReleaseDate = releaseDate;
            RegisteredDate = registeredDate;
            if (!(disabledDate is null) && disabledDate < RegisteredDate) throw new ArgumentException(nameof(disabledDate));
            _disabledDate = disabledDate;


        }

        public Book(string title, string? author, string? isbn, DateTime releaseDate)
        {
            BookId = Guid.NewGuid();
            Author = author;
            Title = title;
            _isbn = isbn;
            ReleaseDate = releaseDate;
            RegisteredDate = DateTime.Now;


        }

        #endregion


        public void Disable()
        {
            _disabledDate = DateTime.Now;
        }

    }
}
