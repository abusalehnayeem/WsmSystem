namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class ClientInfoConfiguration : BaseEntityConfiguration<ClientInfo>
    {
        public override void Configure(EntityTypeBuilder<ClientInfo> builder)
        {
            builder.ToTable(@"ClientInfo", @"securities");
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdAppClient).HasColumnName(@"IdAppClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType(@"nvarchar(300)").ValueGeneratedNever().HasMaxLength(300);
            builder.Property(x => x.CompanyEmail).HasColumnName(@"CompanyEmail").HasColumnType(@"nvarchar(200)").ValueGeneratedNever().HasMaxLength(200);
            builder.Property(x => x.CompanyUrl).HasColumnName(@"CompanyUrl").HasColumnType(@"nvarchar(max)").ValueGeneratedNever();
            builder.Property(x => x.CompanyAddress).HasColumnName(@"CompanyAddress").HasColumnType(@"nvarchar(max)").ValueGeneratedNever();
            builder.Property(x => x.LogoUrl).HasColumnName(@"LogoUrl").HasColumnType(@"nvarchar(100)").ValueGeneratedNever().HasMaxLength(100);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"Id");
            base.Configure(builder);
        }
    }
}
