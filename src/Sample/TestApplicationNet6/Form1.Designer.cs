namespace TestApplicationNet6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            simpleLogTextBox1 = new Serilog.Sinks.WinForms.Core.SimpleLogTextBox();
            txtLog = new TextBox();
            btnWriteLog = new Button();
            jsonLogTextBox1 = new Serilog.Sinks.WinForms.Core.JsonLogTextBox();
            richTextBoxLogControl1 = new Serilog.Sinks.WinForms.Core.RichTextBoxLogControl();
            SuspendLayout();
            // 
            // simpleLogTextBox1
            // 
            simpleLogTextBox1.Location = new Point(13, 79);
            simpleLogTextBox1.Margin = new Padding(4, 3, 4, 3);
            simpleLogTextBox1.Name = "simpleLogTextBox1";
            simpleLogTextBox1.Size = new Size(774, 148);
            simpleLogTextBox1.TabIndex = 0;
            simpleLogTextBox1.AutoPurge = true;
            simpleLogTextBox1.AutoPurgeTime = 1;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(32, 19);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(580, 23);
            txtLog.TabIndex = 1;
            // 
            // btnWriteLog
            // 
            btnWriteLog.Location = new Point(618, 18);
            btnWriteLog.Name = "btnWriteLog";
            btnWriteLog.Size = new Size(169, 23);
            btnWriteLog.TabIndex = 2;
            btnWriteLog.Text = "Write Log";
            btnWriteLog.UseVisualStyleBackColor = true;
            btnWriteLog.Click += btnWriteLog_Click;
            // 
            // jsonLogTextBox1
            // 
            jsonLogTextBox1.Location = new Point(13, 242);
            jsonLogTextBox1.Margin = new Padding(4, 3, 4, 3);
            jsonLogTextBox1.Name = "jsonLogTextBox1";
            jsonLogTextBox1.Size = new Size(774, 210);
            jsonLogTextBox1.TabIndex = 3;
            // 
            // richTextBoxLogControl1
            // 
            richTextBoxLogControl1.Location = new Point(13, 469);
            richTextBoxLogControl1.Name = "richTextBoxLogControl1";
            richTextBoxLogControl1.Size = new Size(774, 164);
            richTextBoxLogControl1.TabIndex = 4;
            richTextBoxLogControl1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 658);
            Controls.Add(richTextBoxLogControl1);
            Controls.Add(jsonLogTextBox1);
            Controls.Add(btnWriteLog);
            Controls.Add(txtLog);
            Controls.Add(simpleLogTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Serilog.Sinks.WinForms.Core.SimpleLogTextBox simpleLogTextBox1;
        private TextBox txtLog;
        private Button btnWriteLog;
        private Serilog.Sinks.WinForms.Core.JsonLogTextBox jsonLogTextBox1;
        private Serilog.Sinks.WinForms.Core.RichTextBoxLogControl richTextBoxLogControl1;
    }
}