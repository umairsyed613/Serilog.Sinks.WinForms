using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                this.Invoke(
                    (MethodInvoker) delegate { this.AppendText(str + Environment.NewLine); });
            }
            else { this.AppendText(str + Environment.NewLine); }

            Application.DoEvents();
        }
    }
}
