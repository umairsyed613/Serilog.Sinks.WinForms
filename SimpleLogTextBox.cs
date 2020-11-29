using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class SimpleLogTextBox : UserControl
    {
        public ScrollBars ScrollBars { get; set; }

        public Padding LogPadding { get; set; } = new Padding(3, 3, 3, 3);

        public bool ReadOnly { get; set; }

        public BorderStyle LogBorderStyle { get; set; } = BorderStyle.Fixed3D;


        public SimpleLogTextBox()
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
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;
        }

        private void SimpleTextBoxSinkOnLogReceived(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker)delegate
                        {
                            TxtLogControl.AppendText(str + Environment.NewLine);
                        });
            }
            else
            {
                TxtLogControl.AppendText(str + Environment.NewLine);
            }

            Application.DoEvents();
        }
    }
}
