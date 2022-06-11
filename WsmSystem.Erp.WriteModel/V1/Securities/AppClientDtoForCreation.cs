using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsmSystem.Erp.WriteModel.V1.Securities
{
    public class AppClientDtoForCreation
    {
        public virtual int Id { get; private set; }

        public virtual string? AppClientName { get; private set; }

        public virtual string? ApplicationKey { get; private set; }

        public virtual DateTime? ExpireDate { get; private set; }
    }
}
