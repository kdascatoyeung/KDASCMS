namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormPermission
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
            this.dgvPermission = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capproval = new System.Windows.Forms.DataGridViewImageColumn();
            this.chandleby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
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
            this.customPanel3.Controls.Add(this.dgvPermission);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1217, 646);
            this.customPanel3.TabIndex = 52;
            // 
            // dgvPermission
            // 
            this.dgvPermission.AllowUserToAddRows = false;
            this.dgvPermission.AllowUserToDeleteRows = false;
            this.dgvPermission.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermission.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPermission.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvPermission.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvPermission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidle,
            this.cchaseno,
            this.cstatus,
            this.cmcategory,
            this.cmdate,
            this.cmcreatedby,
            this.cmstart,
            this.ctype,
            this.cuserid,
            this.capproval,
            this.chandleby});
            this.dgvPermission.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermission.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPermission.Location = new System.Drawing.Point(3, 3);
            this.dgvPermission.MultiSelect = false;
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvPermission.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvPermission.ReadOnly = true;
            this.dgvPermission.RowHeadersVisible = false;
            this.dgvPermission.SecondaryLength = 2;
            this.dgvPermission.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvPermission.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvPermission.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvPermission.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermission.Size = new System.Drawing.Size(1211, 640);
            this.dgvPermission.TabIndex = 7;
            this.dgvPermission.DoubleClick += new System.EventHandler(this.dgvPermission_DoubleClick);
            this.dgvPermission.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPermission_MouseDown);
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
            this.cidle.DataPropertyName = "idle";
            this.cidle.HeaderText = "Idle";
            this.cidle.Name = "cidle";
            this.cidle.ReadOnly = true;
            this.cidle.Width = 53;
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
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // cmstart
            // 
            this.cmstart.DataPropertyName = "sdate";
            this.cmstart.FillWeight = 50F;
            this.cmstart.HeaderText = "Start Date";
            this.cmstart.Name = "cmstart";
            this.cmstart.ReadOnly = true;
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.FillWeight = 50F;
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cuserid
            // 
            this.cuserid.DataPropertyName = "user";
            this.cuserid.HeaderText = "User";
            this.cuserid.Name = "cuserid";
            this.cuserid.ReadOnly = true;
            // 
            // capproval
            // 
            this.capproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capproval.DataPropertyName = "app";
            this.capproval.HeaderText = "Approval";
            this.capproval.Name = "capproval";
            this.capproval.ReadOnly = true;
            this.capproval.Width = 63;
            // 
            // chandleby
            // 
            this.chandleby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chandleby.DataPropertyName = "handledby";
            this.chandleby.HeaderText = "HandleBy";
            this.chandleby.Name = "chandleby";
            this.chandleby.ReadOnly = true;
            this.chandleby.Width = 84;
            // 
            // DataFormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormPermission";
            this.Size = new System.Drawing.Size(1217, 646);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvPermission;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuserid;
        private System.Windows.Forms.DataGridViewImageColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandleby;
    }
}
