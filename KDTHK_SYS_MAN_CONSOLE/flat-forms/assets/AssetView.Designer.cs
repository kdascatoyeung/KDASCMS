namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.assets
{
    partial class AssetView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAsset = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvTotal = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cborrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsset
            // 
            this.dgvAsset.AllowUserToAddRows = false;
            this.dgvAsset.AllowUserToDeleteRows = false;
            this.dgvAsset.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvAsset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsset.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAsset.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvAsset.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvAsset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cname,
            this.ccategory,
            this.ccreatedby,
            this.cstart,
            this.cend,
            this.clong,
            this.ccontent,
            this.cstatus,
            this.cid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsset.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsset.Location = new System.Drawing.Point(3, 3);
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvAsset.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvAsset.ReadOnly = true;
            this.dgvAsset.RowHeadersVisible = false;
            this.dgvAsset.SecondaryLength = 2;
            this.dgvAsset.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvAsset.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvAsset.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvAsset.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsset.Size = new System.Drawing.Size(796, 601);
            this.dgvAsset.TabIndex = 7;
            this.dgvAsset.DoubleClick += new System.EventHandler(this.dgvAsset_DoubleClick);
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
            this.customPanel1.Controls.Add(this.dgvAsset);
            this.customPanel1.Curvature = 3;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(402, 16);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(802, 607);
            this.customPanel1.TabIndex = 8;
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
            this.customPanel2.Location = new System.Drawing.Point(22, 16);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(374, 607);
            this.customPanel2.TabIndex = 9;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridViewTextBoxColumn2,
            this.ctotal,
            this.cstock,
            this.cborrow});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotal.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvTotal.Size = new System.Drawing.Size(368, 601);
            this.dgvTotal.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ctotal
            // 
            this.ctotal.FillWeight = 30F;
            this.ctotal.HeaderText = "Total";
            this.ctotal.Name = "ctotal";
            this.ctotal.ReadOnly = true;
            // 
            // cstock
            // 
            this.cstock.FillWeight = 30F;
            this.cstock.HeaderText = "Stock";
            this.cstock.Name = "cstock";
            this.cstock.ReadOnly = true;
            // 
            // cborrow
            // 
            this.cborrow.FillWeight = 30F;
            this.cborrow.HeaderText = "Out";
            this.cborrow.Name = "cborrow";
            this.cborrow.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.FillWeight = 50F;
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // ccategory
            // 
            this.ccategory.DataPropertyName = "category";
            this.ccategory.FillWeight = 50F;
            this.ccategory.HeaderText = "Category";
            this.ccategory.Name = "ccategory";
            this.ccategory.ReadOnly = true;
            // 
            // ccreatedby
            // 
            this.ccreatedby.DataPropertyName = "applicant";
            this.ccreatedby.FillWeight = 50F;
            this.ccreatedby.HeaderText = "Applicant";
            this.ccreatedby.Name = "ccreatedby";
            this.ccreatedby.ReadOnly = true;
            // 
            // cstart
            // 
            this.cstart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cstart.DataPropertyName = "startdate";
            this.cstart.HeaderText = "Start";
            this.cstart.Name = "cstart";
            this.cstart.ReadOnly = true;
            this.cstart.Width = 58;
            // 
            // cend
            // 
            this.cend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cend.DataPropertyName = "enddate";
            this.cend.HeaderText = "End";
            this.cend.Name = "cend";
            this.cend.ReadOnly = true;
            this.cend.Width = 52;
            // 
            // clong
            // 
            this.clong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clong.DataPropertyName = "longterm";
            this.clong.HeaderText = "Long-Term";
            this.clong.Name = "clong";
            this.clong.ReadOnly = true;
            this.clong.Width = 87;
            // 
            // ccontent
            // 
            this.ccontent.DataPropertyName = "remarks";
            this.ccontent.HeaderText = "Remarks";
            this.ccontent.Name = "ccontent";
            this.ccontent.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cstatus.DataPropertyName = "st";
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Width = 66;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // AssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetView";
            this.Size = new System.Drawing.Size(1219, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.datagrid.CustomDatagrid dgvAsset;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cborrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}
