﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log.Core.Appenders;
using Log.Core.Appenders.Interfaces;
using Log.Core.Enums;
using Log.Core.Loggers.Interfaces;
using Log.Core.Models;

namespace Log.Core.Loggers
{
    public class Logger:ILogger
    {

        private readonly ICollection<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }
        public void Info(string dateTime, string message)
        {
            AppendAll(dateTime, message, ReportLevel.Info );
        }

        public void Warning(string dateTime, string message)
        {
            AppendAll(dateTime, message, ReportLevel.Warning);
        }

        public void Error(string dateTime, string message)
        {
            AppendAll(dateTime, message, ReportLevel.Error);
        }

        public void Critical(string dateTime, string message)
        {
            AppendAll(dateTime,message,ReportLevel.Critical);
        }

        public void Fatal(string dateTime, string message)
        {
            AppendAll(dateTime, message, ReportLevel.Fatal);
        }
    private void AppendAll(string dateTime, string text,ReportLevel reportLevel)
    {
        Message message = new(dateTime,text,reportLevel);
        foreach (var appender in appenders)
        {
            if (message.ReportLevel >= appender.ReportLevel)
            {
                appender.Append(message);
            }
        }
    }
    }
}
