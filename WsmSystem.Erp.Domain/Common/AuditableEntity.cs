namespace WsmSystem.Erp.Domain.Common
{
    public class AuditableEntity
    {
        public string MakeBy { get; set; }
        public DateTime MakeDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}