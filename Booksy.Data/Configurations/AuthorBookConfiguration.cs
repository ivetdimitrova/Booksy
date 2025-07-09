using Booksy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksy.Data.Configurations
{
    public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> entity)
        {
            entity
                .HasKey(ab => new
                {
                    ab.AuthorId,
                    ab.BookId
                });

            entity
                .HasOne(ab => ab.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(ab => ab.AuthorId);

            entity
             .HasOne(ab => ab.Book)
             .WithMany(a => a.Authors)
             .HasForeignKey(ab => ab.BookId);
        }
    }
}
