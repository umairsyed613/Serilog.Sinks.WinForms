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
            this.simpleLogTextBox1 = new Serilog.Sinks.WinForms.Core.SimpleLogTextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnWriteLog = new System.Windows.Forms.Button();
            this.jsonLogTextBox1 = new Serilog.Sinks.WinForms.Core.JsonLogTextBox();
            this.richTextBoxLogControl1 = new Serilog.Sinks.WinForms.Core.RichTextBoxLogControl();
            this.SuspendLayout();
            // 
            // simpleLogTextBox1
            // 
            this.simpleLogTextBox1.ForContext = "";
            this.simpleLogTextBox1.Location = new System.Drawing.Point(13, 79);
            this.simpleLogTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simpleLogTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.simpleLogTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleLogTextBox1.Name = "simpleLogTextBox1";
            this.simpleLogTextBox1.ReadOnly = false;
            this.simpleLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.simpleLogTextBox1.Size = new System.Drawing.Size(774, 148);
            this.simpleLogTextBox1.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(32, 19);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(580, 23);
            this.txtLog.TabIndex = 1;
            // 
            // btnWriteLog
            // 
            this.btnWriteLog.Location = new System.Drawing.Point(618, 18);
            this.btnWriteLog.Name = "btnWriteLog";
            this.btnWriteLog.Size = new System.Drawing.Size(169, 23);
            this.btnWriteLog.TabIndex = 2;
            this.btnWriteLog.Text = "Write Log";
            this.btnWriteLog.UseVisualStyleBackColor = true;
            this.btnWriteLog.Click += new System.EventHandler(this.btnWriteLog_Click);
            // 
            // jsonLogTextBox1
            // 
            this.jsonLogTextBox1.ForContext = "";
            this.jsonLogTextBox1.Location = new System.Drawing.Point(13, 242);
            this.jsonLogTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jsonLogTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.jsonLogTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jsonLogTextBox1.Name = "jsonLogTextBox1";
            this.jsonLogTextBox1.ReadOnly = false;
            this.jsonLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jsonLogTextBox1.Size = new System.Drawing.Size(774, 210);
            this.jsonLogTextBox1.TabIndex = 3;
            // 
            // richTextBoxLogControl1
            // 
            this.richTextBoxLogControl1.ForContext = "";
            this.richTextBoxLogControl1.Location = new System.Drawing.Point(13, 469);
            this.richTextBoxLogControl1.Name = "richTextBoxLogControl1";
            this.richTextBoxLogControl1.Size = new System.Drawing.Size(774, 164);
            this.richTextBoxLogControl1.TabIndex = 4;
            this.richTextBoxLogControl1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 658);
            this.Controls.Add(this.richTextBoxLogControl1);
            this.Controls.Add(this.jsonLogTextBox1);
            this.Controls.Add(this.btnWriteLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.simpleLogTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Serilog.Sinks.WinForms.Core.SimpleLogTextBox simpleLogTextBox1;
        private TextBox txtLog;
        private Button btnWriteLog;
        private Serilog.Sinks.WinForms.Core.JsonLogTextBox jsonLogTextBox1;
        private Serilog.Sinks.WinForms.Core.RichTextBoxLogControl richTextBoxLogControl1;
    }
}