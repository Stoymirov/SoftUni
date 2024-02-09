using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log.Core.Enums;
using Log.Core.Layout.Interfaces;
using Log.Core.Models;

namespace Log.Core.Appenders.Interfaces
{
    public interface IAppender
    {
        ILayOut Layout { get; }
        ReportLevel ReportLevel { get; set; }

        public int MessageAppended { get; }
        void Append(Message message);
    }
}
