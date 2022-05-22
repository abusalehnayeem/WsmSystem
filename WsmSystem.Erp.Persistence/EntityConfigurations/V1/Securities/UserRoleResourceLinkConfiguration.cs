using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class UserRoleResourceLinkConfiguration : IEntityTypeConfiguration<UserRoleResourceLink>
    {
        public void Configure(EntityTypeBuilder<UserRoleResourceLink> builder)
        {
            builder.ToTable(@"UserRoleResourceLink", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserResource).HasColumnName(@"IdUserResource").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserRole).HasColumnName(@"IdUserRole").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.HasKey(@"IdClient", @"Id");

        }
    }
}