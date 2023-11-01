using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WsmSystem.Erp.Local.Entities;

namespace WsmSystem.Erp.Local.DbContext;

public partial class Storage : Microsoft.EntityFrameworkCore.DbContext
{
    public Storage()
    {
        OnCreated();
    }

    public Storage(DbContextOptions<Storage> options) :
        base(options)
    {
        OnCreated();
    }

    public virtual DbSet<ApplicationInfo> ApplicationInfos { get; set; }

    public virtual DbSet<BaseLanguage> BaseLanguages { get; set; }

    public virtual DbSet<ClientInfo> ClientInfos { get; set; }

    public virtual DbSet<PhraseTag> PhraseTags { get; set; }

    public virtual DbSet<PhraseTagTranslation> PhraseTagTranslations { get; set; }

    public virtual DbSet<ItemCategory> ItemCategories { get; set; }

    public virtual DbSet<ItemGroup> ItemGroups { get; set; }

    public virtual DbSet<ItemGroupTranslation> ItemGroupTranslations { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<Uom> Uoms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured ||
            (!optionsBuilder.Options.Extensions.OfType<RelationalOptionsExtension>().Any(ext =>
                 !string.IsNullOrEmpty(ext.ConnectionString) || ext.Connection != null) &&
             !optionsBuilder.Options.Extensions.Any(ext =>
                 !(ext is RelationalOptionsExtension) && !(ext is CoreOptionsExtension))))
            optionsBuilder.UseSqlServer(
                @"Data Source=127.0.0.1\sqlexpress;Initial Catalog=WSMSYSTEM;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=Sa@123456");
        CustomizeConfiguration(ref optionsBuilder);
        base.OnConfiguring(optionsBuilder);
    }

    partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ApplicationInfoMapping(modelBuilder);
        CustomizeApplicationInfoMapping(modelBuilder);

        BaseLanguageMapping(modelBuilder);
        CustomizeBaseLanguageMapping(modelBuilder);

        ClientInfoMapping(modelBuilder);
        CustomizeClientInfoMapping(modelBuilder);

        PhraseTagMapping(modelBuilder);
        CustomizePhraseTagMapping(modelBuilder);

        PhraseTagTranslationMapping(modelBuilder);
        CustomizePhraseTagTranslationMapping(modelBuilder);

        ItemCategoryMapping(modelBuilder);
        CustomizeItemCategoryMapping(modelBuilder);

        ItemGroupMapping(modelBuilder);
        CustomizeItemGroupMapping(modelBuilder);

        ItemGroupTranslationMapping(modelBuilder);
        CustomizeItemGroupTranslationMapping(modelBuilder);

        ItemMasterMapping(modelBuilder);
        CustomizeItemMasterMapping(modelBuilder);

        UomMapping(modelBuilder);
        CustomizeUomMapping(modelBuilder);

        RelationshipsMapping(modelBuilder);
        CustomizeMapping(ref modelBuilder);
    }

    private void RelationshipsMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationInfo>().HasMany(x => x.ClientInfos).WithOne(op => op.ApplicationInfo)
            .HasForeignKey(@"IdApplicationInfo").IsRequired();

        modelBuilder.Entity<BaseLanguage>().HasMany(x => x.PhraseTagTranslations).WithOne(op => op.BaseLanguage)
            .HasForeignKey(@"IdClient", @"IdLanguage").IsRequired();
        modelBuilder.Entity<BaseLanguage>().HasMany(x => x.ItemGroupTranslations).WithOne(op => op.BaseLanguage)
            .HasForeignKey(@"IdClient", @"IdLanguage").IsRequired();

        modelBuilder.Entity<ClientInfo>().HasOne(x => x.ApplicationInfo).WithMany(op => op.ClientInfos)
            .HasForeignKey(@"IdApplicationInfo").IsRequired();

        modelBuilder.Entity<PhraseTag>().HasMany(x => x.PhraseTagTranslations).WithOne(op => op.PhraseTag)
            .HasForeignKey(@"IdClient", @"IdPhraseTag").IsRequired();

        modelBuilder.Entity<PhraseTagTranslation>().HasOne(x => x.PhraseTag).WithMany(op => op.PhraseTagTranslations)
            .HasForeignKey(@"IdClient", @"IdPhraseTag").IsRequired();
        modelBuilder.Entity<PhraseTagTranslation>().HasOne(x => x.BaseLanguage).WithMany(op => op.PhraseTagTranslations)
            .HasForeignKey(@"IdClient", @"IdLanguage").IsRequired();

        modelBuilder.Entity<ItemGroup>().HasMany(x => x.ItemGroupTranslations).WithOne(op => op.ItemGroup)
            .HasForeignKey(@"IdClient", @"IdItemGroup").IsRequired();

        modelBuilder.Entity<ItemGroupTranslation>().HasOne(x => x.ItemGroup).WithMany(op => op.ItemGroupTranslations)
            .HasForeignKey(@"IdClient", @"IdItemGroup").IsRequired();
        modelBuilder.Entity<ItemGroupTranslation>().HasOne(x => x.BaseLanguage).WithMany(op => op.ItemGroupTranslations)
            .HasForeignKey(@"IdClient", @"IdLanguage").IsRequired();
    }

    partial void CustomizeMapping(ref ModelBuilder modelBuilder);

    public bool HasChanges()
    {
        return ChangeTracker.Entries().Any(e =>
            e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted);
    }

    partial void OnCreated();

    #region ApplicationInfo Mapping

    private void ApplicationInfoMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationInfo>().ToTable(@"ApplicationInfo", @"core");
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int")
            .IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.ApplicationName).HasColumnName(@"ApplicationName")
            .HasColumnType(@"nvarchar(150)").IsRequired().ValueGeneratedNever().HasMaxLength(150);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.ApplicationKey).HasColumnName(@"ApplicationKey")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.ExpireDate).HasColumnName(@"ExpireDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.IsActive).HasColumnName(@"IsActive")
            .HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.IdAuthorizationStatus)
            .HasColumnName(@"IdAuthorizationStatus").HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever()
            .HasMaxLength(1).HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"nvarchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.MakeBy).HasColumnName(@"MakeBy")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ApplicationInfo>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<ApplicationInfo>().HasKey(@"Id");
    }

    partial void CustomizeApplicationInfoMapping(ModelBuilder modelBuilder);

    #endregion

    #region BaseLanguage Mapping

    private void BaseLanguageMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseLanguage>().ToTable(@"BaseLanguage", @"core");
        modelBuilder.Entity<BaseLanguage>().Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int")
            .IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired()
            .ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.DescriptionDetail).HasColumnName(@"DescriptionDetail")
            .HasColumnType(@"nvarchar(30)").ValueGeneratedNever().HasMaxLength(30);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.DescriptionShort).HasColumnName(@"DescriptionShort")
            .HasColumnType(@"nvarchar(5)").ValueGeneratedNever().HasMaxLength(5);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit")
            .IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<BaseLanguage>().Property(x => x.IdAuthorizationStatus)
            .HasColumnName(@"IdAuthorizationStatus").HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever()
            .HasMaxLength(1).HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<BaseLanguage>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.MakeBy).HasColumnName(@"MakeBy")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<BaseLanguage>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<BaseLanguage>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<BaseLanguage>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizeBaseLanguageMapping(ModelBuilder modelBuilder);

    #endregion

    #region ClientInfo Mapping

    private void ClientInfoMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientInfo>().ToTable(@"ClientInfo", @"core");
        modelBuilder.Entity<ClientInfo>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired()
            .ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<ClientInfo>().Property(x => x.IdApplicationInfo).HasColumnName(@"IdApplicationInfo")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<ClientInfo>().Property(x => x.CompanyName).HasColumnName(@"CompanyName")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ClientInfo>().Property(x => x.CompanyEmail).HasColumnName(@"CompanyEmail")
            .HasColumnType(@"varchar(200)").ValueGeneratedNever().HasMaxLength(200);
        modelBuilder.Entity<ClientInfo>().Property(x => x.CompanyUrl).HasColumnName(@"CompanyUrl")
            .HasColumnType(@"varchar(150)").ValueGeneratedNever().HasMaxLength(150);
        modelBuilder.Entity<ClientInfo>().Property(x => x.CompanyAddress).HasColumnName(@"CompanyAddress")
            .HasColumnType(@"varchar(250)").ValueGeneratedNever().HasMaxLength(250);
        modelBuilder.Entity<ClientInfo>().Property(x => x.LogoUrl).HasColumnName(@"LogoUrl")
            .HasColumnType(@"varchar(100)").ValueGeneratedNever().HasMaxLength(100);
        modelBuilder.Entity<ClientInfo>().Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit")
            .IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ClientInfo>().Property(x => x.IdAuthorizationStatus).HasColumnName(@"IdAuthorizationStatus")
            .HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever().HasMaxLength(1)
            .HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<ClientInfo>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"varchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3);
        modelBuilder.Entity<ClientInfo>().Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"varchar(50)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ClientInfo>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<ClientInfo>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"varchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ClientInfo>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<ClientInfo>().Property(x => x.IsDefault).HasColumnName(@"IsDefault").HasColumnType(@"bit")
            .ValueGeneratedNever();
        modelBuilder.Entity<ClientInfo>().HasKey(@"Id");
    }

    partial void CustomizeClientInfoMapping(ModelBuilder modelBuilder);

    #endregion

    #region PhraseTag Mapping

    private void PhraseTagMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PhraseTag>().ToTable(@"PhraseTag", @"core");
        modelBuilder.Entity<PhraseTag>().Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int")
            .IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTag>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired()
            .ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTag>().Property(x => x.PhraseName).HasColumnName(@"PhraseName")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTag>().Property(x => x.UsageIn).HasColumnName(@"UsageIn")
            .HasColumnType(@"nvarchar(500)").ValueGeneratedNever().HasMaxLength(500);
        modelBuilder.Entity<PhraseTag>().Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit")
            .IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<PhraseTag>().Property(x => x.IdAuthorizationStatus).HasColumnName(@"IdAuthorizationStatus")
            .HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever().HasMaxLength(1)
            .HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<PhraseTag>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTag>().Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTag>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<PhraseTag>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTag>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<PhraseTag>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizePhraseTagMapping(ModelBuilder modelBuilder);

    #endregion

    #region PhraseTagTranslation Mapping

    private void PhraseTagTranslationMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PhraseTagTranslation>().ToTable(@"PhraseTagTranslation", @"core");
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.IdClient).HasColumnName(@"IdClient")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int")
            .IsRequired().ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.IdPhraseTag).HasColumnName(@"IdPhraseTag")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.IdLanguage).HasColumnName(@"IdLanguage")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.Expression).HasColumnName(@"Expression")
            .HasColumnType(@"nvarchar(250)").ValueGeneratedNever().HasMaxLength(250);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.IsActive).HasColumnName(@"IsActive")
            .HasColumnType(@"bit").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.IdAuthorizationStatus)
            .HasColumnName(@"IdAuthorizationStatus").HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever()
            .HasMaxLength(1).HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.MakeBy).HasColumnName(@"MakeBy")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedNever();
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<PhraseTagTranslation>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<PhraseTagTranslation>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizePhraseTagTranslationMapping(ModelBuilder modelBuilder);

    #endregion

    #region ItemCategory Mapping

    private void ItemCategoryMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemCategory>().HasNoKey();
        modelBuilder.Entity<ItemCategory>().ToView(@"ItemCategory", @"productmanagement");
        modelBuilder.Entity<ItemCategory>().Property(x => x.SystemItemCategoryID).HasColumnName(@"SystemItemCategoryID")
            .HasColumnType(@"varchar(20)").IsRequired().ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemCategory>().Property(x => x.ItemProductID).HasColumnName(@"ItemProductID")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemCategory>().Property(x => x.ItemCategoryID).HasColumnName(@"ItemCategoryID")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemCategory>().Property(x => x.EItemCategoryDesc).HasColumnName(@"EItemCategoryDesc")
            .HasColumnType(@"varchar(100)").ValueGeneratedNever().HasMaxLength(100);
        modelBuilder.Entity<ItemCategory>().Property(x => x.PItemCategoryDesc).HasColumnName(@"PItemCategoryDesc")
            .HasColumnType(@"varchar(100)").ValueGeneratedNever().HasMaxLength(100);
        modelBuilder.Entity<ItemCategory>().Property(x => x.ItemCategoryShortCode)
            .HasColumnName(@"ItemCategoryShortCode").HasColumnType(@"varchar(20)").ValueGeneratedNever()
            .HasMaxLength(20);
    }

    partial void CustomizeItemCategoryMapping(ModelBuilder modelBuilder);

    #endregion

    #region ItemGroup Mapping

    private void ItemGroupMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemGroup>().ToTable(@"ItemGroup", @"productmanagement");
        modelBuilder.Entity<ItemGroup>().Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int")
            .IsRequired().ValueGeneratedNever().HasPrecision(10, 0).HasDefaultValueSql(@"10001001");
        modelBuilder.Entity<ItemGroup>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired()
            .ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<ItemGroup>().Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit")
            .IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
        modelBuilder.Entity<ItemGroup>().Property(x => x.IdAuthorizationStatus).HasColumnName(@"IdAuthorizationStatus")
            .HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever().HasMaxLength(1)
            .HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<ItemGroup>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"varchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3)
            .HasDefaultValueSql(@"'ADD'");
        modelBuilder.Entity<ItemGroup>().Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(50).HasDefaultValueSql(@"'admin@hana-ltd.com'");
        modelBuilder.Entity<ItemGroup>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
        modelBuilder.Entity<ItemGroup>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ItemGroup>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<ItemGroup>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizeItemGroupMapping(ModelBuilder modelBuilder);

    #endregion

    #region ItemGroupTranslation Mapping

    private void ItemGroupTranslationMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemGroupTranslation>().ToTable(@"ItemGroupTranslation", @"productmanagement");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.IdClient).HasColumnName(@"IdClient")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0)
            .HasDefaultValueSql(@"10001001");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int")
            .IsRequired().ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.IdItemGroup).HasColumnName(@"IdItemGroup")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.IdLanguage).HasColumnName(@"IdLanguage")
            .HasColumnType(@"int").IsRequired().ValueGeneratedNever().HasPrecision(10, 0);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.ItemGroupDesc).HasColumnName(@"ItemGroupDesc")
            .HasColumnType(@"nvarchar(250)").ValueGeneratedNever().HasMaxLength(250);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.ItemGroupShortCode)
            .HasColumnName(@"ItemGroupShortCode").HasColumnType(@"nvarchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.IsActive).HasColumnName(@"IsActive")
            .HasColumnType(@"bit").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.IdAuthorizationStatus)
            .HasColumnName(@"IdAuthorizationStatus").HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever()
            .HasMaxLength(1).HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.LastAction).HasColumnName(@"LastAction")
            .HasColumnType(@"varchar(3)").IsRequired().ValueGeneratedNever().HasMaxLength(3)
            .HasDefaultValueSql(@"'ADD'");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.MakeBy).HasColumnName(@"MakeBy")
            .HasColumnType(@"nvarchar(50)").IsRequired().ValueGeneratedNever().HasMaxLength(50)
            .HasDefaultValueSql(@"'admin@hana-ltd.com'");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.MakeDate).HasColumnName(@"MakeDate")
            .HasColumnType(@"datetime2").IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ItemGroupTranslation>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate")
            .HasColumnType(@"datetime2").ValueGeneratedNever();
        modelBuilder.Entity<ItemGroupTranslation>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizeItemGroupTranslationMapping(ModelBuilder modelBuilder);

    #endregion

    #region ItemMaster Mapping

    private void ItemMasterMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemMaster>().HasNoKey();
        modelBuilder.Entity<ItemMaster>().ToView(@"ItemMaster", @"productmanagement");
        modelBuilder.Entity<ItemMaster>().Property(x => x.SystemItemID).HasColumnName(@"SystemItemID")
            .HasColumnType(@"varchar(20)").IsRequired().ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemMaster>().Property(x => x.NewItemCode).HasColumnName(@"NewItemCode")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemMaster>().Property(x => x.OldItemCode).HasColumnName(@"OldItemCode")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemMaster>().Property(x => x.SystemProductGroupID).HasColumnName(@"SystemProductGroupID")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemMaster>().Property(x => x.SystemItemCategoryID).HasColumnName(@"SystemItemCategoryID")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
        modelBuilder.Entity<ItemMaster>().Property(x => x.EItemDescription).HasColumnName(@"EItemDescription")
            .HasColumnType(@"varchar(500)").ValueGeneratedNever().HasMaxLength(500);
        modelBuilder.Entity<ItemMaster>().Property(x => x.PItemDescription).HasColumnName(@"PItemDescription")
            .HasColumnType(@"varchar(500)").ValueGeneratedNever().HasMaxLength(500);
        modelBuilder.Entity<ItemMaster>().Property(x => x.EShortItemDescription).HasColumnName(@"EShortItemDescription")
            .HasColumnType(@"varchar(100)").ValueGeneratedNever().HasMaxLength(100);
        modelBuilder.Entity<ItemMaster>().Property(x => x.PShortItemDescription).HasColumnName(@"PShortItemDescription")
            .HasColumnType(@"varchar(100)").ValueGeneratedNever().HasMaxLength(100);
        modelBuilder.Entity<ItemMaster>().Property(x => x.UOM).HasColumnName(@"UOM").HasColumnType(@"varchar(5)")
            .ValueGeneratedNever().HasMaxLength(5);
        modelBuilder.Entity<ItemMaster>().Property(x => x.QuantityPerPieceUnit).HasColumnName(@"QuantityPerPieceUnit")
            .HasColumnType(@"numeric(18,2)").ValueGeneratedNever().HasPrecision(18, 2);
        modelBuilder.Entity<ItemMaster>().Property(x => x.PieceUnitID).HasColumnName(@"PieceUnitID")
            .HasColumnType(@"varchar(5)").ValueGeneratedNever().HasMaxLength(5);
        modelBuilder.Entity<ItemMaster>().Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit")
            .HasColumnType(@"numeric(18,2)").ValueGeneratedNever().HasPrecision(18, 2);
        modelBuilder.Entity<ItemMaster>().Property(x => x.UnitID).HasColumnName(@"UnitID").HasColumnType(@"varchar(5)")
            .ValueGeneratedNever().HasMaxLength(5);
        modelBuilder.Entity<ItemMaster>().Property(x => x.SKURange).HasColumnName(@"SKURange")
            .HasColumnType(@"varchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ItemMaster>().Property(x => x.ItemSubType).HasColumnName(@"ItemSubType")
            .HasColumnType(@"varchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<ItemMaster>().Property(x => x.ReOrderLevel).HasColumnName(@"ReOrderLevel")
            .HasColumnType(@"numeric(18,2)").ValueGeneratedNever().HasPrecision(18, 2);
        modelBuilder.Entity<ItemMaster>().Property(x => x.MinSalesPrice).HasColumnName(@"MinSalesPrice")
            .HasColumnType(@"numeric(18,4)").ValueGeneratedNever().HasPrecision(18, 4);
        modelBuilder.Entity<ItemMaster>().Property(x => x.MaxSalesPrice).HasColumnName(@"MaxSalesPrice")
            .HasColumnType(@"numeric(18,4)").ValueGeneratedNever().HasPrecision(18, 4);
        modelBuilder.Entity<ItemMaster>().Property(x => x.TotalStockInHand).HasColumnName(@"TotalStockInHand")
            .HasColumnType(@"numeric(18,2)").ValueGeneratedNever().HasPrecision(18, 2);
        modelBuilder.Entity<ItemMaster>().Property(x => x.Remarks).HasColumnName(@"Remarks")
            .HasColumnType(@"varchar(500)").ValueGeneratedNever().HasMaxLength(500);
        modelBuilder.Entity<ItemMaster>().Property(x => x.IsMixItem).HasColumnName(@"IsMixItem").HasColumnType(@"bit")
            .ValueGeneratedNever();
        modelBuilder.Entity<ItemMaster>().Property(x => x.StdContFeet).HasColumnName(@"StdContFeet")
            .HasColumnType(@"varchar(10)").ValueGeneratedNever().HasMaxLength(10);
        modelBuilder.Entity<ItemMaster>().Property(x => x.StdContQty).HasColumnName(@"StdContQty")
            .HasColumnType(@"numeric(18)").ValueGeneratedNever().HasPrecision(18, 0);
        modelBuilder.Entity<ItemMaster>().Property(x => x.CapacityPercent).HasColumnName(@"CapacityPercent")
            .HasColumnType(@"numeric(18,2)").ValueGeneratedNever().HasPrecision(18, 2);
        modelBuilder.Entity<ItemMaster>().Property(x => x.ItemImage).HasColumnName(@"ItemImage").HasColumnType(@"image")
            .ValueGeneratedNever().HasMaxLength(2147483647);
        modelBuilder.Entity<ItemMaster>().Property(x => x.SecondarySystemItemID).HasColumnName(@"SecondarySystemItemID")
            .HasColumnType(@"varchar(20)").ValueGeneratedNever().HasMaxLength(20);
    }

    partial void CustomizeItemMasterMapping(ModelBuilder modelBuilder);

    #endregion

    #region Uom Mapping

    private void UomMapping(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Uom>().ToTable(@"Uom", @"productmanagement");
        modelBuilder.Entity<Uom>().Property(x => x.IdClient).HasColumnName(@"IdClient").HasColumnType(@"int")
            .IsRequired().ValueGeneratedNever().HasPrecision(10, 0).HasDefaultValueSql(@"10001001");
        modelBuilder.Entity<Uom>().Property(x => x.Id).HasColumnName(@"Id").HasColumnType(@"int").IsRequired()
            .ValueGeneratedOnAdd().HasPrecision(10, 0);
        modelBuilder.Entity<Uom>().Property(x => x.UnitName).HasColumnName(@"UnitName").HasColumnType(@"nvarchar(5)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(5);
        modelBuilder.Entity<Uom>().Property(x => x.UnitDescription).HasColumnName(@"UnitDescription")
            .HasColumnType(@"nvarchar(50)").ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<Uom>().Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType(@"bit")
            .IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"1");
        modelBuilder.Entity<Uom>().Property(x => x.IdAuthorizationStatus).HasColumnName(@"IdAuthorizationStatus")
            .HasColumnType(@"nvarchar(1)").IsRequired().ValueGeneratedNever().HasMaxLength(1)
            .HasDefaultValueSql(@"'N'");
        modelBuilder.Entity<Uom>().Property(x => x.LastAction).HasColumnName(@"LastAction").HasColumnType(@"varchar(3)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(3).HasDefaultValueSql(@"'ADD'");
        modelBuilder.Entity<Uom>().Property(x => x.MakeBy).HasColumnName(@"MakeBy").HasColumnType(@"nvarchar(50)")
            .IsRequired().ValueGeneratedNever().HasMaxLength(50).HasDefaultValueSql(@"'admin@hana-ltd.com'");
        modelBuilder.Entity<Uom>().Property(x => x.MakeDate).HasColumnName(@"MakeDate").HasColumnType(@"datetime2")
            .IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql(@"getdate()");
        modelBuilder.Entity<Uom>().Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType(@"nvarchar(50)")
            .ValueGeneratedNever().HasMaxLength(50);
        modelBuilder.Entity<Uom>().Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType(@"datetime2")
            .ValueGeneratedNever();
        modelBuilder.Entity<Uom>().HasKey(@"IdClient", @"Id");
    }

    partial void CustomizeUomMapping(ModelBuilder modelBuilder);

    #endregion
}