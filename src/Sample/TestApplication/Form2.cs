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
    public partial class Form2 : Form
    {
        private static readonly ILogger _logger = Log.ForContext<Form2>();
        public Form2()
        {
            InitializeComponent();
            label1.Text = simpleLogTextBox1.ForContext;
            _logger.Information("Form2 has been Initialized");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _logger.Information(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Throwing exception from Form2");
            }
            catch (Exception exception)
            {
                _logger.Error(exception, "Error Happened in Form2");
            }
        }
    }
}
