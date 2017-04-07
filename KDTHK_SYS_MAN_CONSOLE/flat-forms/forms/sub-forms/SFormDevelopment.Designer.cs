namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    partial class SFormDevelopment
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
            this.pnlForm = new CustomUtil.controls.panel.CustomPanel();
            this.cbAssign = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAttachment = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpComplete = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbRemarks = new KDTHK_SYS_MAN_CONSOLE.utils.RtfPrintUtil();
            this.pnlForm.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlForm.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlForm.BorderColor = System.Drawing.Color.Silver;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.BorderWidth = 1;
            this.pnlForm.Controls.Add(this.cbAssign);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.lbAttachment);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.dtpComplete);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.customPanel1);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.cbStatus);
            this.pnlForm.Controls.Add(this.label11);
            this.pnlForm.Controls.Add(this.cbItem);
            this.pnlForm.Controls.Add(this.label10);
            this.pnlForm.Controls.Add(this.cbCategory);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Curvature = 1;
            this.pnlForm.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(705, 632);
            this.pnlForm.TabIndex = 137;
            // 
            // cbAssign
            // 
            this.cbAssign.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssign.FormattingEnabled = true;
            this.cbAssign.Location = new System.Drawing.Point(104, 428);
            this.cbAssign.Name = "cbAssign";
            this.cbAssign.Size = new System.Drawing.Size(230, 27);
            this.cbAssign.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 104;
            this.label4.Text = "Assign To";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAdd.Location = new System.Drawing.Point(340, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 24);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // lbAttachment
            // 
            this.lbAttachment.FormattingEnabled = true;
            this.lbAttachment.ItemHeight = 15;
            this.lbAttachment.Location = new System.Drawing.Point(104, 461);
            this.lbAttachment.Name = "lbAttachment";
            this.lbAttachment.Size = new System.Drawing.Size(230, 94);
            this.lbAttachment.TabIndex = 102;
            this.lbAttachment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAttachment_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 101;
            this.label3.Text = "Attachment";
            // 
            // dtpComplete
            // 
            this.dtpComplete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpComplete.Location = new System.Drawing.Point(404, 58);
            this.dtpComplete.Name = "dtpComplete";
            this.dtpComplete.Size = new System.Drawing.Size(182, 27);
            this.dtpComplete.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Estimated Date";
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.rtbRemarks);
            this.customPanel1.Curvature = 1;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(104, 124);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(585, 298);
            this.customPanel1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Remarks";
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
            this.btnSave.Location = new System.Drawing.Point(581, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Completed",
            "Processing"});
            this.cbStatus.Location = new System.Drawing.Point(404, 91);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 27);
            this.cbStatus.TabIndex = 57;
            this.cbStatus.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 56;
            this.label11.Text = "Status";
            this.label11.Visible = false;
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "Excel Tools",
            "Portal",
            "Apps"});
            this.cbItem.Location = new System.Drawing.Point(104, 91);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(182, 27);
            this.cbItem.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Item";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "New",
            "Modify"});
            this.cbCategory.Location = new System.Drawing.Point(104, 58);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(182, 27);
            this.cbCategory.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 36);
            this.label6.TabIndex = 51;
            this.label6.Text = "DEVELOPMENT";
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRemarks.Location = new System.Drawing.Point(3, 4);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(579, 291);
            this.rtbRemarks.TabIndex = 0;
            this.rtbRemarks.Text = "";
            // 
            // SFormDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SFormDevelopment";
            this.Size = new System.Drawing.Size(705, 632);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpComplete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbAttachment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAssign;
        private System.Windows.Forms.Label label4;
        private utils.RtfPrintUtil rtbRemarks;
    }
}
