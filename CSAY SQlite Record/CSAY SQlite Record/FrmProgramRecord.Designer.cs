namespace CSAY_SQlite_Record
{
    partial class FrmProgramRecord
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnOpenAddForm = new System.Windows.Forms.Button();
            this.dataGridViewAllPara = new System.Windows.Forms.DataGridView();
            this.LblRecordNo = new System.Windows.Forms.Label();
            this.LblDbLog = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLoadRecords = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtFilterMsg = new System.Windows.Forms.TextBox();
            this.ComboBoxFilterDistinctValues = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtFilterMsgLevel2 = new System.Windows.Forms.TextBox();
            this.ComboBoxFilterDistinctValuesLevel2 = new System.Windows.Forms.ComboBox();
            this.BtnFilterLevel2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ComboBoxFilterByLevel2 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPara)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnAbout);
            this.groupBox1.Controls.Add(this.BtnOpenAddForm);
            this.groupBox1.Controls.Add(this.dataGridViewAllPara);
            this.groupBox1.Controls.Add(this.LblRecordNo);
            this.groupBox1.Controls.Add(this.LblDbLog);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.BtnLoadRecords);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 431);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Records";
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.White;
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.Black;
            this.BtnAbout.Location = new System.Drawing.Point(307, 384);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(129, 33);
            this.BtnAbout.TabIndex = 62;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnOpenAddForm
            // 
            this.BtnOpenAddForm.BackColor = System.Drawing.Color.White;
            this.BtnOpenAddForm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnOpenAddForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnOpenAddForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnOpenAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenAddForm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenAddForm.ForeColor = System.Drawing.Color.Black;
            this.BtnOpenAddForm.Location = new System.Drawing.Point(175, 384);
            this.BtnOpenAddForm.Name = "BtnOpenAddForm";
            this.BtnOpenAddForm.Size = new System.Drawing.Size(126, 33);
            this.BtnOpenAddForm.TabIndex = 55;
            this.BtnOpenAddForm.Text = "Open Form";
            this.BtnOpenAddForm.UseVisualStyleBackColor = false;
            this.BtnOpenAddForm.Click += new System.EventHandler(this.BtnOpenAddForm_Click);
            // 
            // dataGridViewAllPara
            // 
            this.dataGridViewAllPara.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllPara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllPara.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewAllPara.Location = new System.Drawing.Point(18, 21);
            this.dataGridViewAllPara.Name = "dataGridViewAllPara";
            this.dataGridViewAllPara.Size = new System.Drawing.Size(1240, 357);
            this.dataGridViewAllPara.TabIndex = 61;
            // 
            // LblRecordNo
            // 
            this.LblRecordNo.AutoSize = true;
            this.LblRecordNo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecordNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblRecordNo.Location = new System.Drawing.Point(577, 389);
            this.LblRecordNo.Name = "LblRecordNo";
            this.LblRecordNo.Size = new System.Drawing.Size(93, 23);
            this.LblRecordNo.TabIndex = 60;
            this.LblRecordNo.Text = "Record No:";
            // 
            // LblDbLog
            // 
            this.LblDbLog.AutoSize = true;
            this.LblDbLog.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblDbLog.Location = new System.Drawing.Point(769, 389);
            this.LblDbLog.Name = "LblDbLog";
            this.LblDbLog.Size = new System.Drawing.Size(40, 23);
            this.LblDbLog.TabIndex = 59;
            this.LblDbLog.Text = "Log:";
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
            this.BtnExit.Location = new System.Drawing.Point(442, 384);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(129, 33);
            this.BtnExit.TabIndex = 59;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLoadRecords
            // 
            this.BtnLoadRecords.BackColor = System.Drawing.Color.White;
            this.BtnLoadRecords.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnLoadRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnLoadRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnLoadRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadRecords.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadRecords.ForeColor = System.Drawing.Color.Black;
            this.BtnLoadRecords.Location = new System.Drawing.Point(17, 384);
            this.BtnLoadRecords.Name = "BtnLoadRecords";
            this.BtnLoadRecords.Size = new System.Drawing.Size(152, 33);
            this.BtnLoadRecords.TabIndex = 54;
            this.BtnLoadRecords.Text = "Load All Records";
            this.BtnLoadRecords.UseVisualStyleBackColor = false;
            this.BtnLoadRecords.Click += new System.EventHandler(this.BtnLoadRecords_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(34, 468);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 221);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1271, 192);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Filter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboBoxFilterBy);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.BtnFilter);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.TxtFilterMsg);
            this.groupBox3.Controls.Add(this.ComboBoxFilterDistinctValues);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(20, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 165);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Level 1";
            // 
            // ComboBoxFilterBy
            // 
            this.ComboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterBy.FormattingEnabled = true;
            this.ComboBoxFilterBy.Location = new System.Drawing.Point(12, 80);
            this.ComboBoxFilterBy.Name = "ComboBoxFilterBy";
            this.ComboBoxFilterBy.Size = new System.Drawing.Size(237, 26);
            this.ComboBoxFilterBy.TabIndex = 78;
            this.ComboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterBy_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 77;
            this.label10.Text = "Filter By";
            // 
            // BtnFilter
            // 
            this.BtnFilter.BackColor = System.Drawing.Color.White;
            this.BtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFilter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.ForeColor = System.Drawing.Color.Black;
            this.BtnFilter.Location = new System.Drawing.Point(452, 28);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(130, 46);
            this.BtnFilter.TabIndex = 79;
            this.BtnFilter.Text = "Filter Level 1";
            this.BtnFilter.UseVisualStyleBackColor = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(260, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 23);
            this.label22.TabIndex = 86;
            this.label22.Text = "Distinct Values";
            // 
            // TxtFilterMsg
            // 
            this.TxtFilterMsg.Location = new System.Drawing.Point(12, 122);
            this.TxtFilterMsg.Name = "TxtFilterMsg";
            this.TxtFilterMsg.Size = new System.Drawing.Size(570, 24);
            this.TxtFilterMsg.TabIndex = 93;
            // 
            // ComboBoxFilterDistinctValues
            // 
            this.ComboBoxFilterDistinctValues.BackColor = System.Drawing.Color.White;
            this.ComboBoxFilterDistinctValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterDistinctValues.FormattingEnabled = true;
            this.ComboBoxFilterDistinctValues.Location = new System.Drawing.Point(264, 80);
            this.ComboBoxFilterDistinctValues.Name = "ComboBoxFilterDistinctValues";
            this.ComboBoxFilterDistinctValues.Size = new System.Drawing.Size(318, 26);
            this.ComboBoxFilterDistinctValues.TabIndex = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtFilterMsgLevel2);
            this.groupBox2.Controls.Add(this.ComboBoxFilterDistinctValuesLevel2);
            this.groupBox2.Controls.Add(this.BtnFilterLevel2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.ComboBoxFilterByLevel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(623, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 165);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Level 2";
            // 
            // TxtFilterMsgLevel2
            // 
            this.TxtFilterMsgLevel2.Location = new System.Drawing.Point(6, 122);
            this.TxtFilterMsgLevel2.Name = "TxtFilterMsgLevel2";
            this.TxtFilterMsgLevel2.Size = new System.Drawing.Size(599, 24);
            this.TxtFilterMsgLevel2.TabIndex = 101;
            // 
            // ComboBoxFilterDistinctValuesLevel2
            // 
            this.ComboBoxFilterDistinctValuesLevel2.BackColor = System.Drawing.Color.White;
            this.ComboBoxFilterDistinctValuesLevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterDistinctValuesLevel2.FormattingEnabled = true;
            this.ComboBoxFilterDistinctValuesLevel2.Location = new System.Drawing.Point(259, 80);
            this.ComboBoxFilterDistinctValuesLevel2.Name = "ComboBoxFilterDistinctValuesLevel2";
            this.ComboBoxFilterDistinctValuesLevel2.Size = new System.Drawing.Size(351, 26);
            this.ComboBoxFilterDistinctValuesLevel2.TabIndex = 104;
            // 
            // BtnFilterLevel2
            // 
            this.BtnFilterLevel2.BackColor = System.Drawing.Color.White;
            this.BtnFilterLevel2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnFilterLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnFilterLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.BtnFilterLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFilterLevel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilterLevel2.ForeColor = System.Drawing.Color.Black;
            this.BtnFilterLevel2.Location = new System.Drawing.Point(478, 23);
            this.BtnFilterLevel2.Name = "BtnFilterLevel2";
            this.BtnFilterLevel2.Size = new System.Drawing.Size(132, 46);
            this.BtnFilterLevel2.TabIndex = 101;
            this.BtnFilterLevel2.Text = "Filter Level 2";
            this.BtnFilterLevel2.UseVisualStyleBackColor = false;
            this.BtnFilterLevel2.Click += new System.EventHandler(this.BtnFilterLevel2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(255, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 23);
            this.label15.TabIndex = 103;
            this.label15.Text = "Distinct Values";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 23);
            this.label16.TabIndex = 101;
            this.label16.Text = "Filter By";
            // 
            // ComboBoxFilterByLevel2
            // 
            this.ComboBoxFilterByLevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterByLevel2.FormattingEnabled = true;
            this.ComboBoxFilterByLevel2.Location = new System.Drawing.Point(11, 80);
            this.ComboBoxFilterByLevel2.Name = "ComboBoxFilterByLevel2";
            this.ComboBoxFilterByLevel2.Size = new System.Drawing.Size(227, 26);
            this.ComboBoxFilterByLevel2.TabIndex = 102;
            this.ComboBoxFilterByLevel2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterByLevel2_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // FrmProgramRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmProgramRecord";
            this.Text = "CSAY Program Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProgramRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPara)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblRecordNo;
        private System.Windows.Forms.Label LblDbLog;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLoadRecords;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBoxFilterBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtFilterMsg;
        private System.Windows.Forms.ComboBox ComboBoxFilterDistinctValues;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtFilterMsgLevel2;
        private System.Windows.Forms.ComboBox ComboBoxFilterDistinctValuesLevel2;
        private System.Windows.Forms.Button BtnFilterLevel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ComboBoxFilterByLevel2;
        private System.Windows.Forms.DataGridView dataGridViewAllPara;
        private System.Windows.Forms.Button BtnOpenAddForm;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

