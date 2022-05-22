using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WsmSystem.Erp.Domain.Entities.V1.Securities;

namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class SecurityPolicyConfiguration : IEntityTypeConfiguration<SecurityPolicy>
    {
        public void Configure(EntityTypeBuilder<SecurityPolicy> builder)
        {
            builder.ToTable(@"SecurityPolicy", @"securities");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.MaximumWrongLoginTry).HasColumnName(@"MaximumWrongLoginTry").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.MinimumPasswordLength).HasColumnName(@"MinimumPasswordLength").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.PasswordAttemptWindow).HasColumnName(@"PasswordAttemptWindow").HasColumnType(@"int").ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.UserOnlineTimeWindow).HasColumnName(@"UserOnlineTimeWindow").HasColumnType(@"int").ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IsAlphaNumericPasswordRequired).HasColumnName(@"IsAlphaNumericPasswordRequired").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IsPasswordSaltRequired).HasColumnName(@"IsPasswordSaltRequired").HasColumnType(@"bit").ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IsPasswordStrengthRequired).HasColumnName(@"IsPasswordStrengthRequired").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IsUniqueEmailRequired).HasColumnName(@"IsUniqueEmailRequired").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"0");
            builder.Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
            builder.Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.HasKey(@"Id", @"IdClient");
        }
    }
}