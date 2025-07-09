namespace Booksy.Data.Models
{
    public class AuthorBook
    {
        public Guid AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; } = null!;
    }
}
