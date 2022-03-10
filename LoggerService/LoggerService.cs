using Serilog.Events;

namespace LoggerService
{
    internal class LoggerService : ILoggerService
    {
        public void LogInformation(LoggerLevel eventLevel, string information, Exception? ex = null, params object[] values)
        {
            throw new NotImplementedException();
        }
    }
}