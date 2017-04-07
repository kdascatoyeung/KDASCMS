namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    partial class PFormR3
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApprover = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lklAttachment = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCmApprover = new System.Windows.Forms.TextBox();
            this.lblITApprovalDate = new System.Windows.Forms.Label();
            this.pbCm = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblApprovalDate = new System.Windows.Forms.Label();
            this.pbApproval = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(98, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(614, 27);
            this.txtTitle.TabIndex = 164;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 163;
            this.label8.Text = "Title";
            // 
            // txtApprover
            // 
            this.txtApprover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprover.Location = new System.Drawing.Point(98, 300);
            this.txtApprover.Name = "txtApprover";
            this.txtApprover.Size = new System.Drawing.Size(238, 27);
            this.txtApprover.TabIndex = 160;
            this.txtApprover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 159;
            this.label7.Text = "Approver";
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
            this.customPanel1.Location = new System.Drawing.Point(98, 79);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(614, 215);
            this.customPanel1.TabIndex = 157;
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
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 158;
            this.label2.Text = "Content";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(98, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(614, 27);
            this.txtName.TabIndex = 156;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 155;
            this.label1.Text = "Applicant";
            // 
            // lklAttachment
            // 
            this.lklAttachment.AutoSize = true;
            this.lklAttachment.Location = new System.Drawing.Point(95, 536);
            this.lklAttachment.Name = "lklAttachment";
            this.lklAttachment.Size = new System.Drawing.Size(58, 15);
            this.lklAttachment.TabIndex = 168;
            this.lklAttachment.TabStop = true;
            this.lklAttachment.Text = "Unknown";
            this.lklAttachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAttachment_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 167;
            this.label3.Text = "Attachment";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.txtComment);
            this.customPanel2.Curvature = 2;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(98, 406);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(614, 115);
            this.customPanel2.TabIndex = 165;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.Location = new System.Drawing.Point(3, 3);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(608, 109);
            this.txtComment.TabIndex = 0;
            this.txtComment.Text = "";
            this.txtComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 166;
            this.label4.Text = "IT Comment";
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
            this.btnDelete.Location = new System.Drawing.Point(622, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 25);
            this.btnDelete.TabIndex = 170;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnOK.Location = new System.Drawing.Point(526, 567);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 169;
            this.btnOK.Tag = "";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(98, 333);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(238, 27);
            this.txtStart.TabIndex = 172;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 171;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 173;
            this.label6.Text = "CM Approver";
            // 
            // txtCmApprover
            // 
            this.txtCmApprover.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmApprover.Location = new System.Drawing.Point(98, 366);
            this.txtCmApprover.Name = "txtCmApprover";
            this.txtCmApprover.Size = new System.Drawing.Size(238, 27);
            this.txtCmApprover.TabIndex = 174;
            this.txtCmApprover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // lblITApprovalDate
            // 
            this.lblITApprovalDate.AutoSize = true;
            this.lblITApprovalDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITApprovalDate.Location = new System.Drawing.Point(478, 368);
            this.lblITApprovalDate.Name = "lblITApprovalDate";
            this.lblITApprovalDate.Size = new System.Drawing.Size(13, 18);
            this.lblITApprovalDate.TabIndex = 184;
            this.lblITApprovalDate.Text = "-";
            // 
            // pbCm
            // 
            this.pbCm.Location = new System.Drawing.Point(445, 370);
            this.pbCm.Name = "pbCm";
            this.pbCm.Size = new System.Drawing.Size(16, 16);
            this.pbCm.TabIndex = 183;
            this.pbCm.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(348, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 182;
            this.label12.Text = "CM Approval";
            // 
            // lblApprovalDate
            // 
            this.lblApprovalDate.AutoSize = true;
            this.lblApprovalDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovalDate.Location = new System.Drawing.Point(478, 304);
            this.lblApprovalDate.Name = "lblApprovalDate";
            this.lblApprovalDate.Size = new System.Drawing.Size(13, 18);
            this.lblApprovalDate.TabIndex = 181;
            this.lblApprovalDate.Text = "-";
            // 
            // pbApproval
            // 
            this.pbApproval.Image = global::KDTHK_SYS_MAN_CONSOLE.Properties.Resources.tick_icon;
            this.pbApproval.Location = new System.Drawing.Point(445, 306);
            this.pbApproval.Name = "pbApproval";
            this.pbApproval.Size = new System.Drawing.Size(16, 16);
            this.pbApproval.TabIndex = 180;
            this.pbApproval.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 179;
            this.label9.Text = "Approval";
            // 
            // PFormR3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(720, 604);
            this.Controls.Add(this.lblITApprovalDate);
            this.Controls.Add(this.pbCm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblApprovalDate);
            this.Controls.Add(this.pbApproval);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCmApprover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lklAttachment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApprover);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PFormR3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFormR3";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApproval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApprover;
        private System.Windows.Forms.Label label7;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklAttachment;
        private System.Windows.Forms.Label label3;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCmApprover;
        private System.Windows.Forms.Label lblITApprovalDate;
        private System.Windows.Forms.PictureBox pbCm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblApprovalDate;
        private System.Windows.Forms.PictureBox pbApproval;
        private System.Windows.Forms.Label label9;
    }
}