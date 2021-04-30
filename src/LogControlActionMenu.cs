using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Serilog.Sinks.WinForms
{
    public sealed partial class LogControlActionMenu : ContextMenuStrip
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks Save Log")]
        public event EventHandler SaveLogAction;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks Clear Log")]
        public event EventHandler ClearLogAction;

        public LogControlActionMenu()
        {
            InitializeComponent();
            SetupMenuItems();
        }

        private void SetupMenuItems()
        {
            var mnuSave = new ToolStripButton { Text = @"Save To File", Image = imageList1.Images[0] };
            mnuSave.Click += MnuSaveOnClick;

            var mnuDel = new ToolStripButton { Text = @"Clear Log", Image = imageList1.Images[1] };

            mnuDel.Click += MnuDelOnClick;

            this.Items.Add(mnuSave);
            this.Items.Add(new ToolStripSeparator());
            this.Items.Add(mnuDel);
            this.ShowImageMargin = false;
        }

        private void MnuDelOnClick(object sender, EventArgs e)
        {
            //WindFormsSink.ClearSimpleTextBoxLog()
            ClearLogAction?.Invoke(this, e);
        }

        private void MnuSaveOnClick(object sender, EventArgs e)
        {
            SaveLogAction?.Invoke(this, e);
        }
    }
}

