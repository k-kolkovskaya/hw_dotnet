using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


namespace HW11
{
    public static class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger(typeof(Logger));

        public static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            FileInfo fileInfo = new FileInfo("App.config");
            XmlConfigurator.Configure(logRepository, fileInfo);
        }
    }
}
