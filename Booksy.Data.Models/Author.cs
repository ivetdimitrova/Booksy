namespace Booksy.Data.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Biography { get; set; }
        public virtual ICollection<AuthorBook> Books { get; set; }
         = new HashSet<AuthorBook>();
    }
}
