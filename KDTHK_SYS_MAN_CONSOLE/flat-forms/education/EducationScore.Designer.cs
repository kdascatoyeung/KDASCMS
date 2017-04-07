namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    partial class EducationScore
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvScore = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cstaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNonSubmit = new System.Windows.Forms.Button();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.btnNonSubmit);
            this.customPanel3.Controls.Add(this.btnSubmit);
            this.customPanel3.Controls.Add(this.customPanel2);
            this.customPanel3.Curvature = 1;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1230, 631);
            this.customPanel3.TabIndex = 54;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.Silver;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.dgvScore);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(3, 34);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1224, 594);
            this.customPanel2.TabIndex = 69;
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScore.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvScore.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvScore.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cstaff,
            this.cdatetime,
            this.cscore,
            this.ccompany});
            this.dgvScore.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScore.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvScore.Location = new System.Drawing.Point(3, 3);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvScore.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersVisible = false;
            this.dgvScore.SecondaryLength = 2;
            this.dgvScore.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvScore.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvScore.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvScore.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScore.Size = new System.Drawing.Size(1218, 588);
            this.dgvScore.TabIndex = 7;
            this.dgvScore.Tag = "category";
            this.dgvScore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvScore_MouseDown);
            // 
            // cstaff
            // 
            this.cstaff.DataPropertyName = "staff";
            this.cstaff.HeaderText = "Staff";
            this.cstaff.Name = "cstaff";
            this.cstaff.ReadOnly = true;
            // 
            // cdatetime
            // 
            this.cdatetime.DataPropertyName = "dt";
            this.cdatetime.HeaderText = "Datetime";
            this.cdatetime.Name = "cdatetime";
            this.cdatetime.ReadOnly = true;
            // 
            // cscore
            // 
            this.cscore.DataPropertyName = "score";
            this.cscore.FillWeight = 30F;
            this.cscore.HeaderText = "Score";
            this.cscore.Name = "cscore";
            this.cscore.ReadOnly = true;
            // 
            // ccompany
            // 
            this.ccompany.DataPropertyName = "company";
            this.ccompany.FillWeight = 40F;
            this.ccompany.HeaderText = "Company";
            this.ccompany.Name = "ccompany";
            this.ccompany.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 30);
            this.btnSubmit.TabIndex = 72;
            this.btnSubmit.Text = "Submitted";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnNonSubmit
            // 
            this.btnNonSubmit.BackColor = System.Drawing.Color.White;
            this.btnNonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnNonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonSubmit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnNonSubmit.Location = new System.Drawing.Point(117, 3);
            this.btnNonSubmit.Name = "btnNonSubmit";
            this.btnNonSubmit.Size = new System.Drawing.Size(108, 30);
            this.btnNonSubmit.TabIndex = 73;
            this.btnNonSubmit.Text = "Non-Submitted";
            this.btnNonSubmit.UseVisualStyleBackColor = false;
            this.btnNonSubmit.Click += new System.EventHandler(this.btnNonSubmit_Click);
            this.btnNonSubmit.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnNonSubmit.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // EducationScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationScore";
            this.Size = new System.Drawing.Size(1230, 631);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button btnNonSubmit;
        private System.Windows.Forms.Button btnSubmit;
    }
}
