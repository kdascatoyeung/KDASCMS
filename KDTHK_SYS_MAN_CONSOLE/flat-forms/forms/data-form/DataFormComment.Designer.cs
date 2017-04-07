namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormComment
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
            this.dgvComment = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandleby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
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
            this.customPanel3.Controls.Add(this.dgvComment);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1150, 622);
            this.customPanel3.TabIndex = 52;
            // 
            // dgvComment
            // 
            this.dgvComment.AllowUserToAddRows = false;
            this.dgvComment.AllowUserToDeleteRows = false;
            this.dgvComment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvComment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComment.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvComment.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvComment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidle,
            this.cchaseno,
            this.cstatus,
            this.cmcategory,
            this.cmdate,
            this.cmcreatedby,
            this.chandleby});
            this.dgvComment.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComment.Location = new System.Drawing.Point(3, 3);
            this.dgvComment.MultiSelect = false;
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvComment.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvComment.ReadOnly = true;
            this.dgvComment.RowHeadersVisible = false;
            this.dgvComment.SecondaryLength = 2;
            this.dgvComment.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvComment.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvComment.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvComment.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvComment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComment.Size = new System.Drawing.Size(1144, 616);
            this.dgvComment.TabIndex = 7;
            this.dgvComment.DoubleClick += new System.EventHandler(this.dgvComment_DoubleClick);
            this.dgvComment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvComment_MouseDown);
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
            this.cchaseno.FillWeight = 60F;
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
            // chandleby
            // 
            this.chandleby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chandleby.DataPropertyName = "handledby";
            this.chandleby.HeaderText = "HandledBy";
            this.chandleby.Name = "chandleby";
            this.chandleby.ReadOnly = true;
            this.chandleby.Width = 91;
            // 
            // DataFormComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormComment";
            this.Size = new System.Drawing.Size(1150, 622);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvComment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandleby;
    }
}
