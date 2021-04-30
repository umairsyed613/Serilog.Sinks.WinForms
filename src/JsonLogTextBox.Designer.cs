namespace Serilog.Sinks.WinForms
{
    sealed partial class JsonLogTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtLogControl = new System.Windows.Forms.TextBox();
            this.logControlActionMenu1 = new Serilog.Sinks.WinForms.LogControlActionMenu();
            this.SuspendLayout();

            // 
            // TxtLogControl
            // 
            this.TxtLogControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLogControl.Location = new System.Drawing.Point(0, 0);
            this.TxtLogControl.Multiline = true;
            this.TxtLogControl.Name = "TxtLogControl";
            this.TxtLogControl.Size = new System.Drawing.Size(372, 158);
            this.TxtLogControl.TabIndex = 0;

            // 
            // JsonLogTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtLogControl);
            this.Name = "JsonLogTextBox";
            this.Size = new System.Drawing.Size(372, 158);
            this.Load += new System.EventHandler(this.LogTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Serilog.Sinks.WinForms.LogControlActionMenu logControlActionMenu1;

        #endregion

        private System.Windows.Forms.TextBox TxtLogControl;
    }
}
