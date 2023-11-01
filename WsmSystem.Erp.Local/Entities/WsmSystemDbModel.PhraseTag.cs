﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 9/5/2023 5:26:47 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace WsmSystem.Erp.Local.Entities
{
    public partial class PhraseTag {

        public PhraseTag()
        {
            this.IdAuthorizationStatus = @"N";
            this.PhraseTagTranslations = new List<PhraseTagTranslation>();
            OnCreated();
        }

        public int IdClient { get; set; }

        public int Id { get; set; }

        public string PhraseName { get; set; }

        public string UsageIn { get; set; }

        public bool IsActive { get; set; }

        public string IdAuthorizationStatus { get; set; }

        public string LastAction { get; set; }

        public string MakeBy { get; set; }

        public DateTime MakeDate { get; set; }

        public string UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual IList<PhraseTagTranslation> PhraseTagTranslations { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          PhraseTag toCompare = obj as PhraseTag;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IdClient, toCompare.IdClient))
            return false;
          if (!Object.Equals(this.Id, toCompare.Id))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IdClient.GetHashCode();
          hashCode = (hashCode * 7) + Id.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
