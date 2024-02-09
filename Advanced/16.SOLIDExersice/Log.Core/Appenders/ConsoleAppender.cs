using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log.Core.Appenders.Interfaces;
using Log.Core.Enums;
using Log.Core.Layout.Interfaces;
using Log.Core.Models;

namespace Log.Core.Appenders
{
    public class ConsoleAppender:IAppender
    {
        //TODO Add layout
        public ConsoleAppender(ILayOut layout,ReportLevel reportLevel = ReportLevel.Info)
        {
            ReportLevel = reportLevel;
            Layout = layout;
        }

        public ILayOut Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public int MessageAppended { get; private set; }
        public void Append(Message message)
        {
            Console.WriteLine(string.Format(Layout.Format,message.CreatedTime,message.ReportLevel,message.Text));
            MessageAppended++;
        }
    }
}
