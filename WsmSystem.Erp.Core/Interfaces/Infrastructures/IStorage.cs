using WsmSystem.Erp.Core.Entities;

namespace WsmSystem.Erp.Core.Interfaces.Infrastructures;

public interface IStorage
{
    DbContext Instance { get; }

    public virtual DbSet<ApplicationInfo> ApplicationInfos
    {
        get;
        set;
    }

    public virtual DbSet<BaseLanguage> BaseLanguages
    {
        get;
        set;
    }

    public virtual DbSet<ClientInfo> ClientInfos
    {
        get;
        set;
    }

    public virtual DbSet<PhraseTag> PhraseTags
    {
        get;
        set;
    }

    public virtual DbSet<PhraseTagTranslation> PhraseTagTranslations
    {
        get;
        set;
    }

    public virtual DbSet<ItemCategory> ItemCategories
    {
        get;
        set;
    }

    public virtual DbSet<ItemGroup> ItemGroups
    {
        get;
        set;
    }

    public virtual DbSet<ItemGroupTranslation> ItemGroupTranslations
    {
        get;
        set;
    }

    public virtual DbSet<ItemMaster> ItemMasters
    {
        get;
        set;
    }

    public virtual DbSet<Uom> Uoms
    {
        get;
        set;
    }
}