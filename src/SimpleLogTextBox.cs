using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public sealed partial class SimpleLogTextBox : UserControl
    {
        public ScrollBars ScrollBars { get; set; }

        public Padding LogPadding { get; set; } = new Padding(3, 3, 3, 3);

        public bool ReadOnly { get; set; }

        public BorderStyle LogBorderStyle { get; set; } = BorderStyle.Fixed3D;

        public string ForContext { get; set; } = string.Empty;

        private bool _isContextConfigured = false;

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
            TxtLogControl.ContextMenuStrip = logControlActionMenu1;
            _isContextConfigured = !string.IsNullOrEmpty(this.ForContext);

            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;
            WindFormsSink.SimpleTextBoxSink.OnClearLog += SimpleTextBoxSinkOnOnClearLog;
        }

        private void SimpleTextBoxSinkOnOnClearLog()
        {
            if (this.InvokeRequired) { this.Invoke((MethodInvoker) (() => TxtLogControl.Clear())); }
            else { TxtLogControl.Clear(); }
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
        }

        private void InitializeComponent()
        {
            this.logControlActionMenu1 = new Serilog.Sinks.WinForms.LogControlActionMenu();
            this.SuspendLayout();
            // 
            // logControlActionMenu1
            // 
            this.logControlActionMenu1.Name = "logControlActionMenu1";
            this.logControlActionMenu1.ShowImageMargin = false;
            this.logControlActionMenu1.Size = new System.Drawing.Size(156, 78);
            // 
            // SimpleLogTextBox
            // 
            this.Name = "SimpleLogTextBox";
            this.ResumeLayout(false);
        }
    }
}
