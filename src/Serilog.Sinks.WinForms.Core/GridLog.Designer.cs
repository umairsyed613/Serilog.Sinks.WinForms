namespace Serilog.Sinks.WinForms.Core
{
    partial class GridLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogGridView = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogGridView
            // 
            this.LogGridView.AllowUserToAddRows = false;
            this.LogGridView.AllowUserToDeleteRows = false;
            this.LogGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LogGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.Level,
            this.Log});
            this.LogGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogGridView.Location = new System.Drawing.Point(0, 0);
            this.LogGridView.Name = "LogGridView";
            this.LogGridView.ReadOnly = true;
            this.LogGridView.RowHeadersVisible = false;
            this.LogGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.LogGridView.Size = new System.Drawing.Size(358, 150);
            this.LogGridView.TabIndex = 0;
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.Width = 85;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 58;
            // 
            // Log
            // 
            this.Log.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Log.DefaultCellStyle = dataGridViewCellStyle1;
            this.Log.HeaderText = "Log";
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            // 
            // GridLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogGridView);
            this.Name = "GridLog";
            this.Size = new System.Drawing.Size(358, 150);
            this.Load += new System.EventHandler(this.GridLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LogGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
    }
}
