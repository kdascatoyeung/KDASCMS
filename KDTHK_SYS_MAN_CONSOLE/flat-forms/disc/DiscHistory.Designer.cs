namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    partial class DiscHistory
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
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvHistory = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.btnExport = new System.Windows.Forms.Button();
            this.cfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.Silver;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.txtDiscId);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.btnExport);
            this.customPanel2.Controls.Add(this.btnSearch);
            this.customPanel2.Controls.Add(this.txtUser);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.txtFilename);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(3, 1);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(294, 644);
            this.customPanel2.TabIndex = 71;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSearch.Location = new System.Drawing.Point(172, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 27);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(84, 57);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(196, 27);
            this.txtUser.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "User";
            // 
            // txtFilename
            // 
            this.txtFilename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(84, 24);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(196, 27);
            this.txtFilename.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Filename";
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.Silver;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.dgvHistory);
            this.customPanel1.Curvature = 3;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(298, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(918, 644);
            this.customPanel1.TabIndex = 72;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHistory.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cfilename,
            this.cuser,
            this.cDisc,
            this.cdate,
            this.cby});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvHistory.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SecondaryLength = 2;
            this.dgvHistory.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvHistory.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvHistory.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvHistory.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(912, 638);
            this.dgvHistory.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnExport.Location = new System.Drawing.Point(58, 133);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 27);
            this.btnExport.TabIndex = 55;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // cfilename
            // 
            this.cfilename.DataPropertyName = "filename";
            this.cfilename.HeaderText = "Filename";
            this.cfilename.Name = "cfilename";
            this.cfilename.ReadOnly = true;
            // 
            // cuser
            // 
            this.cuser.DataPropertyName = "requester";
            this.cuser.HeaderText = "User";
            this.cuser.Name = "cuser";
            this.cuser.ReadOnly = true;
            // 
            // cDisc
            // 
            this.cDisc.DataPropertyName = "disc";
            this.cDisc.HeaderText = "Disc";
            this.cDisc.Name = "cDisc";
            this.cDisc.ReadOnly = true;
            // 
            // cdate
            // 
            this.cdate.DataPropertyName = "dt";
            this.cdate.HeaderText = "Finished Date";
            this.cdate.Name = "cdate";
            this.cdate.ReadOnly = true;
            // 
            // cby
            // 
            this.cby.DataPropertyName = "finby";
            this.cby.HeaderText = "By";
            this.cby.Name = "cby";
            this.cby.ReadOnly = true;
            // 
            // txtDiscId
            // 
            this.txtDiscId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscId.Location = new System.Drawing.Point(84, 90);
            this.txtDiscId.Name = "txtDiscId";
            this.txtDiscId.Size = new System.Drawing.Size(196, 27);
            this.txtDiscId.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Disc Id";
            // 
            // DiscHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiscHistory";
            this.Size = new System.Drawing.Size(1219, 648);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cby;
        private System.Windows.Forms.TextBox txtDiscId;
        private System.Windows.Forms.Label label4;
    }
}
