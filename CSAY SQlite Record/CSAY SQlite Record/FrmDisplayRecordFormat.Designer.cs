namespace CSAY_SQlite_Record
{
    partial class FrmDisplayRecordFormat
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
            this.TxtDisplayRecordFormat = new System.Windows.Forms.TextBox();
            this.BtnExportToTextFile = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplayRecordFormat
            // 
            this.TxtDisplayRecordFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDisplayRecordFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplayRecordFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplayRecordFormat.ForeColor = System.Drawing.Color.Black;
            this.TxtDisplayRecordFormat.Location = new System.Drawing.Point(12, 51);
            this.TxtDisplayRecordFormat.Multiline = true;
            this.TxtDisplayRecordFormat.Name = "TxtDisplayRecordFormat";
            this.TxtDisplayRecordFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplayRecordFormat.Size = new System.Drawing.Size(838, 387);
            this.TxtDisplayRecordFormat.TabIndex = 114;
            // 
            // BtnExportToTextFile
            // 
            this.BtnExportToTextFile.BackColor = System.Drawing.Color.White;
            this.BtnExportToTextFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnExportToTextFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExportToTextFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnExportToTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportToTextFile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportToTextFile.ForeColor = System.Drawing.Color.Black;
            this.BtnExportToTextFile.Location = new System.Drawing.Point(12, 12);
            this.BtnExportToTextFile.Name = "BtnExportToTextFile";
            this.BtnExportToTextFile.Size = new System.Drawing.Size(189, 33);
            this.BtnExportToTextFile.TabIndex = 117;
            this.BtnExportToTextFile.Text = "Export to Text File";
            this.BtnExportToTextFile.UseVisualStyleBackColor = false;
            this.BtnExportToTextFile.Click += new System.EventHandler(this.BtnExportToTextFile_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(233, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(162, 33);
            this.BtnExit.TabIndex = 119;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmDisplayRecordFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnExportToTextFile);
            this.Controls.Add(this.TxtDisplayRecordFormat);
            this.Name = "FrmDisplayRecordFormat";
            this.Text = "FrmDisplayRecordFormat";
            this.Load += new System.EventHandler(this.FrmDisplayRecordFormat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplayRecordFormat;
        private System.Windows.Forms.Button BtnExportToTextFile;
        private System.Windows.Forms.Button BtnExit;
    }
}