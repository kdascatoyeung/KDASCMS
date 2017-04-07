namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    partial class EducationMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFailedList = new CustomUtil.controls.datagrid.CustomDatagrid();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSelectAll = new CustomUtil.controls.button.CustomButton();
            this.btnFail = new CustomUtil.controls.button.CustomButton();
            this.btnWaiting = new CustomUtil.controls.button.CustomButton();
            this.btnSend = new CustomUtil.controls.button.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject :";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(80, 22);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(322, 23);
            this.txtSubject.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(80, 51);
            this.txtContent.MaxLength = 2147483647;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(554, 226);
            this.txtContent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Content :";
            // 
            // dgvFailedList
            // 
            this.dgvFailedList.AllowUserToAddRows = false;
            this.dgvFailedList.AllowUserToDeleteRows = false;
            this.dgvFailedList.AllowUserToResizeRows = false;
            this.dgvFailedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFailedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFailedList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFailedList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFailedList.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgvFailedList.ColumnHeaderColor2 = System.Drawing.Color.WhiteSmoke;
            this.dgvFailedList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFailedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompany,
            this.colstaffid,
            this.coldatetime,
            this.colcheck});
            this.dgvFailedList.Location = new System.Drawing.Point(80, 283);
            this.dgvFailedList.Name = "dgvFailedList";
            this.dgvFailedList.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgvFailedList.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgvFailedList.RowHeadersVisible = false;
            this.dgvFailedList.SecondaryLength = 2;
            this.dgvFailedList.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgvFailedList.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgvFailedList.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgvFailedList.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgvFailedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFailedList.Size = new System.Drawing.Size(554, 262);
            this.dgvFailedList.TabIndex = 7;
            // 
            // colCompany
            // 
            this.colCompany.DataPropertyName = "company";
            this.colCompany.FillWeight = 50F;
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colstaffid
            // 
            this.colstaffid.DataPropertyName = "staffid";
            this.colstaffid.FillWeight = 90F;
            this.colstaffid.HeaderText = "Staff Id";
            this.colstaffid.Name = "colstaffid";
            // 
            // coldatetime
            // 
            this.coldatetime.DataPropertyName = "name";
            this.coldatetime.FillWeight = 140F;
            this.coldatetime.HeaderText = "Name";
            this.coldatetime.Name = "coldatetime";
            this.coldatetime.ReadOnly = true;
            // 
            // colcheck
            // 
            this.colcheck.DataPropertyName = "select";
            this.colcheck.FillWeight = 40F;
            this.colcheck.HeaderText = "Select";
            this.colcheck.Name = "colcheck";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSelectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectAll.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnSelectAll.Location = new System.Drawing.Point(295, 551);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSelectAll.Size = new System.Drawing.Size(109, 23);
            this.btnSelectAll.TabIndex = 53;
            this.btnSelectAll.Tag = "";
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnFail
            // 
            this.btnFail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFail.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFail.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnFail.Location = new System.Drawing.Point(410, 551);
            this.btnFail.Name = "btnFail";
            this.btnFail.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnFail.Size = new System.Drawing.Size(109, 23);
            this.btnFail.TabIndex = 54;
            this.btnFail.Tag = "";
            this.btnFail.Text = "Failed";
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnWaiting
            // 
            this.btnWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWaiting.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWaiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWaiting.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnWaiting.Location = new System.Drawing.Point(525, 551);
            this.btnWaiting.Name = "btnWaiting";
            this.btnWaiting.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnWaiting.Size = new System.Drawing.Size(109, 23);
            this.btnWaiting.TabIndex = 55;
            this.btnWaiting.Tag = "";
            this.btnWaiting.Text = "Waiting";
            this.btnWaiting.Click += new System.EventHandler(this.btnWaiting_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnSend.Location = new System.Drawing.Point(1101, 608);
            this.btnSend.Name = "btnSend";
            this.btnSend.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSend.Size = new System.Drawing.Size(109, 23);
            this.btnSend.TabIndex = 56;
            this.btnSend.Tag = "";
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // EducationMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnWaiting);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dgvFailedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EducationMail";
            this.Size = new System.Drawing.Size(1213, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private CustomUtil.controls.datagrid.CustomDatagrid dgvFailedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstaffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldatetime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colcheck;
        private CustomUtil.controls.button.CustomButton btnSelectAll;
        private CustomUtil.controls.button.CustomButton btnFail;
        private CustomUtil.controls.button.CustomButton btnWaiting;
        private CustomUtil.controls.button.CustomButton btnSend;
    }
}
