namespace ProjectLibrary.ASPMVC.Models.Rent
{
    public class RentBook
    {
        public Guid BookId { get; set; }
        public DateTime RentTime { get; set; }


        public RentBook(Guid bookId, DateTime rentTime) {
            BookId = bookId;
            RentTime = rentTime;
        }
    }
}
