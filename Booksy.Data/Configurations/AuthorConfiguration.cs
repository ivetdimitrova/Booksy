using Booksy.Data.Models;
using static Booksy.Data.Common.EntityConstants.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity
                .HasKey(a => a.Id);

            entity
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            entity
                .Property(a => a.Biography)
                .IsRequired(false);
        }
    }
}
