namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationOverview));
            this.pnlMain = new CustomUtil.controls.panel.CustomPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEducation = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStaff = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAnswers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEmail = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReport = new System.Windows.Forms.ToolStripButton();
            this.pnlControl = new CustomUtil.controls.panel.CustomPanel();
            this.pnlMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Controls.Add(this.pnlControl);
            this.pnlMain.Controls.Add(this.toolStrip1);
            this.pnlMain.Curvature = 1;
            this.pnlMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1161, 644);
            this.pnlMain.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnEducation,
            this.tsbtnStaff,
            this.tsbtnAnswers,
            this.tsbtnEmail,
            this.tsbtnReport});
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1159, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(50, 22);
            this.tsbtnNew.Text = "New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnEducation
            // 
            this.tsbtnEducation.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEducation.Image")));
            this.tsbtnEducation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEducation.Name = "tsbtnEducation";
            this.tsbtnEducation.Size = new System.Drawing.Size(81, 22);
            this.tsbtnEducation.Text = "Education";
            this.tsbtnEducation.Click += new System.EventHandler(this.tsbtnEducation_Click);
            // 
            // tsbtnStaff
            // 
            this.tsbtnStaff.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStaff.Image")));
            this.tsbtnStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStaff.Name = "tsbtnStaff";
            this.tsbtnStaff.Size = new System.Drawing.Size(52, 22);
            this.tsbtnStaff.Text = "Staff";
            this.tsbtnStaff.Click += new System.EventHandler(this.tsbtnStaff_Click);
            // 
            // tsbtnAnswers
            // 
            this.tsbtnAnswers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAnswers.Image")));
            this.tsbtnAnswers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAnswers.Name = "tsbtnAnswers";
            this.tsbtnAnswers.Size = new System.Drawing.Size(73, 22);
            this.tsbtnAnswers.Text = "Answers";
            this.tsbtnAnswers.Click += new System.EventHandler(this.tsbtnAnswers_Click);
            // 
            // tsbtnEmail
            // 
            this.tsbtnEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEmail.Image")));
            this.tsbtnEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEmail.Name = "tsbtnEmail";
            this.tsbtnEmail.Size = new System.Drawing.Size(58, 22);
            this.tsbtnEmail.Text = "Email";
            this.tsbtnEmail.Click += new System.EventHandler(this.tsbtnEmail_Click);
            // 
            // tsbtnReport
            // 
            this.tsbtnReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReport.Image")));
            this.tsbtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReport.Name = "tsbtnReport";
            this.tsbtnReport.Size = new System.Drawing.Size(63, 22);
            this.tsbtnReport.Text = "Report";
            this.tsbtnReport.Click += new System.EventHandler(this.tsbtnReport_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BackColor = System.Drawing.SystemColors.Window;
            this.pnlControl.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlControl.BorderColor = System.Drawing.Color.Silver;
            this.pnlControl.BorderWidth = 1;
            this.pnlControl.Curvature = 1;
            this.pnlControl.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlControl.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlControl.Location = new System.Drawing.Point(3, 26);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1155, 615);
            this.pnlControl.TabIndex = 7;
            // 
            // EducationOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationOverview";
            this.Size = new System.Drawing.Size(1161, 644);
            this.pnlMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripButton tsbtnEducation;
        private System.Windows.Forms.ToolStripButton tsbtnStaff;
        private System.Windows.Forms.ToolStripButton tsbtnAnswers;
        private System.Windows.Forms.ToolStripButton tsbtnEmail;
        private System.Windows.Forms.ToolStripButton tsbtnReport;
        private CustomUtil.controls.panel.CustomPanel pnlControl;
    }
}
