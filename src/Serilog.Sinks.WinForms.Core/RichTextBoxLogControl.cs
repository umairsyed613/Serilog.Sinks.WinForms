using Serilog.Sinks.WinForms.Base;

namespace Serilog.Sinks.WinForms.Core
{
    public partial class RichTextBoxLogControl : RichTextBox
    {
        public string ForContext { get; set; } = string.Empty;
        private bool _isContextConfigured = false;

        public RichTextBoxLogControl()
        {
            InitializeComponent();
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;

            HandleDestroyed += ( sender, args ) =>
            {
                WindFormsSink.SimpleTextBoxSink.OnLogReceived -= SimpleTextBoxSinkOnLogReceived;
            };
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
        {
            if (_isContextConfigured)
            {
                if (!string.IsNullOrEmpty(this.ForContext)
                 && !string.IsNullOrEmpty(context)
                 && this.ForContext.Equals(context, StringComparison.InvariantCultureIgnoreCase)) { PrintText(str); }
            }
            else
            {
                PrintText(str);
            }

            Application.DoEvents();
        }

        private void PrintText(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker) delegate
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
