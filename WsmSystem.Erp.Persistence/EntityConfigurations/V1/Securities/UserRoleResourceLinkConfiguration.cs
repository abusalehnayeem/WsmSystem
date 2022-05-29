namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class UserRoleResourceLinkConfiguration : BaseEntityConfiguration<UserRoleResourceLink>
    {
        public override void Configure(EntityTypeBuilder<UserRoleResourceLink> builder)
        {
            builder.ToTable(@"UserRoleResourceLink", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserResource).HasColumnName(@"IdUserResource").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserRole).HasColumnName(@"IdUserRole").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"IdClient", @"Id");
            base.Configure(builder);
        }
    }
}