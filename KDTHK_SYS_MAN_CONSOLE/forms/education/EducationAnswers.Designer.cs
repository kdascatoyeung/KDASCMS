namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationAnswers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationAnswers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.dgvQuestion = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcontentjp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmgtno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
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
            this.tsbtnUpload,
            this.tsbtnTemplate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnUpload
            // 
            this.tsbtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpload.Image")));
            this.tsbtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpload.Name = "tsbtnUpload";
            this.tsbtnUpload.Size = new System.Drawing.Size(67, 22);
            this.tsbtnUpload.Text = "Upload";
            this.tsbtnUpload.Click += new System.EventHandler(this.tsbtnUpload_Click);
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.AllowUserToAddRows = false;
            this.dgvQuestion.AllowUserToDeleteRows = false;
            this.dgvQuestion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvQuestion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvQuestion.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvQuestion.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colcontent,
            this.colcontentjp,
            this.colmgtno});
            this.dgvQuestion.Location = new System.Drawing.Point(0, 25);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvQuestion.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvQuestion.ReadOnly = true;
            this.dgvQuestion.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvQuestion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestion.SecondaryLength = 2;
            this.dgvQuestion.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvQuestion.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvQuestion.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvQuestion.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestion.Size = new System.Drawing.Size(1190, 619);
            this.dgvQuestion.TabIndex = 4;
            this.dgvQuestion.DoubleClick += new System.EventHandler(this.dgvQuestion_DoubleClick);
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.FillWeight = 13.11756F;
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // colcontent
            // 
            this.colcontent.DataPropertyName = "content";
            this.colcontent.FillWeight = 150F;
            this.colcontent.HeaderText = "CONTENT (TC)";
            this.colcontent.Name = "colcontent";
            this.colcontent.ReadOnly = true;
            // 
            // colcontentjp
            // 
            this.colcontentjp.DataPropertyName = "contentjp";
            this.colcontentjp.FillWeight = 150F;
            this.colcontentjp.HeaderText = "CONTENT (JP)";
            this.colcontentjp.Name = "colcontentjp";
            this.colcontentjp.ReadOnly = true;
            // 
            // colmgtno
            // 
            this.colmgtno.DataPropertyName = "mgtno";
            this.colmgtno.FillWeight = 81.76609F;
            this.colmgtno.HeaderText = "MGT NO.";
            this.colmgtno.Name = "colmgtno";
            this.colmgtno.ReadOnly = true;
            // 
            // tsbtnTemplate
            // 
            this.tsbtnTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTemplate.Image")));
            this.tsbtnTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTemplate.Name = "tsbtnTemplate";
            this.tsbtnTemplate.Size = new System.Drawing.Size(76, 22);
            this.tsbtnTemplate.Text = "Template";
            this.tsbtnTemplate.Click += new System.EventHandler(this.tsbtnTemplate_Click);
            // 
            // EducationAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvQuestion);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationAnswers";
            this.Size = new System.Drawing.Size(1190, 647);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcontentjp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmgtno;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
    }
}
