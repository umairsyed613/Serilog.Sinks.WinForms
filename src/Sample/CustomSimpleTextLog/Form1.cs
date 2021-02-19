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
using Serilog.Sinks.WinForms;

namespace CustomSimpleTextLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindFormsSink.SimpleTextBoxSink.OnLogReceived += SimpleTextBoxSinkOnOnLogReceived;
        }

        private void SimpleTextBoxSinkOnOnLogReceived(string str)
        {
            this.textBox1.AppendText(str);
            this.richTextBox1.AppendText(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log.Information(textBox2.Text);
        }
    }
}
