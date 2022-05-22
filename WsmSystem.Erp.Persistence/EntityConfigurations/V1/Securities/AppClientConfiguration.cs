using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities;

public class AppClientConfiguration : IEntityTypeConfiguration<AppClient>
{
    public void Configure(EntityTypeBuilder<AppClient> builder)
    {
        builder.ToTable(@"AppClient", @"securities");
        builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        builder.Property(x => x.AppClientName).HasColumnName(@"AppClientName").HasColumnType(@"nvarchar(300)").IsRequired().ValueGeneratedNever().HasMaxLength(300);
        builder.Property(x => x.ApplicationKey).HasColumnName(@"ApplicationKey").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        builder.Property(x => x.ExpireDate).HasColumnName(@"ExpireDate").HasColumnType(@"datetime2").ValueGeneratedNever();
        builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
        builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"varchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
        builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
        builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
        builder.HasKey(@"Id");
    }
}
