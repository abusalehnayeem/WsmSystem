﻿using WsmSystem.Erp.Core.Interfaces.Infrastructures;

namespace WsmSystem.Erp.Infrastructure.Data
{
    public partial class Storage : DbContext, IStorage
    {
        public DbContext Instance => this;
    }
}
