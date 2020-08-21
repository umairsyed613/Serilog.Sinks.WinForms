using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Serilog;
using Serilog.WinForms;

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
                        .WriteTo.Sink(WindFormsSink.JsonTextBoxSink)
                        .WriteTo.Sink(WindFormsSink.SimpleTextBoxSink)
                        .CreateLogger();
        }
    }
}
