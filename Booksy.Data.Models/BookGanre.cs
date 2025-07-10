namespace Booksy.Data.Models
{
    public class BookGanre
    {
        public Guid BookId { get; set; }
        public Book Book { get; set; } = null!;

        public Guid GanreId { get; set; }
        public Ganre Ganre { get; set; } = null!;
    }
}
