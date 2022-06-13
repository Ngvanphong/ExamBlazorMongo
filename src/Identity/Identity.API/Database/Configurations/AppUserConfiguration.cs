using Identity.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Identity.API.Database.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x=>x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(50);
        }
    }
}