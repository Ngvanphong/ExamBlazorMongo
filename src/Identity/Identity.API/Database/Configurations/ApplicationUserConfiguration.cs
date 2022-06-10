using Identity.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.API.Database.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x=>x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(50);
        }
    }
}