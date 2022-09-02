namespace TestApplication
{
    partial class LogVieweer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridLog1 = new Serilog.Sinks.WinForms.GridLog();
            this.jsonLogTextBox1 = new Serilog.Sinks.WinForms.JsonLogTextBox();
            this.simpleLogTextBox1 = new Serilog.Sinks.WinForms.SimpleLogTextBox();
            this.richTextBoxLogControl1 = new Serilog.Sinks.WinForms.RichTextBoxLogControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Textbox Logger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Json Textbox Logger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grid Logger";
            // 
            // gridLog1
            // 
            this.gridLog1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLog1.Location = new System.Drawing.Point(16, 349);
            this.gridLog1.Name = "gridLog1";
            this.gridLog1.Size = new System.Drawing.Size(772, 180);
            this.gridLog1.TabIndex = 5;
            // 
            // jsonLogTextBox1
            // 
            this.jsonLogTextBox1.ForContext = "";
            this.jsonLogTextBox1.Location = new System.Drawing.Point(16, 196);
            this.jsonLogTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jsonLogTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.jsonLogTextBox1.Name = "jsonLogTextBox1";
            this.jsonLogTextBox1.ReadOnly = true;
            this.jsonLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonLogTextBox1.Size = new System.Drawing.Size(772, 121);
            this.jsonLogTextBox1.TabIndex = 2;
            // 
            // simpleLogTextBox1
            // 
            this.simpleLogTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLogTextBox1.ForContext = "";
            this.simpleLogTextBox1.Location = new System.Drawing.Point(16, 44);
            this.simpleLogTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simpleLogTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.simpleLogTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleLogTextBox1.Name = "simpleLogTextBox1";
            this.simpleLogTextBox1.ReadOnly = true;
            this.simpleLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.simpleLogTextBox1.Size = new System.Drawing.Size(772, 121);
            this.simpleLogTextBox1.TabIndex = 1;
            // 
            // richTextBoxLogControl1
            // 
            this.richTextBoxLogControl1.ForContext = "TestApplication.Form1";
            this.richTextBoxLogControl1.Location = new System.Drawing.Point(16, 551);
            this.richTextBoxLogControl1.Name = "richTextBoxLogControl1";
            this.richTextBoxLogControl1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLogControl1.Size = new System.Drawing.Size(772, 211);
            this.richTextBoxLogControl1.TabIndex = 6;
            this.richTextBoxLogControl1.Text = "";
            // 
            // LogVieweer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 774);
            this.Controls.Add(this.richTextBoxLogControl1);
            this.Controls.Add(this.gridLog1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jsonLogTextBox1);
            this.Controls.Add(this.simpleLogTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "LogVieweer";
            this.Text = "LogViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Serilog.Sinks.WinForms.SimpleLogTextBox simpleLogTextBox1;
        private Serilog.Sinks.WinForms.JsonLogTextBox jsonLogTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Serilog.Sinks.WinForms.GridLog gridLog1;
        private Serilog.Sinks.WinForms.RichTextBoxLogControl richTextBoxLogControl1;
    }
}