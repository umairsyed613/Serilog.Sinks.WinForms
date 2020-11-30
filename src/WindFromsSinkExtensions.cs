using Serilog.Formatting;

namespace Serilog.Sinks.WinForms
{
    public static class WindFromsSinkExtensions
    {
        /// <summary>
        /// Write the simple formatted text logs directly to textbox. simple textbox control can be used from toolbox
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static LoggerConfiguration WriteToSimpleTextBox(this LoggerConfiguration configuration, ITextFormatter formatter = null)
        {
            return configuration.WriteTo.Sink(WindFormsSink.MakeSimpleTextBoxSink(formatter));
        }

        /// <summary>
        /// Write the compact json formatted text logs directly to textbox. json textbox control can be used from toolbox
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static LoggerConfiguration WriteToJsonTextBox(this LoggerConfiguration configuration, ITextFormatter formatter = null)
        {
            return configuration.WriteTo.Sink(WindFormsSink.MakeJsonTextBoxSink(formatter));
        }

        /// <summary>
        /// Write the logs directly to Data Grid View. GridLog control can be used from toolbox
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static LoggerConfiguration WriteToGridView(this LoggerConfiguration configuration)
        {
            return configuration.WriteTo.Sink(WindFormsSink.GridLogSink);
        }
    }
}
