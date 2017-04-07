namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnOverview = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMasterView = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOverview,
            this.tsbtnMasterView,
            this.tsbtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1220, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnOverview
            // 
            this.tsbtnOverview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnOverview.ForeColor = System.Drawing.Color.White;
            this.tsbtnOverview.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOverview.Image")));
            this.tsbtnOverview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOverview.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tsbtnOverview.Name = "tsbtnOverview";
            this.tsbtnOverview.Size = new System.Drawing.Size(62, 22);
            this.tsbtnOverview.Text = "Overview";
            this.tsbtnOverview.Click += new System.EventHandler(this.tsbtnOverview_Click);
            // 
            // tsbtnMasterView
            // 
            this.tsbtnMasterView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMasterView.ForeColor = System.Drawing.Color.White;
            this.tsbtnMasterView.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMasterView.Image")));
            this.tsbtnMasterView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMasterView.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tsbtnMasterView.Name = "tsbtnMasterView";
            this.tsbtnMasterView.Size = new System.Drawing.Size(75, 22);
            this.tsbtnMasterView.Text = "Masterview";
            this.tsbtnMasterView.Click += new System.EventHandler(this.tsbtnMasterView_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(0, 23);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1220, 618);
            this.pnlMain.TabIndex = 1;
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRefresh.ForeColor = System.Drawing.Color.White;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(52, 22);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMain";
            this.Size = new System.Drawing.Size(1220, 641);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnOverview;
        private System.Windows.Forms.ToolStripButton tsbtnMasterView;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
    }
}
