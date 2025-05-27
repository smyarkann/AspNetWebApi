using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ILoggerService
    {
        void LogInfo(string messsage);
        void LogWarning(string messsage);
        void LogError(string messsage);
        void LogDebug(string messsage);

    }
}
