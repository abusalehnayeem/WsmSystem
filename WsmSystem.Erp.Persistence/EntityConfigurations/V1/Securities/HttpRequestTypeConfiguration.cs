namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class HttpRequestTypeConfiguration : BaseEntityConfiguration<HttpRequestType>
    {
        public override void Configure(EntityTypeBuilder<HttpRequestType> builder)
        {
            builder.ToTable(@"HttpRequestType", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.HttpMethodType).HasColumnName(@"HttpMethodType").HasColumnType(@"nvarchar(10)").IsRequired().ValueGeneratedNever().HasMaxLength(10);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"IdClient", @"Id");
            base.Configure(builder);
        }
    }
}
