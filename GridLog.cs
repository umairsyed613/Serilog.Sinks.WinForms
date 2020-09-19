using System;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public partial class GridLog : UserControl
    {
        public GridLog()
        {
            InitializeComponent();
        }

        private void GridLog_Load(object sender, EventArgs e)
        {
            LogGridView.Font = this.Font;

            WindFormsSink.GridLogSink.OnGridLogReceived += GridLogSink_OnGridLogReceived;
        }

        private void GridLogSink_OnGridLogReceived(GridLogEvent logEvent)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker)delegate
                        {
                            LogGridView.Rows.Add(logEvent.TimeStamp.ToString(), logEvent.Level, logEvent.Message);
                        });
            }
            else
            {
                LogGridView.Rows.Add(logEvent.TimeStamp.ToString(), logEvent.Level, logEvent.Message);
            }
        }
    }
}
