using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class JsonLogTextBox : UserControl
    {
        public ScrollBars ScrollBars { get; set; }

        public Padding LogPadding { get; set; } = new Padding(3, 3, 3, 3);

        public bool ReadOnly { get; set; }

        public BorderStyle LogBorderStyle { get; set; } = BorderStyle.Fixed3D;

        public JsonLogTextBox()
        {
            InitializeComponent();
        }

        private void LogTextBox_Load(object sender, EventArgs e)
        {
            TxtLogControl.ScrollBars = ScrollBars;
            TxtLogControl.Padding = LogPadding;
            TxtLogControl.ReadOnly = ReadOnly;
            TxtLogControl.BorderStyle = LogBorderStyle;
            WindFormsSink.JsonTextBoxSink.OnLogReceived += JsonTextBoxSinkOnLogReceived;
            
        }

        private void JsonTextBoxSinkOnLogReceived(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker)delegate
                        {
                            TxtLogControl.AppendText(str);
                        });
            }
            else
            {
                TxtLogControl.AppendText(str);
            }
        }
    }
}
