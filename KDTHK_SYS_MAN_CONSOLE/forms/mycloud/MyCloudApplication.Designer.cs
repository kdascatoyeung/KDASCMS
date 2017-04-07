namespace KDTHK_SYS_MAN_CONSOLE.forms.mycloud
{
    partial class MyCloudApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCloudApplication));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvApplication = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnRefresh,
            this.tsbtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1194, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvApplication
            // 
            this.dgvApplication.AllowUserToAddRows = false;
            this.dgvApplication.AllowUserToDeleteRows = false;
            this.dgvApplication.AllowUserToResizeRows = false;
            this.dgvApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplication.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplication.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvApplication.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvApplication.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvApplication.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCategory,
            this.cStaff,
            this.cName,
            this.cPath,
            this.cDescription,
            this.cLastAccess});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplication.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplication.Location = new System.Drawing.Point(0, 23);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvApplication.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvApplication.ReadOnly = true;
            this.dgvApplication.RowHeadersVisible = false;
            this.dgvApplication.SecondaryLength = 2;
            this.dgvApplication.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvApplication.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvApplication.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvApplication.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplication.Size = new System.Drawing.Size(1194, 619);
            this.dgvApplication.TabIndex = 4;
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(48, 22);
            this.tsbtnAdd.Text = "Add";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(68, 22);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(61, 22);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // cCategory
            // 
            this.cCategory.DataPropertyName = "category";
            this.cCategory.HeaderText = "Category";
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            // 
            // cStaff
            // 
            this.cStaff.DataPropertyName = "staff";
            this.cStaff.HeaderText = "Staff";
            this.cStaff.Name = "cStaff";
            this.cStaff.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "name";
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cPath
            // 
            this.cPath.DataPropertyName = "spath";
            this.cPath.HeaderText = "Path";
            this.cPath.Name = "cPath";
            this.cPath.ReadOnly = true;
            // 
            // cDescription
            // 
            this.cDescription.DataPropertyName = "description";
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            // 
            // cLastAccess
            // 
            this.cLastAccess.DataPropertyName = "lastaccess";
            this.cLastAccess.HeaderText = "Last Access";
            this.cLastAccess.Name = "cLastAccess";
            this.cLastAccess.ReadOnly = true;
            // 
            // MyCloudApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvApplication);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MyCloudApplication";
            this.Size = new System.Drawing.Size(1194, 645);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastAccess;
    }
}
