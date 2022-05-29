namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class SecurityPolicyConfiguration : BaseEntityConfiguration<SecurityPolicy>
    {
        public override void Configure(EntityTypeBuilder<SecurityPolicy> builder)
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
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"Id", @"IdClient");
            base.Configure(builder);
        }
    }
}