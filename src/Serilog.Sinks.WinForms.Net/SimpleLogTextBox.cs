using Serilog.Sinks.WinForms.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class SimpleLogTextBox : UserControl
    {
        private bool _isContextConfigured = false;

        [Category("Serilog Sink WinForms")] public ScrollBars ScrollBars { get; set; }
        [Category("Serilog Sink WinForms")] public Padding LogPadding { get; set; } = new Padding(3, 3, 3, 3);
        [Category("Serilog Sink WinForms")] public bool ReadOnly { get; set; }
        [Category("Serilog Sink WinForms")] public string ForContext { get; set; } = string.Empty;
        [Category("Serilog Sink WinForms")] public BorderStyle LogBorderStyle { get; set; } = BorderStyle.Fixed3D;
        [Category("Serilog Sink WinForms")] public bool AutoPurge { get; set; }
        [Category("Serilog Sink WinForms")] public double AutoPurgeTime { get; set; } = 60;

        private Timer _timer;

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
            _isContextConfigured = !string.IsNullOrEmpty(this.ForContext);

            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;

            HandleDestroyed += (handler, args) =>
            {
                WindFormsSink.SimpleTextBoxSink.OnLogReceived -= SimpleTextBoxSinkOnLogReceived;
            };

            if (AutoPurge)
            {
                _timer = new Timer
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

        public void ClearLogs()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => TxtLogControl.Clear()));
            }
            else
            {
                TxtLogControl.Clear();
            }
        }

        private void SimpleTextBoxSinkOnLogReceived(string context, string str)
        {
            if (_isContextConfigured)
            {
                if (!string.IsNullOrEmpty(this.ForContext)
                    && !string.IsNullOrEmpty(context)
                    && this.ForContext.Equals(context, StringComparison.InvariantCultureIgnoreCase))
                {
                    PrintText(str);
                }
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
                this.Invoke(
                    (MethodInvoker)delegate
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
        }


        public void SaveLogToFile()
        {
            SaveFileHelper.SaveLogsToFile(TxtLogControl.Text);
        }
    }
}