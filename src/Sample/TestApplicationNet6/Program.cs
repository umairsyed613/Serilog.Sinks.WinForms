using Serilog;
using Serilog.Sinks.WinForms.Base;

namespace TestApplicationNet6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureSerilog();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static void ConfigureSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                        .Enrich.FromLogContext()
                        .WriteToGridView()
                        .WriteToJsonTextBox()
                        .WriteToSimpleAndRichTextBox()
                        .CreateLogger();
        }
    }
}