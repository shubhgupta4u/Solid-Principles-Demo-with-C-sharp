using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.DIP.GoodExample
{
    public class LogService
    {
        private readonly ISinkProvider _provider;

        public LogService(ISinkProvider sinkProvider)
        {
            _provider = sinkProvider;
        }

        public void LogInfo(string message)
        {
            _provider.Log(message,LogLevel.Info);
        }
        public void LogWarning(string message)
        {
            _provider.Log(message, LogLevel.Warning);
        }
        public void LogTrace(string message)
        {
            _provider.Log(message, LogLevel.Trace);
        }
        public void LogError(Exception exception)
        {
            _provider.Log(exception.Message, LogLevel.Error);
        }
        public void LogDebug(string message)
        {
            _provider.Log(message, LogLevel.Debug);
        }
    }
}
