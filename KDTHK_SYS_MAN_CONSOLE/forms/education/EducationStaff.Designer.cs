namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationStaff));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvStaff = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.colnickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnameeng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kDTHKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kDHKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
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
            this.tsbtnUpload,
            this.tsbtnView,
            this.tsbtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(-1, -1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvStaff.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnickname,
            this.colnameeng,
            this.coldepartment});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.Location = new System.Drawing.Point(0, 24);
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvStaff.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.SecondaryLength = 2;
            this.dgvStaff.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvStaff.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvStaff.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvStaff.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1200, 611);
            this.dgvStaff.TabIndex = 3;
            // 
            // colnickname
            // 
            this.colnickname.DataPropertyName = "staffid";
            this.colnickname.FillWeight = 80F;
            this.colnickname.HeaderText = "Staff Id";
            this.colnickname.Name = "colnickname";
            this.colnickname.ReadOnly = true;
            // 
            // colnameeng
            // 
            this.colnameeng.DataPropertyName = "name";
            this.colnameeng.FillWeight = 150F;
            this.colnameeng.HeaderText = "Name";
            this.colnameeng.Name = "colnameeng";
            this.colnameeng.ReadOnly = true;
            // 
            // coldepartment
            // 
            this.coldepartment.DataPropertyName = "company";
            this.coldepartment.FillWeight = 35.7868F;
            this.coldepartment.HeaderText = "Company";
            this.coldepartment.Name = "coldepartment";
            this.coldepartment.ReadOnly = true;
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
            // tsbtnUpload
            // 
            this.tsbtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpload.Image")));
            this.tsbtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpload.Name = "tsbtnUpload";
            this.tsbtnUpload.Size = new System.Drawing.Size(67, 22);
            this.tsbtnUpload.Text = "Upload";
            this.tsbtnUpload.Click += new System.EventHandler(this.tsbtnUpload_Click);
            // 
            // tsbtnView
            // 
            this.tsbtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.kDTHKToolStripMenuItem,
            this.kDASToolStripMenuItem,
            this.kDHKToolStripMenuItem});
            this.tsbtnView.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnView.Image")));
            this.tsbtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnView.Name = "tsbtnView";
            this.tsbtnView.Size = new System.Drawing.Size(62, 22);
            this.tsbtnView.Text = "View";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allToolStripMenuItem.BackgroundImage")));
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // kDTHKToolStripMenuItem
            // 
            this.kDTHKToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kDTHKToolStripMenuItem.BackgroundImage")));
            this.kDTHKToolStripMenuItem.Name = "kDTHKToolStripMenuItem";
            this.kDTHKToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kDTHKToolStripMenuItem.Text = "KDTHK";
            this.kDTHKToolStripMenuItem.Click += new System.EventHandler(this.kDTHKToolStripMenuItem_Click);
            // 
            // kDASToolStripMenuItem
            // 
            this.kDASToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kDASToolStripMenuItem.BackgroundImage")));
            this.kDASToolStripMenuItem.Name = "kDASToolStripMenuItem";
            this.kDASToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kDASToolStripMenuItem.Text = "KDAS";
            this.kDASToolStripMenuItem.Click += new System.EventHandler(this.kDASToolStripMenuItem_Click);
            // 
            // kDHKToolStripMenuItem
            // 
            this.kDHKToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kDHKToolStripMenuItem.BackgroundImage")));
            this.kDHKToolStripMenuItem.Name = "kDHKToolStripMenuItem";
            this.kDHKToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kDHKToolStripMenuItem.Text = "KDHK";
            this.kDHKToolStripMenuItem.Click += new System.EventHandler(this.kDHKToolStripMenuItem_Click);
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
            // EducationStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationStaff";
            this.Size = new System.Drawing.Size(1200, 638);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnView;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kDTHKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kDHKToolStripMenuItem;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnameeng;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldepartment;
    }
}
