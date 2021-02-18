
namespace TestApplicationWithTransparentBackground
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
            this.button1 = new System.Windows.Forms.Button();
            this.transparentSimpleLogTextBox1 = new Serilog.Sinks.WinForms.TransparentSimpleLogTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transparentSimpleLogTextBox1
            // 
            this.transparentSimpleLogTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.transparentSimpleLogTextBox1.Location = new System.Drawing.Point(13, 135);
            this.transparentSimpleLogTextBox1.Multiline = true;
            this.transparentSimpleLogTextBox1.Name = "transparentSimpleLogTextBox1";
            this.transparentSimpleLogTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transparentSimpleLogTextBox1.Size = new System.Drawing.Size(775, 173);
            this.transparentSimpleLogTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.transparentSimpleLogTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Serilog.Sinks.WinForms.TransparentSimpleLogTextBox transparentSimpleLogTextBox1;
    }
}

