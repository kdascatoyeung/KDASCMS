namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    partial class FormQa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQa));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvQa = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.cquestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQa)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnApply.Location = new System.Drawing.Point(0, 405);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(411, 30);
            this.btnApply.TabIndex = 42;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnApply.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnReference
            // 
            this.btnReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReference.BackColor = System.Drawing.Color.White;
            this.btnReference.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReference.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnReference.Location = new System.Drawing.Point(411, 405);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(405, 30);
            this.btnReference.TabIndex = 43;
            this.btnReference.Text = "Ref";
            this.btnReference.UseVisualStyleBackColor = false;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            this.btnReference.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnReference.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(49, 6);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(732, 23);
            this.txtItem.TabIndex = 45;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
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
            this.customPanel3.Controls.Add(this.dgvQa);
            this.customPanel3.Curvature = 3;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(0, 35);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(816, 369);
            this.customPanel3.TabIndex = 52;
            // 
            // dgvQa
            // 
            this.dgvQa.AllowUserToAddRows = false;
            this.dgvQa.AllowUserToDeleteRows = false;
            this.dgvQa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvQa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvQa.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvQa.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvQa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cquestion,
            this.canswer,
            this.cid});
            this.dgvQa.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQa.Location = new System.Drawing.Point(3, 3);
            this.dgvQa.Name = "dgvQa";
            this.dgvQa.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvQa.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvQa.ReadOnly = true;
            this.dgvQa.RowHeadersVisible = false;
            this.dgvQa.SecondaryLength = 2;
            this.dgvQa.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvQa.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvQa.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvQa.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvQa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQa.Size = new System.Drawing.Size(810, 363);
            this.dgvQa.TabIndex = 7;
            this.dgvQa.DoubleClick += new System.EventHandler(this.dgvQa_DoubleClick);
            this.dgvQa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvQa_MouseDown);
            // 
            // cquestion
            // 
            this.cquestion.HeaderText = "Question";
            this.cquestion.Name = "cquestion";
            this.cquestion.ReadOnly = true;
            // 
            // canswer
            // 
            this.canswer.HeaderText = "Answer";
            this.canswer.Name = "canswer";
            this.canswer.ReadOnly = true;
            // 
            // cid
            // 
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(789, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(16, 16);
            this.btnAdd.TabIndex = 139;
            this.btnAdd.Tag = "open";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FormQa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(817, 436);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnApply);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q&A List";
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQa)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvQa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cquestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn canswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}