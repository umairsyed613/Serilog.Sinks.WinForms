using System;
using System.Windows.Forms;
using Serilog.Sinks.WinForms.Base;

namespace Serilog.Sinks.WinForms.Core
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

            HandleDestroyed += (handler, args) =>
            {
                WindFormsSink.GridLogSink.OnGridLogReceived -= GridLogSink_OnGridLogReceived;
            };
        }

        private void GridLogSink_OnGridLogReceived(GridLogEvent logEvent)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    (MethodInvoker)delegate
                        {
                            LogGridView.Rows.Add(logEvent.TimeStamp.ToString(), logEvent.Level, logEvent.Message?.Trim());
                            LogGridView.FirstDisplayedScrollingRowIndex = LogGridView.RowCount - 1;
                        });
            }
            else
            {
                LogGridView.Rows.Add(logEvent.TimeStamp.ToString(), logEvent.Level, logEvent.Message);
                LogGridView.FirstDisplayedScrollingRowIndex = LogGridView.RowCount - 1;
            }

            Application.DoEvents();
        }
    }
}
