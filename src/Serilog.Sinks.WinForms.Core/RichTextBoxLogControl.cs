using System.ComponentModel;
using Serilog.Sinks.WinForms.Base;

namespace Serilog.Sinks.WinForms.Core
{
    public partial class RichTextBoxLogControl : RichTextBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Serilog Sink WinForms")] public string ForContext { get; set; } = string.Empty;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Serilog Sink WinForms")] public bool AutoPurge { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Serilog Sink WinForms")] public double AutoPurgeTime { get; set; } = 60;

        private System.Windows.Forms.Timer _timer = default!;

        public RichTextBoxLogControl()
        {
            InitializeComponent();
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;

            HandleDestroyed += (sender, args) =>
            {
                WindFormsSink.SimpleTextBoxSink.OnLogReceived -= SimpleTextBoxSinkOnLogReceived;
            };

            if (AutoPurge)
            {
                _timer = new System.Windows.Forms.Timer
                {
                    Interval = Convert.ToInt32(TimeSpan.FromMinutes(AutoPurgeTime).TotalMilliseconds)
                };
                _timer.Tick += _timer_Tick;
                _timer.Start();
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            ClearLogs();
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
        {
            if (!string.IsNullOrEmpty(this.ForContext.Trim()))
            {
                if (!string.IsNullOrEmpty(context)
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