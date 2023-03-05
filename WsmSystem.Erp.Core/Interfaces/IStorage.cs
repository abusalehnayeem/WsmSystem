namespace WsmSystem.Erp.Core.Interfaces
{
    public interface IStorage
    {
        DbContext Instance { get; }
    }
}
