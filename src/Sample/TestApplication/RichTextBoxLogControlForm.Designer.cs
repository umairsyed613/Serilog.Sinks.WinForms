
namespace TestApplication
{
    partial class RichTextBoxLogControlForm
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
            this.richTextBoxLogControl1 = new Serilog.Sinks.WinForms.RichTextBoxLogControl();
            this.SuspendLayout();
            // 
            // richTextBoxLogControl1
            // 
            this.richTextBoxLogControl1.BackColor = System.Drawing.Color.White;
            this.richTextBoxLogControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLogControl1.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxLogControl1.Location = new System.Drawing.Point(12, 21);
            this.richTextBoxLogControl1.Name = "richTextBoxLogControl1";
            this.richTextBoxLogControl1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLogControl1.Size = new System.Drawing.Size(776, 417);
            this.richTextBoxLogControl1.TabIndex = 0;
            this.richTextBoxLogControl1.Text = "";
            // 
            // RichTextBoxLogControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxLogControl1);
            this.Name = "RichTextBoxLogControlForm";
            this.Text = "RichTextBoxLogControlForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Serilog.Sinks.WinForms.RichTextBoxLogControl richTextBoxLogControl1;
    }
}