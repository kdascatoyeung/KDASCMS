namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    partial class EducationUser
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvUser = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnKDTHK = new System.Windows.Forms.Button();
            this.btnKDAS = new System.Windows.Forms.Button();
            this.btnKDHK = new System.Windows.Forms.Button();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.btnKDHK);
            this.customPanel3.Controls.Add(this.btnKDAS);
            this.customPanel3.Controls.Add(this.btnKDTHK);
            this.customPanel3.Controls.Add(this.btnAll);
            this.customPanel3.Controls.Add(this.btnUpdate);
            this.customPanel3.Controls.Add(this.btnUpload);
            this.customPanel3.Controls.Add(this.customPanel2);
            this.customPanel3.Curvature = 1;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1202, 638);
            this.customPanel3.TabIndex = 54;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnUpdate.Location = new System.Drawing.Point(1088, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 30);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnUpload.Location = new System.Drawing.Point(3, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 30);
            this.btnUpload.TabIndex = 70;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            this.btnUpload.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnUpload.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
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
            this.customPanel2.Controls.Add(this.dgvUser);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(3, 38);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1196, 597);
            this.customPanel2.TabIndex = 69;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUser.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvUser.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cname,
            this.ccompany});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvUser.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SecondaryLength = 2;
            this.dgvUser.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvUser.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvUser.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvUser.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUser.Size = new System.Drawing.Size(1190, 591);
            this.dgvUser.TabIndex = 7;
            this.dgvUser.Tag = "category";
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.FillWeight = 40F;
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // ccompany
            // 
            this.ccompany.DataPropertyName = "company";
            this.ccompany.FillWeight = 40F;
            this.ccompany.HeaderText = "Company";
            this.ccompany.Name = "ccompany";
            this.ccompany.ReadOnly = true;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAll.Location = new System.Drawing.Point(117, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(108, 30);
            this.btnAll.TabIndex = 72;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.btnAll.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnAll.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnKDTHK
            // 
            this.btnKDTHK.BackColor = System.Drawing.Color.White;
            this.btnKDTHK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnKDTHK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnKDTHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKDTHK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKDTHK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnKDTHK.Location = new System.Drawing.Point(231, 5);
            this.btnKDTHK.Name = "btnKDTHK";
            this.btnKDTHK.Size = new System.Drawing.Size(108, 30);
            this.btnKDTHK.TabIndex = 73;
            this.btnKDTHK.Text = "KDTHK";
            this.btnKDTHK.UseVisualStyleBackColor = false;
            this.btnKDTHK.Click += new System.EventHandler(this.btnKDTHK_Click);
            this.btnKDTHK.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnKDTHK.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnKDAS
            // 
            this.btnKDAS.BackColor = System.Drawing.Color.White;
            this.btnKDAS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnKDAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnKDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKDAS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKDAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnKDAS.Location = new System.Drawing.Point(345, 5);
            this.btnKDAS.Name = "btnKDAS";
            this.btnKDAS.Size = new System.Drawing.Size(108, 30);
            this.btnKDAS.TabIndex = 74;
            this.btnKDAS.Text = "KDAS";
            this.btnKDAS.UseVisualStyleBackColor = false;
            this.btnKDAS.Click += new System.EventHandler(this.btnKDAS_Click);
            this.btnKDAS.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnKDAS.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnKDHK
            // 
            this.btnKDHK.BackColor = System.Drawing.Color.White;
            this.btnKDHK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnKDHK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnKDHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKDHK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKDHK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnKDHK.Location = new System.Drawing.Point(459, 5);
            this.btnKDHK.Name = "btnKDHK";
            this.btnKDHK.Size = new System.Drawing.Size(108, 30);
            this.btnKDHK.TabIndex = 75;
            this.btnKDHK.Text = "KDHK";
            this.btnKDHK.UseVisualStyleBackColor = false;
            this.btnKDHK.Click += new System.EventHandler(this.btnKDHK_Click);
            this.btnKDHK.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnKDHK.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // EducationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationUser";
            this.Size = new System.Drawing.Size(1202, 638);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvUser;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccompany;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnKDTHK;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnKDHK;
        private System.Windows.Forms.Button btnKDAS;
    }
}
