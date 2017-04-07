namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    partial class DiscView
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
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvTotal = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccopypath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisc
            // 
            this.txtDisc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisc.Location = new System.Drawing.Point(119, 150);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(196, 27);
            this.txtDisc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Disc Id";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnUpload.Location = new System.Drawing.Point(539, 59);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 27);
            this.btnUpload.TabIndex = 40;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(119, 183);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(196, 27);
            this.txtFilename.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Filename";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(119, 216);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(196, 27);
            this.txtUser.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "User";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSearch.Location = new System.Drawing.Point(207, 249);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 27);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.MouseEnter += new System.EventHandler(this.ButtonMouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnDownload.Location = new System.Drawing.Point(81, 324);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(108, 27);
            this.btnDownload.TabIndex = 46;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(78, 26);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(455, 27);
            this.txtDirectory.TabIndex = 48;
            this.txtDirectory.Text = "\\\\kdthk-dm1\\dvdstorage$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Copy To";
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
            this.customPanel2.Controls.Add(this.dgvTotal);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(385, 175);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(668, 456);
            this.customPanel2.TabIndex = 50;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTotal.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvTotal.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cfilename,
            this.cuser,
            this.cpath,
            this.ccopypath,
            this.cid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotal.Location = new System.Drawing.Point(3, 3);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvTotal.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            this.dgvTotal.SecondaryLength = 2;
            this.dgvTotal.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvTotal.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvTotal.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvTotal.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotal.Size = new System.Drawing.Size(662, 450);
            this.dgvTotal.TabIndex = 7;
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
            this.cuser.DataPropertyName = "user";
            this.cuser.HeaderText = "User";
            this.cuser.Name = "cuser";
            this.cuser.ReadOnly = true;
            // 
            // cpath
            // 
            this.cpath.DataPropertyName = "path";
            this.cpath.HeaderText = "path";
            this.cpath.Name = "cpath";
            this.cpath.ReadOnly = true;
            // 
            // ccopypath
            // 
            this.ccopypath.DataPropertyName = "newpath";
            this.ccopypath.HeaderText = "copypath";
            this.ccopypath.Name = "ccopypath";
            this.ccopypath.ReadOnly = true;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "disc";
            this.cid.HeaderText = "Disc";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 104);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Disc Id";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 27);
            this.textBox1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button1.Location = new System.Drawing.Point(653, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 51;
            this.button1.Text = "Sizing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiscView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiscView";
            this.Size = new System.Drawing.Size(1199, 643);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label4;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccopypath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
