using System;
using System.Windows.Forms;

using Serilog;
using Serilog.Sinks.WinForms;

namespace TestApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureSerilog();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MasterForm());
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
