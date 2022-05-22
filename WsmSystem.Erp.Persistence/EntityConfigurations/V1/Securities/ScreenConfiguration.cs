using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class ScreenConfiguration : IEntityTypeConfiguration<Screen>
    {
        public void Configure(EntityTypeBuilder<Screen> builder)
        {
            builder.ToTable(@"Screen", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.ScreenCode).HasColumnName(@"ScreenCode").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.ScreenName).HasColumnName(@"ScreenName").HasColumnType(@"nvarchar(100)").IsRequired().ValueGeneratedNever().HasMaxLength(100);
            builder.Property(x => x.IdModule).HasColumnName(@"IdModule").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdSubModule).HasColumnName(@"IdSubModule").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdSubModuleSection).HasColumnName(@"IdSubModuleSection").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType(@"smallint").ValueGeneratedNever().HasPrecision(5, 0);
            builder.Property(x => x.ScreenUri).HasColumnName(@"ScreenUri").HasColumnType(@"nvarchar(max)").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ScreenDescription).HasColumnName(@"ScreenDescription").HasColumnType(@"nvarchar(max)").ValueGeneratedNever();
            builder.Property(x => x.IsRequiredForApproval).HasColumnName(@"IsRequiredForApproval").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IsFinancialScreen).HasColumnName(@"IsFinancialScreen").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IconName).HasColumnName(@"IconName").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
            builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.HasKey(@"IdClient", @"ScreenCode");
        }
    }
}