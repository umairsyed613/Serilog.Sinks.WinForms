using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class MasterForm : Form
    {

        private LogVieweer LogViewer;

        public MasterForm()
        {
            InitializeComponent();

            LogViewer = new LogVieweer();
            LogViewer.MdiParent = this;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LogViewer.Show();
        }
    }
}
