namespace WsmSystem.Erp.Domain.Common
{
    public class BaseEntity
    {
        public virtual bool IsActive { get; set; }
        public virtual string MakeBy { get; set; } = null!;
        public virtual DateTime MakeDate { get; set; }
        public virtual string UpdateBy { get; set; } = null!;
        public virtual DateTime? UpdateDate { get; set; }
    }
}