namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    partial class DiscLoading
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
            this.circularProgressBar1 = new CustomUtil.controls.progressbar.CircularProgressBar();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Interval = 60;
            this.circularProgressBar1.Location = new System.Drawing.Point(99, 22);
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(33, 32);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Rotation = CustomUtil.controls.progressbar.CircularProgressBar.Direction.CLOCKWISE;
            this.circularProgressBar1.Size = new System.Drawing.Size(85, 80);
            this.circularProgressBar1.StartAngle = 270F;
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 103);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(42, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "label1";
            // 
            // DiscLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(297, 121);
            this.ControlBox = false;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.circularProgressBar1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUtil.controls.progressbar.CircularProgressBar circularProgressBar1;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lblCount;
    }
}