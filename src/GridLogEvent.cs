using System;

using Serilog.Events;

namespace Serilog.Sinks.WinForms
{
    public class GridLogEvent
    {
        public DateTimeOffset TimeStamp { get; set; }

        public LogEventLevel Level { get; set; }

        public string Message { get; set; }
    }
}