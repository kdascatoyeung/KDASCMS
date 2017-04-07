namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    partial class FormView
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
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvTotal = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cborrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvIncharge = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvOverview = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.ctmpname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAllRecord = new System.Windows.Forms.Button();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmapproval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cincharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncharge)).BeginInit();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel2
            // 
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
            this.customPanel2.Location = new System.Drawing.Point(17, 43);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(365, 317);
            this.customPanel2.TabIndex = 10;
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.cprocess,
            this.cborrow});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotal.Location = new System.Drawing.Point(3, 3);
            this.dgvTotal.MultiSelect = false;
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
            this.dgvTotal.Size = new System.Drawing.Size(359, 311);
            this.dgvTotal.TabIndex = 7;
            this.dgvTotal.Tag = "category";
            this.dgvTotal.DoubleClick += new System.EventHandler(this.dgvTotal_DoubleClick);
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
            this.cstock.FillWeight = 45F;
            this.cstock.HeaderText = "Completed";
            this.cstock.Name = "cstock";
            this.cstock.ReadOnly = true;
            // 
            // cprocess
            // 
            this.cprocess.FillWeight = 40F;
            this.cprocess.HeaderText = "Process";
            this.cprocess.Name = "cprocess";
            this.cprocess.ReadOnly = true;
            // 
            // cborrow
            // 
            this.cborrow.FillWeight = 40F;
            this.cborrow.HeaderText = "Received";
            this.cborrow.Name = "cborrow";
            this.cborrow.ReadOnly = true;
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
            this.customPanel1.Controls.Add(this.dgvIncharge);
            this.customPanel1.Curvature = 3;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(17, 366);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(365, 258);
            this.customPanel1.TabIndex = 11;
            // 
            // dgvIncharge
            // 
            this.dgvIncharge.AllowUserToAddRows = false;
            this.dgvIncharge.AllowUserToDeleteRows = false;
            this.dgvIncharge.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvIncharge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIncharge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncharge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncharge.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvIncharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncharge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIncharge.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvIncharge.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvIncharge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIncharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncharge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctmpname,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncharge.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIncharge.Location = new System.Drawing.Point(3, 3);
            this.dgvIncharge.MultiSelect = false;
            this.dgvIncharge.Name = "dgvIncharge";
            this.dgvIncharge.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvIncharge.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvIncharge.ReadOnly = true;
            this.dgvIncharge.RowHeadersVisible = false;
            this.dgvIncharge.SecondaryLength = 2;
            this.dgvIncharge.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvIncharge.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvIncharge.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvIncharge.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvIncharge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncharge.Size = new System.Drawing.Size(359, 252);
            this.dgvIncharge.TabIndex = 7;
            this.dgvIncharge.Tag = "incharge";
            this.dgvIncharge.DoubleClick += new System.EventHandler(this.dgvIncharge_DoubleClick);
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
            this.customPanel3.Location = new System.Drawing.Point(388, 16);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(809, 608);
            this.customPanel3.TabIndex = 12;
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
            this.dgvOverview.Size = new System.Drawing.Size(803, 602);
            this.dgvOverview.TabIndex = 7;
            this.dgvOverview.DoubleClick += new System.EventHandler(this.dgvOverview_DoubleClick);
            // 
            // ctmpname
            // 
            this.ctmpname.HeaderText = "name";
            this.ctmpname.Name = "ctmpname";
            this.ctmpname.ReadOnly = true;
            this.ctmpname.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 45F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Process";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Received";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnAllRecord
            // 
            this.btnAllRecord.BackColor = System.Drawing.Color.White;
            this.btnAllRecord.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAllRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnAllRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAllRecord.Location = new System.Drawing.Point(17, 16);
            this.btnAllRecord.Name = "btnAllRecord";
            this.btnAllRecord.Size = new System.Drawing.Size(365, 24);
            this.btnAllRecord.TabIndex = 46;
            this.btnAllRecord.Text = "All Record";
            this.btnAllRecord.UseVisualStyleBackColor = false;
            this.btnAllRecord.Click += new System.EventHandler(this.btnAllRecord_Click);
            this.btnAllRecord.MouseEnter += new System.EventHandler(this.ButtonMouseEnter);
            this.btnAllRecord.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
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
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.btnAllRecord);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormView";
            this.Size = new System.Drawing.Size(1216, 641);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncharge)).EndInit();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprocess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cborrow;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvIncharge;
        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctmpname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnAllRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmapproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cincharge;
    }
}
