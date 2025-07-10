using Booksy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Booksy.Data.Common.EntityConstants.Ganre;

namespace Booksy.Data.Configurations
{
    public class GanreConfiguration : IEntityTypeConfiguration<Ganre>
    {
        public void Configure(EntityTypeBuilder<Ganre> entity)
        {
           entity
                .HasKey(g => g.Id);

            entity
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);
        }
    }
}
