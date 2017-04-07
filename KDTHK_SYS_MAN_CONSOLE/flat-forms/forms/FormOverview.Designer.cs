
namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    partial class FormOverview
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
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.dgvOverview = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmapproval = new System.Windows.Forms.DataGridViewImageColumn();
            this.capp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.ckbAll);
            this.customPanel3.Controls.Add(this.dgvOverview);
            this.customPanel3.Curvature = 1;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1207, 640);
            this.customPanel3.TabIndex = 51;
            // 
            // ckbAll
            // 
            this.ckbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(1122, 618);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(82, 19);
            this.ckbAll.TabIndex = 8;
            this.ckbAll.Text = "All Record";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToDeleteRows = false;
            this.dgvOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdays,
            this.cchaseno,
            this.cstatus,
            this.cmcategory,
            this.cmdate,
            this.cmcreatedby,
            this.cext,
            this.ctitle,
            this.cmstart,
            this.cmend,
            this.cmapproval,
            this.capp,
            this.chandle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOverview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOverview.Location = new System.Drawing.Point(3, 3);
            this.dgvOverview.MultiSelect = false;
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvOverview.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.SecondaryLength = 2;
            this.dgvOverview.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvOverview.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvOverview.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvOverview.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverview.Size = new System.Drawing.Size(1201, 614);
            this.dgvOverview.TabIndex = 7;
            this.dgvOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverview_CellContentClick);
            this.dgvOverview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverview_CellValueChanged);
            this.dgvOverview.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOverview_ColumnHeaderMouseClick);
            this.dgvOverview.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvOverview_EditingControlShowing);
            this.dgvOverview.DoubleClick += new System.EventHandler(this.dgvOverview_DoubleClick);
            this.dgvOverview.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dgvOverview_DataError);
            // 
            // cdays
            // 
            this.cdays.DataPropertyName = "idle";
            this.cdays.FillWeight = 20F;
            this.cdays.HeaderText = "Idle";
            this.cdays.Name = "cdays";
            this.cdays.ReadOnly = true;
            this.cdays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Visible = false;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "st";
            this.cstatus.FillWeight = 50F;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cmcategory
            // 
            this.cmcategory.DataPropertyName = "type";
            this.cmcategory.FillWeight = 50F;
            this.cmcategory.HeaderText = "Category";
            this.cmcategory.Name = "cmcategory";
            this.cmcategory.ReadOnly = true;
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "created";
            this.cmdate.FillWeight = 40F;
            this.cmdate.HeaderText = "Created";
            this.cmdate.Name = "cmdate";
            this.cmdate.ReadOnly = true;
            // 
            // cmcreatedby
            // 
            this.cmcreatedby.DataPropertyName = "applicant";
            this.cmcreatedby.FillWeight = 80F;
            this.cmcreatedby.HeaderText = "Applicant";
            this.cmcreatedby.Name = "cmcreatedby";
            this.cmcreatedby.ReadOnly = true;
            // 
            // cext
            // 
            this.cext.DataPropertyName = "ext";
            this.cext.FillWeight = 30F;
            this.cext.HeaderText = "Ext.";
            this.cext.Name = "cext";
            this.cext.ReadOnly = true;
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
            this.cmstart.DataPropertyName = "start";
            this.cmstart.FillWeight = 40F;
            this.cmstart.HeaderText = "Start Date";
            this.cmstart.Name = "cmstart";
            this.cmstart.ReadOnly = true;
            // 
            // cmend
            // 
            this.cmend.DataPropertyName = "end";
            this.cmend.FillWeight = 40F;
            this.cmend.HeaderText = "End Date";
            this.cmend.Name = "cmend";
            this.cmend.ReadOnly = true;
            // 
            // cmapproval
            // 
            this.cmapproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cmapproval.DataPropertyName = "app";
            this.cmapproval.FillWeight = 55F;
            this.cmapproval.HeaderText = "Approval";
            this.cmapproval.Name = "cmapproval";
            this.cmapproval.ReadOnly = true;
            this.cmapproval.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmapproval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmapproval.Width = 82;
            // 
            // capp
            // 
            this.capp.DataPropertyName = "approval";
            this.capp.HeaderText = "app";
            this.capp.Name = "capp";
            this.capp.ReadOnly = true;
            this.capp.Visible = false;
            // 
            // chandle
            // 
            this.chandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chandle.HeaderText = "HandleBy";
            //this.chandle.Items.AddRange(new object[] {
            //"---",
            //UserUtil.ItUserName1(),
            //UserUtil.ItUserName3(),
            //UserUtil.ItUserName2()});
            ////"Yeung Wai, Gabriel (楊偉)",
            ////"Lee Ming Fung(李銘峯)",
            ////"Ho Kin Hang(何健恒,Ken)",
            ////"Chan Fai Lung(陳輝龍,Onyx)"});
            this.chandle.Name = "chandle";
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.customPanel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormOverview";
            this.Size = new System.Drawing.Size(1207, 640);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvOverview;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cext;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmend;
        private System.Windows.Forms.DataGridViewImageColumn cmapproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn capp;
        private System.Windows.Forms.DataGridViewComboBoxColumn chandle;
    }
}
