using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class RoleWiseScreenPermissionConfiguration : IEntityTypeConfiguration<RoleWiseScreenPermission>
    {
        public void Configure(EntityTypeBuilder<RoleWiseScreenPermission> builder)
        {
            builder.ToTable(@"RoleWiseScreenPermission", @"securities");
            builder.Property(x => x.IdRole).HasColumnName(@"IdRole").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.ScreenCode).HasColumnName(@"ScreenCode").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.AccessRight).HasColumnName(@"AccessRight").HasColumnType(@"nvarchar(4)").ValueGeneratedNever().HasMaxLength(4);
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
            builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.HasKey(@"IdRole", @"IdClient", @"ScreenCode");
        }
    }
}