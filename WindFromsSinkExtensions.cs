namespace Serilog.Sinks.WinForms
{
    public static class WindFromsSinkExtensions
    {
        /// <summary>
        /// Write the simple formatted text logs directly to textbox. simple textbox control can be used from toolbox
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static LoggerConfiguration WriteToSimpleTextBox(this LoggerConfiguration configuration)
        {
            return configuration.WriteTo.Sink(WindFormsSink.SimpleTextBoxSink);
        }

        /// <summary>
        /// Write the compact json formatted text logs directly to textbox. json textbox control can be used from toolbox
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static LoggerConfiguration WriteToJsonTextBox(this LoggerConfiguration configuration)
        {
            return configuration.WriteTo.Sink(WindFormsSink.JsonTextBoxSink);
        }
    }
}
