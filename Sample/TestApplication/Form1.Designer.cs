namespace TestApplication
{
    partial class Form1
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
            this.logTextBox1 = new Serilog.WinForms.JsonLogTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleLogTextBox1 = new Serilog.WinForms.SimpleLogTextBox();
            this.SuspendLayout();
            // 
            // logTextBox1
            // 
            this.logTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox1.Location = new System.Drawing.Point(7, 239);
            this.logTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.logTextBox1.Name = "logTextBox1";
            this.logTextBox1.ReadOnly = true;
            this.logTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox1.Size = new System.Drawing.Size(546, 158);
            this.logTextBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 20);
            this.textBox1.TabIndex = 1;
            // 
            // simpleLogTextBox1
            // 
            this.simpleLogTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleLogTextBox1.Location = new System.Drawing.Point(7, 72);
            this.simpleLogTextBox1.LogBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.simpleLogTextBox1.LogPadding = new System.Windows.Forms.Padding(3);
            this.simpleLogTextBox1.Name = "simpleLogTextBox1";
            this.simpleLogTextBox1.ReadOnly = true;
            this.simpleLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.simpleLogTextBox1.Size = new System.Drawing.Size(546, 158);
            this.simpleLogTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 410);
            this.Controls.Add(this.simpleLogTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Serilog.WinForms.JsonLogTextBox logTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private Serilog.WinForms.SimpleLogTextBox simpleLogTextBox1;
    }
}

