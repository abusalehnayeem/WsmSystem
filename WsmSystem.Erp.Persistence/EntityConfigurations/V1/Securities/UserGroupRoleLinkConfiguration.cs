namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class UserGroupRoleLinkConfiguration : BaseEntityConfiguration<UserGroupRoleLink>
    {
        public override void Configure(EntityTypeBuilder<UserGroupRoleLink> builder)
        {
            builder.ToTable(@"UserGroupRoleLink", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserGroup).HasColumnName(@"IdUserGroup").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdUserRole).HasColumnName(@"IdUserRole").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"IdClient", @"Id");
            base.Configure(builder);
        }
    }
}