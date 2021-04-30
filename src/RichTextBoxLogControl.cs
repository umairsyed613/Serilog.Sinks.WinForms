using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public sealed partial class RichTextBoxLogControl : RichTextBox
    {
        public RichTextBoxLogControl()
        {
            InitializeComponent();
            this.ContextMenuStrip = logControlActionMenu1;
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;
            WindFormsSink.SimpleTextBoxSink.OnClearLog += SimpleTextBoxSinkOnOnClearLog;
        }

        private void SimpleTextBoxSinkOnOnClearLog()
        {
            if (this.InvokeRequired) { this.Invoke((MethodInvoker) this.Clear); }
            else { this.Clear(); }
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
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

            Application.DoEvents();
        }
    }
}
