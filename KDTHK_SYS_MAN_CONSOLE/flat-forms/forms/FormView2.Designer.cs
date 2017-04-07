namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    partial class FormView2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAllRecord = new System.Windows.Forms.Button();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvProcessing = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvCompleted = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvOverview = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmapproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cincharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRecord = new CustomUtil.controls.panel.CustomPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.BackColor = System.Drawing.Color.White;
            this.btnAllRecord.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAllRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnAllRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAllRecord.Location = new System.Drawing.Point(1, 1);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(365, 24);
            this.btnAllRecord.TabIndex = 48;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseVisualStyleBackColor = false;
            this.btnAllRecord.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnAllRecord.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.Silver;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.dgvProcessing);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(1, 26);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(365, 305);
            this.customPanel2.TabIndex = 47;
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
            this.dataGridViewTextBoxColumn2,
            this.ctotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcessing.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcessing.Location = new System.Drawing.Point(3, 3);
            this.dgvProcessing.MultiSelect = false;
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
            this.dgvProcessing.Size = new System.Drawing.Size(359, 299);
            this.dgvProcessing.TabIndex = 7;
            this.dgvProcessing.Tag = "category";
            this.dgvProcessing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessing_CellContentClick);
            this.dgvProcessing.SelectionChanged += new System.EventHandler(this.dgvProcessing_SelectionChanged);
            this.dgvProcessing.Click += new System.EventHandler(this.dgvProcessing_Click);
            this.dgvProcessing.DoubleClick += new System.EventHandler(this.dgvProcessing_DoubleClick);
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
            this.ctotal.HeaderText = "Processing";
            this.ctotal.Name = "ctotal";
            this.ctotal.ReadOnly = true;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.Silver;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.dgvCompleted);
            this.customPanel1.Curvature = 3;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(1, 334);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(365, 295);
            this.customPanel1.TabIndex = 49;
            // 
            // dgvCompleted
            // 
            this.dgvCompleted.AllowUserToAddRows = false;
            this.dgvCompleted.AllowUserToDeleteRows = false;
            this.dgvCompleted.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvCompleted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompleted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompleted.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompleted.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompleted.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvCompleted.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvCompleted.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompleted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompleted.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompleted.Location = new System.Drawing.Point(3, 3);
            this.dgvCompleted.MultiSelect = false;
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvCompleted.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvCompleted.ReadOnly = true;
            this.dgvCompleted.RowHeadersVisible = false;
            this.dgvCompleted.SecondaryLength = 2;
            this.dgvCompleted.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvCompleted.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvCompleted.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvCompleted.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvCompleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompleted.Size = new System.Drawing.Size(359, 289);
            this.dgvCompleted.TabIndex = 7;
            this.dgvCompleted.Tag = "category";
            this.dgvCompleted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompleted_CellContentClick);
            this.dgvCompleted.SelectionChanged += new System.EventHandler(this.dgvCompleted_SelectionChanged);
            this.dgvCompleted.Click += new System.EventHandler(this.dgvCompleted_Click);
            this.dgvCompleted.DoubleClick += new System.EventHandler(this.dgvCompleted_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.dgvOverview);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(930, 4);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(18, 16);
            this.customPanel3.TabIndex = 50;
            this.customPanel3.Visible = false;
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToDeleteRows = false;
            this.dgvOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOverview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOverview.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvOverview.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvOverview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cstatus,
            this.cmcategory,
            this.cmcreatedby,
            this.cmdate,
            this.cmstart,
            this.cmend,
            this.cmapproval,
            this.cincharge});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOverview.Location = new System.Drawing.Point(3, 3);
            this.dgvOverview.MultiSelect = false;
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvOverview.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvOverview.ReadOnly = true;
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.SecondaryLength = 2;
            this.dgvOverview.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvOverview.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvOverview.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvOverview.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverview.Size = new System.Drawing.Size(12, 10);
            this.dgvOverview.TabIndex = 7;
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
            // cmcreatedby
            // 
            this.cmcreatedby.DataPropertyName = "applicant";
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "created";
            this.cmdate.HeaderText = "Date";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
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
            this.cmend.HeaderText = "End Date";
            this.cmend.Name = "cmend";
            this.cmend.ReadOnly = true;
            // 
            // cmapproval
            // 
            this.cmapproval.DataPropertyName = "approval";
            this.cmapproval.FillWeight = 55F;
            this.cmapproval.HeaderText = "Approval";
            this.cmapproval.Name = "cmapproval";
            this.cmapproval.ReadOnly = true;
            // 
            // cincharge
            // 
            this.cincharge.DataPropertyName = "incharge";
            this.cincharge.HeaderText = "In-Charge";
            this.cincharge.Name = "cincharge";
            this.cincharge.ReadOnly = true;
            // 
            // pnlRecord
            // 
            this.pnlRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecord.BackColor = System.Drawing.SystemColors.Window;
            this.pnlRecord.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlRecord.BorderColor = System.Drawing.Color.Silver;
            this.pnlRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecord.BorderWidth = 1;
            this.pnlRecord.Curvature = 3;
            this.pnlRecord.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlRecord.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlRecord.Location = new System.Drawing.Point(372, 26);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(837, 603);
            this.pnlRecord.TabIndex = 51;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnExport.Location = new System.Drawing.Point(372, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(365, 24);
            this.btnExport.TabIndex = 52;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // FormView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlRecord);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnAllRecord);
            this.Controls.Add(this.customPanel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormView2";
            this.Size = new System.Drawing.Size(1212, 632);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllRecord;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvProcessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotal;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmapproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cincharge;
        private CustomUtil.controls.panel.CustomPanel pnlRecord;
        private System.Windows.Forms.Button btnExport;
    }
}
