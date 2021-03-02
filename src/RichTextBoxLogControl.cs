using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class RichTextBoxLogControl : RichTextBox
    {
        public RichTextBoxLogControl()
        {
            InitializeComponent();
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;
        }

        private void SimpleTextBoxSinkOnLogReceived(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
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
