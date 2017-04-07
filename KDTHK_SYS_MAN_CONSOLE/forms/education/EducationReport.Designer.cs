namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.dgvRecord = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.colEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnDownload
            // 
            this.tsbtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDownload.Image")));
            this.tsbtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDownload.Name = "tsbtnDownload";
            this.tsbtnDownload.Size = new System.Drawing.Size(83, 22);
            this.tsbtnDownload.Text = "Download";
            this.tsbtnDownload.Click += new System.EventHandler(this.tsbtnDownload_Click);
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
            this.dgvRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecord.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvRecord.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvRecord.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEducation,
            this.colCompany,
            this.colname,
            this.colscore,
            this.colid});
            this.dgvRecord.Location = new System.Drawing.Point(0, 24);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvRecord.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.SecondaryLength = 2;
            this.dgvRecord.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvRecord.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvRecord.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvRecord.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(1184, 606);
            this.dgvRecord.TabIndex = 5;
            // 
            // colEducation
            // 
            this.colEducation.DataPropertyName = "education";
            this.colEducation.HeaderText = "Education";
            this.colEducation.Name = "colEducation";
            this.colEducation.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.DataPropertyName = "name";
            this.colname.HeaderText = "Name";
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            // 
            // colscore
            // 
            this.colscore.DataPropertyName = "score";
            this.colscore.HeaderText = "Marks";
            this.colscore.Name = "colscore";
            this.colscore.ReadOnly = true;
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // EducationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationReport";
            this.Size = new System.Drawing.Size(1184, 633);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
    }
}
