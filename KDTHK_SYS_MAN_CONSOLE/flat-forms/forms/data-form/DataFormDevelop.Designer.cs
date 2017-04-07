namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    partial class DataFormDevelop
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
            this.dgvDevelop = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cidle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capproval = new System.Windows.Forms.DataGridViewImageColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHandledBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelop)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.dgvDevelop);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1215, 647);
            this.customPanel3.TabIndex = 52;
            // 
            // dgvDevelop
            // 
            this.dgvDevelop.AllowUserToAddRows = false;
            this.dgvDevelop.AllowUserToDeleteRows = false;
            this.dgvDevelop.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvDevelop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevelop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevelop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevelop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDevelop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevelop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDevelop.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvDevelop.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvDevelop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDevelop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevelop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidle,
            this.cmcreatedby,
            this.cmdate,
            this.cmcategory,
            this.csys,
            this.cmend,
            this.cstatus,
            this.capproval,
            this.cchaseno,
            this.cHandledBy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevelop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevelop.Location = new System.Drawing.Point(3, 3);
            this.dgvDevelop.MultiSelect = false;
            this.dgvDevelop.Name = "dgvDevelop";
            this.dgvDevelop.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvDevelop.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvDevelop.ReadOnly = true;
            this.dgvDevelop.RowHeadersVisible = false;
            this.dgvDevelop.SecondaryLength = 2;
            this.dgvDevelop.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvDevelop.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvDevelop.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvDevelop.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvDevelop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevelop.Size = new System.Drawing.Size(1209, 641);
            this.dgvDevelop.TabIndex = 7;
            this.dgvDevelop.DoubleClick += new System.EventHandler(this.dgvDevelop_DoubleClick);
            // 
            // cidle
            // 
            this.cidle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cidle.DataPropertyName = "Idle";
            this.cidle.HeaderText = "Idle";
            this.cidle.Name = "cidle";
            this.cidle.ReadOnly = true;
            this.cidle.Width = 53;
            // 
            // cmcreatedby
            // 
            this.cmcreatedby.DataPropertyName = "Applicant";
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "Created";
            this.cmdate.HeaderText = "Date";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
            // 
            // cmcategory
            // 
            this.cmcategory.DataPropertyName = "Category";
            this.cmcategory.HeaderText = "Category";
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.ReadOnly = true;
            // 
            // csys
            // 
            this.csys.DataPropertyName = "Item";
            this.csys.HeaderText = "System";
            this.csys.Name = "csys";
            this.csys.ReadOnly = true;
            // 
            // cmend
            // 
            this.cmend.DataPropertyName = "Estimated";
            this.cmend.HeaderText = "Estimated";
            this.cmend.Name = "cmend";
            this.cmend.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "Status";
            this.cstatus.FillWeight = 45F;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // capproval
            // 
            this.capproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capproval.DataPropertyName = "Approval";
            this.capproval.HeaderText = "Approval";
            this.capproval.Name = "capproval";
            this.capproval.ReadOnly = true;
            this.capproval.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.capproval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.capproval.Width = 82;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "ChaseNo";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Visible = false;
            // 
            // cHandledBy
            // 
            this.cHandledBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cHandledBy.DataPropertyName = "HandledBy";
            this.cHandledBy.HeaderText = "HandledBy";
            this.cHandledBy.Name = "cHandledBy";
            this.cHandledBy.ReadOnly = true;
            this.cHandledBy.Width = 91;
            // 
            // DataFormDevelop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataFormDevelop";
            this.Size = new System.Drawing.Size(1215, 647);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvDevelop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn csys;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewImageColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHandledBy;
    }
}
