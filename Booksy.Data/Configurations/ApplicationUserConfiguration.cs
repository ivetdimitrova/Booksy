using Booksy.Data.Models;
using static Booksy.Data.Common.EntityConstants.ApplicationUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booksy.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> entity)
        {
            entity
                .Property(au => au.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            entity
              .Property(au => au.LastName)
              .IsRequired()
              .HasMaxLength(LastNameMaxLength);
        }
    }
}
