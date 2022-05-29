namespace WsmSystem.Erp.Persistence.EntityConfigurations.V1.Securities
{
    public class SubModuleSectionConfiguration : BaseEntityConfiguration<SubModuleSection>
    {
        public override void Configure(EntityTypeBuilder<SubModuleSection> builder)
        {
            builder.ToTable(@"SubModuleSection", @"securities");
            builder.Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdModule).HasColumnName(@"IdModule").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.IdSubModule).HasColumnName(@"IdSubModule").HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
            builder.Property(x => x.SectionName).HasColumnName(@"SectionName").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.IconName).HasColumnName(@"IconName").HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
            builder.Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
            builder.HasKey(@"IdClient", @"Id", @"IdModule", @"IdSubModule");
            base.Configure(builder);
        }
    }
}