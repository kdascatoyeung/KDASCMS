namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationList
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
            this.dgvQuestion = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colenabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colnotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkdthk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkdas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkdhg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.AllowUserToAddRows = false;
            this.dgvQuestion.AllowUserToDeleteRows = false;
            this.dgvQuestion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvQuestion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvQuestion.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvQuestion.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.coltitle,
            this.colfrom,
            this.colto,
            this.colenabled,
            this.colimg,
            this.colnotice,
            this.colkdthk,
            this.colkdas,
            this.colkdhg});
            this.dgvQuestion.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvQuestion.Location = new System.Drawing.Point(0, 0);
            this.dgvQuestion.MultiSelect = false;
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvQuestion.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvQuestion.ReadOnly = true;
            this.dgvQuestion.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvQuestion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestion.SecondaryLength = 2;
            this.dgvQuestion.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvQuestion.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvQuestion.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvQuestion.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestion.Size = new System.Drawing.Size(1173, 642);
            this.dgvQuestion.TabIndex = 26;
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.FillWeight = 13.11756F;
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Visible = false;
            // 
            // coltitle
            // 
            this.coltitle.DataPropertyName = "title";
            this.coltitle.FillWeight = 150F;
            this.coltitle.HeaderText = "Title";
            this.coltitle.Name = "coltitle";
            this.coltitle.ReadOnly = true;
            // 
            // colfrom
            // 
            this.colfrom.DataPropertyName = "fromdate";
            this.colfrom.FillWeight = 91.08049F;
            this.colfrom.HeaderText = "From";
            this.colfrom.Name = "colfrom";
            this.colfrom.ReadOnly = true;
            // 
            // colto
            // 
            this.colto.DataPropertyName = "todate";
            this.colto.FillWeight = 91.08049F;
            this.colto.HeaderText = "To";
            this.colto.Name = "colto";
            this.colto.ReadOnly = true;
            // 
            // colenabled
            // 
            this.colenabled.DataPropertyName = "enabled";
            this.colenabled.HeaderText = "開放aa";
            this.colenabled.Name = "colenabled";
            this.colenabled.ReadOnly = true;
            this.colenabled.Visible = false;
            // 
            // colimg
            // 
            this.colimg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colimg.FillWeight = 40F;
            this.colimg.HeaderText = "Enabled";
            this.colimg.Name = "colimg";
            this.colimg.ReadOnly = true;
            this.colimg.Width = 57;
            // 
            // colnotice
            // 
            this.colnotice.DataPropertyName = "notice";
            this.colnotice.FillWeight = 91.08049F;
            this.colnotice.HeaderText = "提示";
            this.colnotice.Name = "colnotice";
            this.colnotice.ReadOnly = true;
            this.colnotice.Visible = false;
            // 
            // colkdthk
            // 
            this.colkdthk.DataPropertyName = "kdthk";
            this.colkdthk.FillWeight = 91.08049F;
            this.colkdthk.HeaderText = "KDTHK";
            this.colkdthk.Name = "colkdthk";
            this.colkdthk.ReadOnly = true;
            // 
            // colkdas
            // 
            this.colkdas.DataPropertyName = "kdas";
            this.colkdas.FillWeight = 91.08049F;
            this.colkdas.HeaderText = "KDAS";
            this.colkdas.Name = "colkdas";
            this.colkdas.ReadOnly = true;
            // 
            // colkdhg
            // 
            this.colkdhg.DataPropertyName = "kdhg";
            this.colkdhg.FillWeight = 91.08049F;
            this.colkdhg.HeaderText = "KDHG";
            this.colkdhg.Name = "colkdhg";
            this.colkdhg.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableToolStripMenuItem.Image = global::KDTHK_SYS_MAN_CONSOLE.Properties.Resources.tick_icon;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // EducationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvQuestion);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationList";
            this.Size = new System.Drawing.Size(1173, 642);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.datagrid.CustomDatagrid dgvQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colenabled;
        private System.Windows.Forms.DataGridViewImageColumn colimg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkdthk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkdas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkdhg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
    }
}
