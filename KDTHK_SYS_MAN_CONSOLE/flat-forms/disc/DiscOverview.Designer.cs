namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    partial class DiscOverview
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRequest = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHistory = new System.Windows.Forms.ToolStripButton();
            this.pnlDiscMain = new CustomUtil.controls.panel.CustomPanel();
            this.tsbtnIdle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRequest,
            this.tsbtnHistory,
            this.tsbtnIdle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1226, 25);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRequest
            // 
            this.tsbtnRequest.ForeColor = System.Drawing.Color.Red;
            this.tsbtnRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRequest.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsbtnRequest.Name = "tsbtnRequest";
            this.tsbtnRequest.Size = new System.Drawing.Size(66, 22);
            this.tsbtnRequest.Tag = "requested";
            this.tsbtnRequest.Text = "Requested";
            this.tsbtnRequest.Click += new System.EventHandler(this.tsbtnRequest_Click);
            // 
            // tsbtnHistory
            // 
            this.tsbtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHistory.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsbtnHistory.Name = "tsbtnHistory";
            this.tsbtnHistory.Size = new System.Drawing.Size(49, 22);
            this.tsbtnHistory.Tag = "history";
            this.tsbtnHistory.Text = "History";
            this.tsbtnHistory.Click += new System.EventHandler(this.tsbtnHistory_Click);
            // 
            // pnlDiscMain
            // 
            this.pnlDiscMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDiscMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDiscMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlDiscMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlDiscMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiscMain.BorderWidth = 1;
            this.pnlDiscMain.Curvature = 3;
            this.pnlDiscMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlDiscMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlDiscMain.Location = new System.Drawing.Point(0, 24);
            this.pnlDiscMain.Name = "pnlDiscMain";
            this.pnlDiscMain.Size = new System.Drawing.Size(1226, 622);
            this.pnlDiscMain.TabIndex = 71;
            // 
            // tsbtnIdle
            // 
            this.tsbtnIdle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIdle.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsbtnIdle.Name = "tsbtnIdle";
            this.tsbtnIdle.Size = new System.Drawing.Size(30, 22);
            this.tsbtnIdle.Tag = "idle";
            this.tsbtnIdle.Text = "Idle";
            this.tsbtnIdle.Click += new System.EventHandler(this.tsbtnIdle_Click);
            // 
            // DiscOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlDiscMain);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DiscOverview";
            this.Size = new System.Drawing.Size(1226, 646);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRequest;
        private System.Windows.Forms.ToolStripButton tsbtnHistory;
        private CustomUtil.controls.panel.CustomPanel pnlDiscMain;
        private System.Windows.Forms.ToolStripButton tsbtnIdle;
    }
}
