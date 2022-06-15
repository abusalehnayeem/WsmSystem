using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsmSystem.Erp.ReadModel.V1.Securities
{
    public class ClientInfoDto
    {
        public int Id { get; set; }

        public int IdAppClient { get; set; }

        public string? CompanyName { get; set; }

        public string? CompanyEmail { get; set; }

        public string? CompanyUrl { get; set; }

        public string? CompanyAddress { get; set; }

        public string? LogoUrl { get; set; }

        public string? AppClientName { get; set; }
    }
}
