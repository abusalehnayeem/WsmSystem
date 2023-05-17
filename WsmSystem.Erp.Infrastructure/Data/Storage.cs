namespace WsmSystem.Erp.Infrastructure.Data
{
    public partial class Storage : IStorage
    {
        public DbContext Instance => this;
    }
}
