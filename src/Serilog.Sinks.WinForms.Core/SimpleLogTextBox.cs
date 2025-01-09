using System.ComponentModel;
using Serilog.Sinks.WinForms.Base;

namespace Serilog.Sinks.WinForms.Core
{
    public partial class SimpleLogTextBox : UserControl
    {
        private bool _isContextConfigured = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ScrollBars ScrollBars { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Padding LogPadding { get; set; } = new Padding(3, 3, 3, 3);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public bool ReadOnly { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string ForContext { get; set; } = string.Empty;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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
            _isContextConfigured = !string.IsNullOrEmpty(this.ForContext);

            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnLogReceived;

            HandleDestroyed += ( handler, args ) =>
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

        public void SaveLogToFile()
        {
            SaveFileHelper.SaveLogsToFile(TxtLogControl.Text);
        }
    }
}