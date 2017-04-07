namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    partial class EducationResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvResult = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cquestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdthk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdthkno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdhk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdhkno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdasno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.customPanel2);
            this.customPanel3.Curvature = 1;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1192, 642);
            this.customPanel3.TabIndex = 53;
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
            this.customPanel2.Controls.Add(this.dgvResult);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(3, 38);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1186, 601);
            this.customPanel2.TabIndex = 69;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResult.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvResult.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cquestion,
            this.ckdthk,
            this.ckdthkno,
            this.ckdhk,
            this.ckdhkno,
            this.ckdas,
            this.ckdasno,
            this.ctotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvResult.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SecondaryLength = 2;
            this.dgvResult.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvResult.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvResult.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvResult.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResult.Size = new System.Drawing.Size(1180, 595);
            this.dgvResult.TabIndex = 7;
            this.dgvResult.Tag = "category";
            // 
            // cquestion
            // 
            this.cquestion.DataPropertyName = "question";
            this.cquestion.HeaderText = "Question";
            this.cquestion.Name = "cquestion";
            this.cquestion.ReadOnly = true;
            // 
            // ckdthk
            // 
            this.ckdthk.DataPropertyName = "kdthk";
            this.ckdthk.FillWeight = 20F;
            this.ckdthk.HeaderText = "KDTHK";
            this.ckdthk.Name = "ckdthk";
            this.ckdthk.ReadOnly = true;
            // 
            // ckdthkno
            // 
            this.ckdthkno.DataPropertyName = "kdthkno";
            this.ckdthkno.FillWeight = 20F;
            this.ckdthkno.HeaderText = "No.";
            this.ckdthkno.Name = "ckdthkno";
            this.ckdthkno.ReadOnly = true;
            this.ckdthkno.Visible = false;
            // 
            // ckdhk
            // 
            this.ckdhk.DataPropertyName = "kdhk";
            this.ckdhk.FillWeight = 20F;
            this.ckdhk.HeaderText = "KDHK";
            this.ckdhk.Name = "ckdhk";
            this.ckdhk.ReadOnly = true;
            // 
            // ckdhkno
            // 
            this.ckdhkno.DataPropertyName = "kdhkno";
            this.ckdhkno.FillWeight = 20F;
            this.ckdhkno.HeaderText = "No.";
            this.ckdhkno.Name = "ckdhkno";
            this.ckdhkno.ReadOnly = true;
            this.ckdhkno.Visible = false;
            // 
            // ckdas
            // 
            this.ckdas.DataPropertyName = "kdas";
            this.ckdas.FillWeight = 20F;
            this.ckdas.HeaderText = "KDAS";
            this.ckdas.Name = "ckdas";
            this.ckdas.ReadOnly = true;
            // 
            // ckdasno
            // 
            this.ckdasno.DataPropertyName = "kdasno";
            this.ckdasno.FillWeight = 20F;
            this.ckdasno.HeaderText = "No.";
            this.ckdasno.Name = "ckdasno";
            this.ckdasno.ReadOnly = true;
            this.ckdasno.Visible = false;
            // 
            // ctotal
            // 
            this.ctotal.DataPropertyName = "total";
            this.ctotal.FillWeight = 20F;
            this.ctotal.HeaderText = "Total";
            this.ctotal.Name = "ctotal";
            this.ctotal.ReadOnly = true;
            // 
            // EducationResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationResult";
            this.Size = new System.Drawing.Size(1192, 642);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn cquestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdthk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdthkno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdhk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdhkno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdasno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotal;
    }
}
