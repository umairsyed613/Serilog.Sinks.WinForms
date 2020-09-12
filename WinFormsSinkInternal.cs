using System;
using System.IO;

using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Display;
using Serilog.Formatting.Json;

namespace Serilog.Sinks.WinForms
{
    public class WinFormsSinkInternal : ILogEventSink
    {
        public delegate void LogHandler(string str);

        public event LogHandler OnLogReceived;

        public delegate void GridLogHandler(GridLogEvent logEvent);

        public event GridLogHandler OnGridLogReceived;

        private ITextFormatter _textFormatter;

        private bool _isGridLogger;

        public WinFormsSinkInternal(ITextFormatter textFormatter, bool isGridLogger = false)
        {
            _textFormatter = textFormatter;
            _isGridLogger = isGridLogger;
        }

        public void Emit(LogEvent logEvent)
        {
            if (logEvent == null) throw new ArgumentNullException(nameof(logEvent));

            if (_textFormatter == null)
            {
                throw new ArgumentNullException("Missing Log Formatter");
            }

            var renderSpace = new StringWriter();
            _textFormatter.Format(logEvent, renderSpace);

            if (_isGridLogger)
            {
                OnGridLogReceived?.Invoke(new GridLogEvent
                                              {
                                                  Level = logEvent.Level,
                                                  TimeStamp = logEvent.Timestamp,
                                                  Message = renderSpace.ToString()
                                              });

                return;
            }

            FireEvent(renderSpace.ToString());
        }

        private void FireEvent(string str)
        {
            OnLogReceived?.Invoke(str);
        }
    }

    public static class WindFormsSink
    {
        public static readonly WinFormsSinkInternal SimpleTextBoxSink = new WinFormsSinkInternal(new MessageTemplateTextFormatter("{Timestamp} [{Level}] {Message} {Exception}"));
        public static readonly WinFormsSinkInternal JsonTextBoxSink = new WinFormsSinkInternal(new JsonFormatter());
        public static readonly WinFormsSinkInternal GridLogSink = new WinFormsSinkInternal(new MessageTemplateTextFormatter("{Message} {Exception}"), true);
    }
}
