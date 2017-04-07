using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    partial class SFormPermission
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
            this.pnlForm = new CustomUtil.controls.panel.CustomPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvPermission = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ctotal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cborrow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbHandle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlForm.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlForm.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlForm.BorderColor = System.Drawing.Color.Silver;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.BorderWidth = 1;
            this.pnlForm.Controls.Add(this.btnNew);
            this.pnlForm.Controls.Add(this.customPanel2);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Curvature = 1;
            this.pnlForm.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(770, 648);
            this.pnlForm.TabIndex = 137;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnNew.Location = new System.Drawing.Point(3, 605);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 30);
            this.btnNew.TabIndex = 69;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.customPanel2.Location = new System.Drawing.Point(3, 56);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(764, 543);
            this.customPanel2.TabIndex = 68;
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
            this.ctotal,
            this.cuser,
            this.cstock,
            this.cborrow,
            this.cprocess,
            this.cbHandle,
            this.cdel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermission.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPermission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPermission.Location = new System.Drawing.Point(3, 3);
            this.dgvPermission.MultiSelect = false;
            this.dgvPermission.Name = "dgvPermission";
            this.dgvPermission.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvPermission.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvPermission.RowHeadersVisible = false;
            this.dgvPermission.SecondaryLength = 2;
            this.dgvPermission.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvPermission.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvPermission.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvPermission.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPermission.Size = new System.Drawing.Size(758, 537);
            this.dgvPermission.TabIndex = 7;
            this.dgvPermission.Tag = "category";
            this.dgvPermission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermission_CellContentClick);
            this.dgvPermission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermission_CellDoubleClick);
            this.dgvPermission.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPermission_DefaultValuesNeeded);
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
            this.btnSave.Location = new System.Drawing.Point(659, 605);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 36);
            this.label6.TabIndex = 51;
            this.label6.Text = "PERMISSION / SOFTWARE";
            // 
            // ctotal
            // 
            this.ctotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ctotal.FillWeight = 60F;
            this.ctotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctotal.HeaderText = "Item Name";
            this.ctotal.Name = "ctotal";
            this.ctotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ctotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ctotal.Width = 90;
            // 
            // cuser
            // 
            this.cuser.FillWeight = 46.95652F;
            this.cuser.HeaderText = "User ID";
            this.cuser.Name = "cuser";
            // 
            // cstock
            // 
            this.cstock.FillWeight = 52.82609F;
            this.cstock.HeaderText = "Start";
            this.cstock.Name = "cstock";
            // 
            // cborrow
            // 
            this.cborrow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cborrow.FillWeight = 40F;
            this.cborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cborrow.HeaderText = "Status";
            this.cborrow.Items.AddRange(new object[] {
            "New",
            "Change",
            "Delete"});
            this.cborrow.Name = "cborrow";
            this.cborrow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cborrow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cborrow.Width = 66;
            // 
            // cprocess
            // 
            this.cprocess.FillWeight = 46.95652F;
            this.cprocess.HeaderText = "Remarks";
            this.cprocess.Name = "cprocess";
            // 
            // cbHandle
            // 
            this.cbHandle.FillWeight = 78.26087F;
            this.cbHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHandle.HeaderText = "HandleBy";
            this.cbHandle.Items.AddRange(new object[] {
            UserUtil.ItUserName1(),
            UserUtil.ItUserName3(),
            UserUtil.ItUserName2()});
            //"Yeung Wai, Gabriel (楊偉)",
            //"Lee Ming Fung(李銘峯)",
            //"Ho Kin Hang(何健恒,Ken)",
            //"Chan Fai Lung(陳輝龍,Onyx)"});
            this.cbHandle.Name = "cbHandle";
            // 
            // cdel
            // 
            this.cdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cdel.HeaderText = "Del";
            this.cdel.Name = "cdel";
            this.cdel.Width = 31;
            // 
            // SFormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SFormPermission";
            this.Size = new System.Drawing.Size(770, 648);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvPermission;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewComboBoxColumn ctotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstock;
        private System.Windows.Forms.DataGridViewComboBoxColumn cborrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprocess;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbHandle;
        private System.Windows.Forms.DataGridViewImageColumn cdel;
    }
}
