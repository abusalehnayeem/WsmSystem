namespace WsmSystem.Erp.Domain.Interfaces
{
    public interface IRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
    }
}
