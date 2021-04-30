using System;
using System.Drawing;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class TransparentSimpleLogTextBox : TextBox
    {
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
            this.Multiline = true;
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker)delegate
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
