using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log.Core.Enums;
using Log.Core.Exceptions;
using Log.Core.Utils;

namespace Log.Core.Models
{
    public class Message
    {
        //TODO Validations
        private string createdTime;
        private string text;
        public Message(string createdTime,string text,ReportLevel reportLevel)
        {
            CreatedTime=createdTime;
            Text=text;
            ReportLevel=reportLevel;
        }
        public string CreatedTime
        {
            get => createdTime;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeException();
                }

                if (!DateTimeValidator.ValidateDateTimeFormat(value))
                {
                    throw new InvalidDateTimeFormatException();
                }
                createdTime = value;
            }
        }

        public string Text
        {
            get => text;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTextException();
                }

                text = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }
    }
}
