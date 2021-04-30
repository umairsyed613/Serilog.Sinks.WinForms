using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public sealed partial class JsonLogTextBox : UserControl
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
            TxtLogControl.Font = this.Font;
            TxtLogControl.ForeColor = this.ForeColor;
            TxtLogControl.BackColor = this.BackColor;
            TxtLogControl.ContextMenuStrip = logControlActionMenu1;
            WindFormsSink.JsonTextBoxSink.OnLogReceived += JsonTextBoxSinkOnLogReceived;
            WindFormsSink.JsonTextBoxSink.OnClearLog += JsonTextBoxSinkOnOnClearLog;
        }

        private void JsonTextBoxSinkOnOnClearLog()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker) (() => TxtLogControl.Clear()));
            }
            else { TxtLogControl.Clear(); }
        }

        private void JsonTextBoxSinkOnLogReceived(string context, string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker) delegate
                    {
                        TxtLogControl.AppendText(str);
                        TxtLogControl.ScrollToCaret();
                    });
            }
            else
            {
                TxtLogControl.AppendText(str);
                TxtLogControl.ScrollToCaret();
            }

            Application.DoEvents();
        }
    }
}
