namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormAsset
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
            this.dgvAsset = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capproval = new System.Windows.Forms.DataGridViewImageColumn();
            this.creturn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chandledby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
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
            this.customPanel3.Controls.Add(this.dgvAsset);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1166, 645);
            this.customPanel3.TabIndex = 52;
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
            this.cidle,
            this.cchaseno,
            this.cstatus,
            this.cmcategory,
            this.cmdate,
            this.cmcreatedby,
            this.cmstart,
            this.cmend,
            this.cdevice,
            this.cinout,
            this.capproval,
            this.creturn,
            this.chandledby});
            this.dgvAsset.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsset.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsset.Location = new System.Drawing.Point(3, 3);
            this.dgvAsset.MultiSelect = false;
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
            this.dgvAsset.Size = new System.Drawing.Size(1160, 639);
            this.dgvAsset.TabIndex = 7;
            this.dgvAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            this.dgvAsset.DoubleClick += new System.EventHandler(this.dgvAsset_DoubleClick);
            this.dgvAsset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAsset_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::KDTHK_SYS_MAN_CONSOLE.Properties.Resources.cross_icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cidle
            // 
            this.cidle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidle.HeaderText = "Idle";
            this.cidle.Name = "cidle";
            this.cidle.ReadOnly = true;
            this.cidle.Width = 53;
            // 
            // cchaseno
            // 
            this.cchaseno.HeaderText = "ChaseNo.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cstatus.DataPropertyName = "st";
            this.cstatus.FillWeight = 45F;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Width = 66;
            // 
            // cmcategory
            // 
            this.cmcategory.DataPropertyName = "category";
            this.cmcategory.HeaderText = "Category";
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "created";
            this.cmdate.HeaderText = "Created";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
            // 
            // cmcreatedby
            // 
            this.cmcreatedby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cmcreatedby.DataPropertyName = "applicant";
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            this.cmcreatedby.Width = 85;
            // 
            // cmstart
            // 
            this.cmstart.DataPropertyName = "sdate";
            this.cmstart.HeaderText = "Start Date";
            this.cmstart.Name = "cmstart";
            this.cmstart.ReadOnly = true;
            // 
            // cmend
            // 
            this.cmend.DataPropertyName = "edate";
            this.cmend.HeaderText = "Return Date";
            this.cmend.Name = "cmend";
            this.cmend.ReadOnly = true;
            // 
            // cdevice
            // 
            this.cdevice.HeaderText = "Device";
            this.cdevice.Name = "cdevice";
            this.cdevice.ReadOnly = true;
            // 
            // cinout
            // 
            this.cinout.HeaderText = "In/Out";
            this.cinout.Name = "cinout";
            this.cinout.ReadOnly = true;
            // 
            // capproval
            // 
            this.capproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capproval.HeaderText = "Approval";
            this.capproval.Name = "capproval";
            this.capproval.ReadOnly = true;
            this.capproval.Width = 63;
            // 
            // creturn
            // 
            this.creturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creturn.HeaderText = "Return";
            this.creturn.Name = "creturn";
            this.creturn.ReadOnly = true;
            this.creturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creturn.Text = "Return";
            // 
            // chandledby
            // 
            this.chandledby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chandledby.HeaderText = "HandleBy";
            this.chandledby.Name = "chandledby";
            this.chandledby.ReadOnly = true;
            this.chandledby.Width = 84;
            // 
            // DataFormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormAsset";
            this.Size = new System.Drawing.Size(1166, 645);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvAsset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinout;
        private System.Windows.Forms.DataGridViewImageColumn capproval;
        private System.Windows.Forms.DataGridViewButtonColumn creturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandledby;
    }
}
