using Microsoft.AspNetCore.Identity;

namespace Booksy.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string UserId { get; set; } = null!;
        public virtual ApplicationUser User { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public bool IsItTaken { get; set; } = false;
        public int Quantity { get; set; }

        public string? Description { get; set; } 

        public virtual ICollection<OrderBook> Books { get; set; }
        = new HashSet<OrderBook>();
    }
}
