namespace Booksy.Data.Models
{
    public class OrderBook
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;

        public Guid BookId { get; set; }
        public virtual Book Book { get; set; } = null!;

    }
}
