using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace TestApplicationWithTransparentBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log.Information("Testing");
        }
    }
}
