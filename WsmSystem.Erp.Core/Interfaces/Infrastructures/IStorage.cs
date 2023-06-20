namespace WsmSystem.Erp.Core.Interfaces.Infrastructures;

public interface IStorage
{
    DbContext Instance { get; }
}