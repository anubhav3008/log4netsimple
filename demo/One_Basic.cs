using log4net.Config;
using log4net;
using System.Reflection;

namespace demo
{
    public class One_Basic
    {
        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            ILog logger = LogManager.GetLogger(typeof(One_Basic));
            logger.Info("hello");
        }
    }
}