namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    partial class DiscIdle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvProcessing = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpathcopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.finishedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTotal = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.crequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.customPanel1.Controls.Add(this.dgvProcessing);
            this.customPanel1.Controls.Add(this.dgvTotal);
            this.customPanel1.Curvature = 3;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(3, 36);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1152, 604);
            this.customPanel1.TabIndex = 73;
            // 
            // dgvProcessing
            // 
            this.dgvProcessing.AllowUserToAddRows = false;
            this.dgvProcessing.AllowUserToDeleteRows = false;
            this.dgvProcessing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvProcessing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcessing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessing.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcessing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProcessing.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvProcessing.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvProcessing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.cpathcopy});
            this.dgvProcessing.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessing.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcessing.Location = new System.Drawing.Point(3, 3);
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvProcessing.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvProcessing.ReadOnly = true;
            this.dgvProcessing.RowHeadersVisible = false;
            this.dgvProcessing.SecondaryLength = 2;
            this.dgvProcessing.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvProcessing.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvProcessing.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvProcessing.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvProcessing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessing.Size = new System.Drawing.Size(1146, 598);
            this.dgvProcessing.TabIndex = 7;
            this.dgvProcessing.Visible = false;
            this.dgvProcessing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProcessing_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lastaccess";
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Access";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "filename";
            this.dataGridViewTextBoxColumn2.HeaderText = "Filename";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "owner";
            this.dataGridViewTextBoxColumn3.HeaderText = "User";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "path";
            this.dataGridViewTextBoxColumn4.HeaderText = "path";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "st";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "disc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Disc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // cpathcopy
            // 
            this.cpathcopy.DataPropertyName = "pathcopy";
            this.cpathcopy.HeaderText = "pathcopy";
            this.cpathcopy.Name = "cpathcopy";
            this.cpathcopy.ReadOnly = true;
            this.cpathcopy.Visible = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finishedToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(122, 26);
            // 
            // finishedToolStripMenuItem1
            // 
            this.finishedToolStripMenuItem1.Name = "finishedToolStripMenuItem1";
            this.finishedToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.finishedToolStripMenuItem1.Text = "Finished";
            this.finishedToolStripMenuItem1.Click += new System.EventHandler(this.finishedToolStripMenuItem_Click);
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
            this.crequested,
            this.cfilename,
            this.cuser,
            this.cpath,
            this.cstatus,
            this.cdisc,
            this.cimg});
            this.dgvTotal.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dgvTotal.Size = new System.Drawing.Size(1146, 598);
            this.dgvTotal.TabIndex = 7;
            this.dgvTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTotal_MouseDown);
            // 
            // crequested
            // 
            this.crequested.DataPropertyName = "lastaccess";
            this.crequested.HeaderText = "Last Access";
            this.crequested.Name = "crequested";
            this.crequested.ReadOnly = true;
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
            this.cuser.DataPropertyName = "owner";
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
            // cstatus
            // 
            this.cstatus.DataPropertyName = "st";
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Visible = false;
            // 
            // cdisc
            // 
            this.cdisc.DataPropertyName = "disc";
            this.cdisc.HeaderText = "Disc";
            this.cdisc.Name = "cdisc";
            this.cdisc.ReadOnly = true;
            this.cdisc.Visible = false;
            // 
            // cimg
            // 
            this.cimg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cimg.DataPropertyName = "check";
            this.cimg.HeaderText = "Checked";
            this.cimg.Name = "cimg";
            this.cimg.ReadOnly = true;
            this.cimg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cimg.Width = 77;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getSizeToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.setupToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // getSizeToolStripMenuItem
            // 
            this.getSizeToolStripMenuItem.Name = "getSizeToolStripMenuItem";
            this.getSizeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.getSizeToolStripMenuItem.Text = "Get Size";
            this.getSizeToolStripMenuItem.Click += new System.EventHandler(this.getSizeToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnLoad.Location = new System.Drawing.Point(3, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 26);
            this.btnLoad.TabIndex = 74;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnProcessing
            // 
            this.btnProcessing.BackColor = System.Drawing.Color.White;
            this.btnProcessing.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProcessing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessing.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnProcessing.Location = new System.Drawing.Point(117, 7);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(108, 26);
            this.btnProcessing.TabIndex = 75;
            this.btnProcessing.Text = "Processing";
            this.btnProcessing.UseVisualStyleBackColor = false;
            this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(973, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 23);
            this.txtSearch.TabIndex = 76;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "Search";
            // 
            // DiscIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnProcessing);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiscIdle";
            this.Size = new System.Drawing.Size(1155, 640);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvTotal;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.Button btnProcessing;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvProcessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn crequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem finishedToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpathcopy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;

    }
}
