using Booksy.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity
                .HasKey(o => o.Id);

            entity
                .Property(o => o.IsItTaken)
                .IsRequired()
                .HasDefaultValue(false);

            entity
                .Property(o => o.Description)
                .IsRequired(false);

            entity
                .HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.UserId);

        }
    }
}
