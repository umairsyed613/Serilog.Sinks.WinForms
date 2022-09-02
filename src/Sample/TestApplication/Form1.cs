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

namespace TestApplication
{
    public partial class Form1 : Form
    {
        private ILogger logger = Log.ForContext<Form1>();
        public Form1()
        {
            InitializeComponent();
            logger.Information("Form1 has been Initialized");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Information(textBox1.Text);
        }
    }
}
