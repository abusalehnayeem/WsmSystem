using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerService
{
    public interface ILoggerService
    {
        void LogInformation(LoggerLevel eventLevel, string information, Exception ex = null, params object[] values);
    }
}
