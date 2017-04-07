namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    partial class PFormPermission
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtApprover = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvPermission = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cborrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbApproval = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAssign = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblApprovalDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblITApprover = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblITApprovalDate = new System.Windows.Forms.Label();
            this.pbIt = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApproval)).BeginInit();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApprover
            // 
            this.txtApprover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprover.Location = new System.Drawing.Point(102, 342);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.Size = new System.Drawing.Size(238, 27);
            this.txtApprover.TabIndex = 145;
            this.txtApprover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 144;
            this.label7.Text = "Approver";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(434, 309);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(282, 27);
            this.txtEnd.TabIndex = 140;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 139;
            this.label4.Text = "End";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(102, 309);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(238, 27);
            this.txtStart.TabIndex = 138;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 137;
            this.label3.Text = "Start";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.rtbContent);
            this.customPanel1.Curvature = 1;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(102, 88);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(614, 215);
            this.customPanel1.TabIndex = 135;
            // 
            // rtbContent
            // 
            this.rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(3, 3);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(608, 209);
            this.rtbContent.TabIndex = 16;
            this.rtbContent.Text = "";
            this.rtbContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "Content";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(102, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(614, 27);
            this.txtName.TabIndex = 134;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "Applicant";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.Silver;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.dgvPermission);
            this.customPanel2.Curvature = 3;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(102, 408);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(614, 77);
            this.customPanel2.TabIndex = 146;
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
            this.dgvPermission.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPermission.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPermission.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvPermission.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvPermission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctotal,
            this.cuser,
            this.cstock,
            this.cborrow,
            this.cremarks});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermission.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPermission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
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
            this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPermission.Size = new System.Drawing.Size(608, 71);
            this.dgvPermission.TabIndex = 7;
            this.dgvPermission.Tag = "category";
            // 
            // ctotal
            // 
            this.ctotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ctotal.FillWeight = 60F;
            this.ctotal.HeaderText = "Item Name";
            this.ctotal.Name = "ctotal";
            this.ctotal.ReadOnly = true;
            this.ctotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ctotal.Width = 90;
            // 
            // cuser
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cuser.DefaultCellStyle = dataGridViewCellStyle2;
            this.cuser.FillWeight = 40F;
            this.cuser.HeaderText = "User ID";
            this.cuser.Name = "cuser";
            this.cuser.ReadOnly = true;
            // 
            // cstock
            // 
            this.cstock.FillWeight = 45F;
            this.cstock.HeaderText = "Start";
            this.cstock.Name = "cstock";
            this.cstock.ReadOnly = true;
            // 
            // cborrow
            // 
            this.cborrow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cborrow.FillWeight = 40F;
            this.cborrow.HeaderText = "Status";
            this.cborrow.Name = "cborrow";
            this.cborrow.ReadOnly = true;
            this.cborrow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cborrow.Width = 66;
            // 
            // cremarks
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cremarks.DefaultCellStyle = dataGridViewCellStyle3;
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.ReadOnly = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.BackColor = System.Drawing.Color.White;
            this.btnComplete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnComplete.Location = new System.Drawing.Point(530, 624);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(90, 25);
            this.btnComplete.TabIndex = 147;
            this.btnComplete.Tag = "";
            this.btnComplete.Text = "Completed";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnComplete.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnComplete.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 148;
            this.label5.Text = "Approval";
            // 
            // pbApproval
            // 
            this.pbApproval.Location = new System.Drawing.Point(434, 348);
            this.pbApproval.Name = "pbApproval";
            this.pbApproval.Size = new System.Drawing.Size(16, 16);
            this.pbApproval.TabIndex = 149;
            this.pbApproval.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 150;
            this.label6.Text = "Details";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.rtbDetail);
            this.customPanel3.Curvature = 1;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(102, 491);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(614, 125);
            this.customPanel3.TabIndex = 151;
            // 
            // rtbDetail
            // 
            this.rtbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDetail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetail.Location = new System.Drawing.Point(3, 3);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(608, 119);
            this.rtbDetail.TabIndex = 16;
            this.rtbDetail.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSave.Location = new System.Drawing.Point(434, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 152;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(102, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(614, 27);
            this.txtTitle.TabIndex = 154;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 153;
            this.label8.Text = "Title";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnDelete.Location = new System.Drawing.Point(626, 624);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 167;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAssign
            // 
            this.cbAssign.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssign.FormattingEnabled = true;
            this.cbAssign.Location = new System.Drawing.Point(102, 622);
            this.cbAssign.Name = "cbAssign";
            this.cbAssign.Size = new System.Drawing.Size(238, 27);
            this.cbAssign.TabIndex = 172;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 171;
            this.label9.Text = "Assign To";
            // 
            // lblApprovalDate
            // 
            this.lblApprovalDate.AutoSize = true;
            this.lblApprovalDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovalDate.Location = new System.Drawing.Point(467, 346);
            this.lblApprovalDate.Name = "lblApprovalDate";
            this.lblApprovalDate.Size = new System.Drawing.Size(13, 18);
            this.lblApprovalDate.TabIndex = 173;
            this.lblApprovalDate.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 174;
            this.label10.Text = "IT Approver";
            // 
            // lblITApprover
            // 
            this.lblITApprover.AutoSize = true;
            this.lblITApprover.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITApprover.Location = new System.Drawing.Point(99, 379);
            this.lblITApprover.Name = "lblITApprover";
            this.lblITApprover.Size = new System.Drawing.Size(13, 18);
            this.lblITApprover.TabIndex = 175;
            this.lblITApprover.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(346, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 176;
            this.label12.Text = "IT Approval";
            // 
            // lblITApprovalDate
            // 
            this.lblITApprovalDate.AutoSize = true;
            this.lblITApprovalDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITApprovalDate.Location = new System.Drawing.Point(467, 379);
            this.lblITApprovalDate.Name = "lblITApprovalDate";
            this.lblITApprovalDate.Size = new System.Drawing.Size(13, 18);
            this.lblITApprovalDate.TabIndex = 178;
            this.lblITApprovalDate.Text = "-";
            // 
            // pbIt
            // 
            this.pbIt.Location = new System.Drawing.Point(434, 381);
            this.pbIt.Name = "pbIt";
            this.pbIt.Size = new System.Drawing.Size(16, 16);
            this.pbIt.TabIndex = 177;
            this.pbIt.TabStop = false;
            // 
            // PFormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(728, 657);
            this.Controls.Add(this.lblITApprovalDate);
            this.Controls.Add(this.pbIt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblITApprover);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblApprovalDate);
            this.Controls.Add(this.cbAssign);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbApproval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.txtApprover);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PFormPermission";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFormPermission";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApproval)).EndInit();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApprover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvPermission;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbApproval;
        private System.Windows.Forms.Label label6;
        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cborrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbAssign;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblApprovalDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblITApprover;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblITApprovalDate;
        private System.Windows.Forms.PictureBox pbIt;
    }
}