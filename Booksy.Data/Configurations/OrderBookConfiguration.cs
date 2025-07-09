

using Booksy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class OrderBookConfiguration : IEntityTypeConfiguration<OrderBook>
    {
        public void Configure(EntityTypeBuilder<OrderBook> entity)
        {
            entity
                .HasKey(ob => new
                {
                    ob.OrderId,
                    ob.BookId
                });

            entity
                .HasOne(ob => ob.Order)
                .WithMany(o => o.Books)
                .HasForeignKey(ob => ob.OrderId);

            entity
               .HasOne(ob => ob.Book)
               .WithMany(b => b.Orders)
               .HasForeignKey(ob => ob.BookId);

        }
    }
}
