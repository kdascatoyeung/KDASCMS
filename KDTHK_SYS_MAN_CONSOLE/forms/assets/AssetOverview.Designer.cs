namespace KDTHK_SYS_MAN_CONSOLE.forms.assets
{
    partial class AssetOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetOverview));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new CustomUtil.controls.panel.CustomPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvAsset = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Controls.Add(this.toolStrip1);
            this.pnlMain.Controls.Add(this.dgvAsset);
            this.pnlMain.Curvature = 1;
            this.pnlMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1204, 639);
            this.pnlMain.TabIndex = 10;
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
            this.tsbtnRefresh,
            this.tsbtnDelete,
            this.txtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(1, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(68, 22);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(48, 22);
            this.tsbtnDelete.Text = "Add";
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 25);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvAsset
            // 
            this.dgvAsset.AllowUserToAddRows = false;
            this.dgvAsset.AllowUserToDeleteRows = false;
            this.dgvAsset.AllowUserToResizeRows = false;
            this.dgvAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsset.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
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
            this.cstatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsset.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsset.Location = new System.Drawing.Point(3, 28);
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
            this.dgvAsset.Size = new System.Drawing.Size(1198, 608);
            this.dgvAsset.TabIndex = 6;
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
            // AssetOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetOverview";
            this.Size = new System.Drawing.Size(1204, 639);
            this.pnlMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cend;
        private System.Windows.Forms.DataGridViewTextBoxColumn clong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
    }
}
