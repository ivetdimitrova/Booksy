using Booksy.Data.Models;
using static Booksy.Data.Common.EntityConstants.Book;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity
                .HasKey(b => b.Id);

            entity
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            entity
                .Property(b => b.ISBN)
                .IsRequired()
                .HasMaxLength(ISBNMaxLength);

            entity
                .Property(b => b.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            entity
                .Property(b => b.Description)
                .IsRequired();

        }
    }
}
