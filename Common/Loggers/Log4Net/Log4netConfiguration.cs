﻿using Common.Loggers.Log4Net;
using Microsoft.Extensions.Logging;

namespace Common.Loggers.Log4Net
{

    public static class Log4netExtensions
    {

        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, string log4NetConfigFile)
        {
            factory.AddProvider(new Log4NetProvider(log4NetConfigFile));
            return factory;
        }

        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory)
        {
            factory.AddProvider(new Log4NetProvider("log4net.config"));
            return factory;
        }

    }

}
