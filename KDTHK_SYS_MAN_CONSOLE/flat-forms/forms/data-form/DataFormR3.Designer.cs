namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormR3
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
            this.dgvR3 = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crefno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvR3)).BeginInit();
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
            this.customPanel3.Controls.Add(this.dgvR3);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1185, 633);
            this.customPanel3.TabIndex = 53;
            // 
            // dgvR3
            // 
            this.dgvR3.AllowUserToAddRows = false;
            this.dgvR3.AllowUserToDeleteRows = false;
            this.dgvR3.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvR3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvR3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvR3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvR3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvR3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvR3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvR3.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvR3.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvR3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvR3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvR3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crefno,
            this.cchaseno,
            this.cstatus,
            this.cmdate,
            this.cmcreatedby,
            this.cmstart,
            this.cmcategory,
            this.ctype});
            this.dgvR3.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvR3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvR3.Location = new System.Drawing.Point(3, 3);
            this.dgvR3.MultiSelect = false;
            this.dgvR3.Name = "dgvR3";
            this.dgvR3.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvR3.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvR3.ReadOnly = true;
            this.dgvR3.RowHeadersVisible = false;
            this.dgvR3.SecondaryLength = 2;
            this.dgvR3.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvR3.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvR3.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvR3.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvR3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvR3.Size = new System.Drawing.Size(1179, 627);
            this.dgvR3.TabIndex = 7;
            this.dgvR3.DoubleClick += new System.EventHandler(this.dgvR3_DoubleClick);
            this.dgvR3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPermission_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // crefno
            // 
            this.crefno.DataPropertyName = "refno";
            this.crefno.FillWeight = 30F;
            this.crefno.HeaderText = "Ref No.";
            this.crefno.Name = "crefno";
            this.crefno.ReadOnly = true;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.FillWeight = 29.37177F;
            this.cchaseno.HeaderText = "ChaseNo.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "st";
            this.cstatus.FillWeight = 26.43459F;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "created";
            this.cmdate.FillWeight = 29.37177F;
            this.cmdate.HeaderText = "Created";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
            // 
            // cmcreatedby
            // 
            this.cmcreatedby.DataPropertyName = "applicant";
            this.cmcreatedby.FillWeight = 58.74354F;
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // cmstart
            // 
            this.cmstart.DataPropertyName = "sdate";
            this.cmstart.FillWeight = 29.37177F;
            this.cmstart.HeaderText = "Start Date";
            this.cmstart.Name = "cmstart";
            this.cmstart.ReadOnly = true;
            // 
            // cmcategory
            // 
            this.cmcategory.DataPropertyName = "category";
            this.cmcategory.FillWeight = 30F;
            this.cmcategory.HeaderText = "Category";
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.ReadOnly = true;
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.FillWeight = 29.37177F;
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::KDTHK_SYS_MAN_CONSOLE.Properties.Resources.cross_icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // DataFormR3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormR3";
            this.Size = new System.Drawing.Size(1185, 633);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvR3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvR3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn crefno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
    }
}
