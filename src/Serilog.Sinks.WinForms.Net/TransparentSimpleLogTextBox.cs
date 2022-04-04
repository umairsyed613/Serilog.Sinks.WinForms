using Serilog.Sinks.WinForms.Base;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class TransparentSimpleLogTextBox : TextBox
    {
        public string ForContext { get; set; } = string.Empty;
        private bool _isContextConfigured = false;

        public TransparentSimpleLogTextBox()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            BackColor = Color.Transparent;
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;

            HandleDestroyed += ( handler, args ) =>
            {
                WindFormsSink.SimpleTextBoxSink.OnLogReceived -= SimpleTextBoxSinkOnLogReceived;
            };

            this.Multiline = true;
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
        {
            if (_isContextConfigured)
            {
                if (!string.IsNullOrEmpty(this.ForContext)
                 && !string.IsNullOrEmpty(context)
                 && this.ForContext.Equals(context, StringComparison.InvariantCultureIgnoreCase)) { PrintLog(str); }
            }
            else
            {
                PrintLog(str);
            }

            Application.DoEvents();
        }

        private void PrintLog(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker) delegate
                    {
                        this.AppendText(str);
                        this.ScrollToCaret();
                    });
            }
            else
            {
                this.AppendText(str);
                this.ScrollToCaret();
            }
        }

        public void ClearLogs()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => this.Clear()));
            }
            else
            {
                this.Clear();
            }
        }

        public void SaveLogToFile()
        {
            SaveFileHelper.SaveLogsToFile(this.Text);
        }
    }
}
