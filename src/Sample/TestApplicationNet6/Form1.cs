using Serilog;

namespace TestApplicationNet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteLog_Click(object sender, EventArgs e)
        {
            Log.Information("This is the Text log..");
            Log.Information(txtLog.Text);
        }
    }
}