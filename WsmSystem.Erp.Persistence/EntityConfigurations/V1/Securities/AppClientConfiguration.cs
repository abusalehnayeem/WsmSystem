namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class AppClientConfiguration : BaseEntityConfiguration<AppClient>
    {
        public override void Configure(EntityTypeBuilder<AppClient> builder)
        {
            builder.ToTable(@"AppClient", @"securities");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.AppClientName).HasColumnName(@"AppClientName").HasColumnType(@"nvarchar(300)").IsRequired().ValueGeneratedNever().HasMaxLength(300);
            builder.Property(x => x.ApplicationKey).HasColumnName(@"ApplicationKey").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.ExpireDate).HasColumnName(@"ExpireDate").HasColumnType(@"datetime2").ValueGeneratedNever();
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"varchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"Id");
            base.Configure(builder);
        }
    }
}