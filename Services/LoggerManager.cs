using NLog;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoggerManager : ILoggerService
    {
        private static ILogger logger= LogManager.GetCurrentClassLogger();

        public void LogDebug(string messsage) => logger.Debug(messsage);

        public void LogError(string messsage)=> logger.Error(messsage);

        public void LogInfo(string messsage) => logger.Info(messsage);

        public void LogWarning(string messsage) => logger.Warn(messsage);
    }
}
