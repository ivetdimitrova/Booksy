using Booksy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class BookGanreConfiguration : IEntityTypeConfiguration<BookGanre>
    {
        public void Configure(EntityTypeBuilder<BookGanre> entity)
        {
            entity
                 .HasKey(bg => new
                 {
                     bg.BookId,
                     bg.GanreId
                 });

            entity
                .HasOne(bg => bg.Ganre)
                .WithMany(g => g.Books)
                .HasForeignKey(bg => bg.GanreId);


            entity
                .HasOne(bg => bg.Book)
                .WithMany(b => b.Ganres)
                .HasForeignKey(bg => bg.BookId);
        }
    }
}
