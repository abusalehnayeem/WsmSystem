using Serilog.Events;

namespace LoggerService
{
    internal class LoggerService : ILoggerService
    {
        public void LogInformation(LoggerLevel eventLevel, string information, Exception? ex = null, params object[] values)
        {
            //return Serilog.Log.Write(eventLevel, JsonConvert.SerializeObject(message));
        }
    }
}