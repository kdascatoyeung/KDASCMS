namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    partial class SFormR3
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
            this.txtCmApprover = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbR3Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlForm.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlForm.BorderColor = System.Drawing.Color.Silver;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.BorderWidth = 1;
            this.pnlForm.Controls.Add(this.txtCmApprover);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.btnBrowse);
            this.pnlForm.Controls.Add(this.txtAttachment);
            this.pnlForm.Controls.Add(this.txtComment);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.dtpStart);
            this.pnlForm.Controls.Add(this.cbR3Category);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.cbStatus);
            this.pnlForm.Controls.Add(this.label11);
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
            this.pnlForm.Size = new System.Drawing.Size(655, 598);
            this.pnlForm.TabIndex = 138;
            // 
            // txtCmApprover
            // 
            this.txtCmApprover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmApprover.Location = new System.Drawing.Point(112, 256);
            this.txtCmApprover.Name = "txtCmApprover";
            this.txtCmApprover.Size = new System.Drawing.Size(238, 27);
            this.txtCmApprover.TabIndex = 143;
            this.txtCmApprover.DoubleClick += new System.EventHandler(this.txtCmApprover_DoubleClick);
            this.txtCmApprover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 142;
            this.label8.Text = "Approver (CM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 139;
            this.label5.Text = "Attachment";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::KDTHK_SYS_MAN_CONSOLE.Properties.Resources.folder_open;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(584, 231);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(16, 16);
            this.btnBrowse.TabIndex = 138;
            this.btnBrowse.Tag = "open";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(112, 227);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(466, 23);
            this.txtAttachment.TabIndex = 137;
            this.txtAttachment.DoubleClick += new System.EventHandler(this.txtAttachment_DoubleClick);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(112, 124);
            this.txtComment.MaxLength = 2147483647;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(488, 97);
            this.txtComment.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 117;
            this.label4.Text = "IT Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "Start Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(418, 58);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(182, 27);
            this.dtpStart.TabIndex = 99;
            // 
            // cbR3Category
            // 
            this.cbR3Category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbR3Category.FormattingEnabled = true;
            this.cbR3Category.Items.AddRange(new object[] {
            "ID",
            "TX",
            "ROLE"});
            this.cbR3Category.Location = new System.Drawing.Point(112, 91);
            this.cbR3Category.Name = "cbR3Category";
            this.cbR3Category.Size = new System.Drawing.Size(182, 27);
            this.cbR3Category.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "R3 Category";
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
            this.btnSave.Location = new System.Drawing.Point(527, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Completed",
            "Processing",
            "Cancel"});
            this.cbStatus.Location = new System.Drawing.Point(418, 91);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 27);
            this.cbStatus.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(366, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 56;
            this.label11.Text = "Status";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "New",
            "Change",
            "Delete"});
            this.cbCategory.Location = new System.Drawing.Point(112, 58);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(182, 27);
            this.cbCategory.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 36);
            this.label6.TabIndex = 51;
            this.label6.Text = "R3 Application";
            // 
            // SFormR3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SFormR3";
            this.Size = new System.Drawing.Size(655, 598);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbR3Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox txtCmApprover;
        private System.Windows.Forms.Label label8;
    }
}
