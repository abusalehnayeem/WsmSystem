namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class RoleWiseScreenPermissionConfiguration : BaseEntityConfiguration<RoleWiseScreenPermission>
    {
        public override void Configure(EntityTypeBuilder<RoleWiseScreenPermission> builder)
        {
            builder.ToTable(@"RoleWiseScreenPermission", @"securities");
            builder.Property(x => x.IdRole).HasColumnName(@"IdRole").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.ScreenCode).HasColumnName(@"ScreenCode").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.AccessRight).HasColumnName(@"AccessRight").HasColumnType(@"nvarchar(4)").ValueGeneratedNever().HasMaxLength(4);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
            builder.HasKey(@"IdRole", @"IdClient", @"ScreenCode");
            base.Configure(builder);
        }
    }
}
