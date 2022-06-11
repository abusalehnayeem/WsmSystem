namespace WsmSystem.Erp.ReadModel.V1.Securities
{
    public class AppClientDto
    {
        public virtual int Id { get; set; }

        public virtual string? AppClientName { get; set; }

        public virtual string? ApplicationKey { get; set; }

        public virtual DateTime? ExpireDate { get; set; }
    }
}
