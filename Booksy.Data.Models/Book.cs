namespace Booksy.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<AuthorBook> Authors { get; set; }
            = new HashSet<AuthorBook>();

        public virtual ICollection<OrderBook> Orders { get; set; }
           = new HashSet<OrderBook>();

    }
}
