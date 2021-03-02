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

            if (_textFormatter == null) { throw new ArgumentNullException("Missing Log Formatter"); }

            var renderSpace = new StringWriter();
            _textFormatter.Format(logEvent, renderSpace);

            if (_isGridLogger)
            {
                OnGridLogReceived?.Invoke(new GridLogEvent { Level = logEvent.Level, TimeStamp = logEvent.Timestamp, Message = renderSpace.ToString() });

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
        private static readonly ITextFormatter _defaultTextFormatter = new MessageTemplateTextFormatter("{Timestamp:HH:mm:ss} {Level} {Message:lj}{NewLine}{Exception}");

        private static WinFormsSinkInternal _simpleTextBoxSink = new WinFormsSinkInternal(_defaultTextFormatter);
        public static WinFormsSinkInternal SimpleTextBoxSink => _simpleTextBoxSink;

        private static WinFormsSinkInternal _jsonTextBoxSink = new WinFormsSinkInternal(new JsonFormatter());
        public static WinFormsSinkInternal JsonTextBoxSink => _jsonTextBoxSink;

        public static readonly WinFormsSinkInternal GridLogSink = new WinFormsSinkInternal(new MessageTemplateTextFormatter("{Message}{NewLine}{Exception}"), true);

        public static WinFormsSinkInternal MakeSimpleTextBoxSink(ITextFormatter formatter = null)
        {
            if (formatter == null) { formatter = _defaultTextFormatter; }

            _simpleTextBoxSink = new WinFormsSinkInternal(formatter);

            return _simpleTextBoxSink;
        }

        public static WinFormsSinkInternal MakeJsonTextBoxSink(ITextFormatter formatter = null)
        {
            if (formatter == null) { formatter = new JsonFormatter(); }

            _jsonTextBoxSink = new WinFormsSinkInternal(formatter);

            return _jsonTextBoxSink;
        }
    }
}
