namespace WsmSystem.Erp.Core.Entities.Core;

public sealed class BaseLanguage
{
    public BaseLanguage()
    {
        IdAuthorizationStatus = @"N";
        PhraseTagTranslations = new List<PhraseTagTranslation>();
    }

    public int IdClient { get; set; }

    public int Id { get; set; }

    public string DescriptionDetail { get; set; }

    public string DescriptionShort { get; set; }

    public bool IsActive { get; set; }

    public string IdAuthorizationStatus { get; set; }

    public string LastAction { get; set; }

    public string MakeBy { get; set; }

    public DateTime MakeDate { get; set; }

    public string UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public IList<PhraseTagTranslation> PhraseTagTranslations { get; set; }
}