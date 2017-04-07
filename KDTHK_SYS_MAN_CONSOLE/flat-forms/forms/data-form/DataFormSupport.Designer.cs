namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormSupport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSupport = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.advancedDataGridView1);
            this.customPanel3.Controls.Add(this.label2);
            this.customPanel3.Controls.Add(this.txtFilter);
            this.customPanel3.Controls.Add(this.label1);
            this.customPanel3.Controls.Add(this.dgvSupport);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1168, 623);
            this.customPanel3.TabIndex = 51;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidle,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.cassigned});
            this.advancedDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.advancedDataGridView1.DataSource = this.bindingSource1;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(3, 30);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1162, 590);
            this.advancedDataGridView1.TabIndex = 11;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.advancedDataGridView1.DoubleClick += new System.EventHandler(this.advancedDataGridView1_DoubleClick);
            this.advancedDataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.advancedDataGridView1_MouseDown);
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(934, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(231, 23);
            this.txtFilter.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtFilter, "Filter by Month / Title / Applicant");
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Row Count : ";
            // 
            // dgvSupport
            // 
            this.dgvSupport.AllowUserToAddRows = false;
            this.dgvSupport.AllowUserToDeleteRows = false;
            this.dgvSupport.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvSupport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSupport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSupport.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvSupport.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvSupport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cchaseno,
            this.cstatus,
            this.cmcategory,
            this.cmdate,
            this.cmcreatedby,
            this.ctitle,
            this.cmstart,
            this.cmend});
            this.dgvSupport.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupport.Location = new System.Drawing.Point(854, 3);
            this.dgvSupport.MultiSelect = false;
            this.dgvSupport.Name = "dgvSupport";
            this.dgvSupport.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvSupport.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvSupport.ReadOnly = true;
            this.dgvSupport.RowHeadersVisible = false;
            this.dgvSupport.SecondaryLength = 2;
            this.dgvSupport.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvSupport.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvSupport.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvSupport.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvSupport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupport.Size = new System.Drawing.Size(26, 24);
            this.dgvSupport.TabIndex = 7;
            this.dgvSupport.Visible = false;
            this.dgvSupport.DoubleClick += new System.EventHandler(this.dgvSupport_DoubleClick);
            this.dgvSupport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSupport_MouseDown);
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.FillWeight = 50F;
            this.cchaseno.HeaderText = "ChaseNo.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "st";
            this.cstatus.FillWeight = 45F;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cmcategory
            // 
            this.cmcategory.DataPropertyName = "category";
            this.cmcategory.FillWeight = 40F;
            this.cmcategory.HeaderText = "Category";
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "created";
            this.cmdate.FillWeight = 50F;
            this.cmdate.HeaderText = "Created";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
            // 
            // cmcreatedby
            // 
            this.cmcreatedby.DataPropertyName = "applicant";
            this.cmcreatedby.FillWeight = 70F;
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // ctitle
            // 
            this.ctitle.DataPropertyName = "title";
            this.ctitle.HeaderText = "Title";
            this.ctitle.Name = "ctitle";
            this.ctitle.ReadOnly = true;
            // 
            // cmstart
            // 
            this.cmstart.DataPropertyName = "sdate";
            this.cmstart.FillWeight = 50F;
            this.cmstart.HeaderText = "Start Date";
            this.cmstart.Name = "cmstart";
            this.cmstart.ReadOnly = true;
            // 
            // cmend
            // 
            this.cmend.DataPropertyName = "edate";
            this.cmend.FillWeight = 50F;
            this.cmend.HeaderText = "End Date";
            this.cmend.Name = "cmend";
            this.cmend.ReadOnly = true;
            // 
            // cidle
            // 
            this.cidle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidle.DataPropertyName = "idle";
            this.cidle.HeaderText = "Idle";
            this.cidle.MinimumWidth = 22;
            this.cidle.Name = "cidle";
            this.cidle.ReadOnly = true;
            this.cidle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cidle.Width = 53;
            // 
            // c1
            // 
            this.c1.DataPropertyName = "chaseno";
            this.c1.HeaderText = "ChaseNo.";
            this.c1.MinimumWidth = 22;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c2
            // 
            this.c2.DataPropertyName = "st";
            this.c2.HeaderText = "Status";
            this.c2.MinimumWidth = 22;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c3
            // 
            this.c3.DataPropertyName = "category";
            this.c3.HeaderText = "Category";
            this.c3.MinimumWidth = 22;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c4
            // 
            this.c4.DataPropertyName = "created";
            this.c4.HeaderText = "Created";
            this.c4.MinimumWidth = 22;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c5
            // 
            this.c5.DataPropertyName = "applicant";
            this.c5.HeaderText = "Applicant";
            this.c5.MinimumWidth = 22;
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c6
            // 
            this.c6.DataPropertyName = "title";
            this.c6.HeaderText = "Title";
            this.c6.MinimumWidth = 22;
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.c6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c7
            // 
            this.c7.DataPropertyName = "sdate";
            this.c7.HeaderText = "Start Date";
            this.c7.MinimumWidth = 22;
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            this.c7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // c8
            // 
            this.c8.DataPropertyName = "edate";
            this.c8.HeaderText = "End Date";
            this.c8.MinimumWidth = 22;
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            this.c8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cassigned
            // 
            this.cassigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cassigned.DataPropertyName = "handledby";
            this.cassigned.HeaderText = "HandleBy";
            this.cassigned.MinimumWidth = 22;
            this.cassigned.Name = "cassigned";
            this.cassigned.ReadOnly = true;
            this.cassigned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cassigned.Width = 84;
            // 
            // DataFormSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormSupport";
            this.Size = new System.Drawing.Size(1168, 623);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassigned;
    }
}
