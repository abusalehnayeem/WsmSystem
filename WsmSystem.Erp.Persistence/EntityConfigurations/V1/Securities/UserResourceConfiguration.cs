namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class UserResourceConfiguration : BaseEntityConfiguration<UserResource>
    {
        public override void Configure(EntityTypeBuilder<UserResource> builder)
        {
            builder.ToTable(@"UserResource", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.ApiUrl).HasColumnName(@"ApiUrl").HasColumnType(@"nvarchar(max)").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.IdHttpMethod).HasColumnName(@"IdHttpMethod").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"IdClient", @"Id");
            base.Configure(builder);
        }
    }
}
