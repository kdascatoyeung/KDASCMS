namespace KDTHK_SYS_MAN_CONSOLE.forms.mycloud
{
    partial class MyCloudApplicationNew2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCloudApplicationNew2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnApplication = new System.Windows.Forms.RadioButton();
            this.rbtnTools = new System.Windows.Forms.RadioButton();
            this.rbtnForms = new System.Windows.Forms.RadioButton();
            this.rbtnOthers = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.btnAdd = new CustomUtil.controls.button.CustomButton();
            this.lbStaff = new System.Windows.Forms.ListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSave = new CustomUtil.controls.button.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnOthers);
            this.panel1.Controls.Add(this.rbtnForms);
            this.panel1.Controls.Add(this.rbtnTools);
            this.panel1.Controls.Add(this.rbtnApplication);
            this.panel1.Location = new System.Drawing.Point(115, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 104);
            this.panel1.TabIndex = 1;
            // 
            // rbtnApplication
            // 
            this.rbtnApplication.AutoSize = true;
            this.rbtnApplication.Checked = true;
            this.rbtnApplication.Location = new System.Drawing.Point(3, 1);
            this.rbtnApplication.Name = "rbtnApplication";
            this.rbtnApplication.Size = new System.Drawing.Size(88, 19);
            this.rbtnApplication.TabIndex = 2;
            this.rbtnApplication.TabStop = true;
            this.rbtnApplication.Text = "Application";
            this.rbtnApplication.UseVisualStyleBackColor = true;
            // 
            // rbtnTools
            // 
            this.rbtnTools.AutoSize = true;
            this.rbtnTools.Location = new System.Drawing.Point(3, 26);
            this.rbtnTools.Name = "rbtnTools";
            this.rbtnTools.Size = new System.Drawing.Size(54, 19);
            this.rbtnTools.TabIndex = 3;
            this.rbtnTools.Text = "Tools";
            this.rbtnTools.UseVisualStyleBackColor = true;
            // 
            // rbtnForms
            // 
            this.rbtnForms.AutoSize = true;
            this.rbtnForms.Location = new System.Drawing.Point(3, 51);
            this.rbtnForms.Name = "rbtnForms";
            this.rbtnForms.Size = new System.Drawing.Size(59, 19);
            this.rbtnForms.TabIndex = 4;
            this.rbtnForms.Text = "Forms";
            this.rbtnForms.UseVisualStyleBackColor = true;
            // 
            // rbtnOthers
            // 
            this.rbtnOthers.AutoSize = true;
            this.rbtnOthers.Location = new System.Drawing.Point(3, 76);
            this.rbtnOthers.Name = "rbtnOthers";
            this.rbtnOthers.Size = new System.Drawing.Size(62, 19);
            this.rbtnOthers.TabIndex = 5;
            this.rbtnOthers.Text = "Others";
            this.rbtnOthers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Directory :";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(115, 137);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(365, 23);
            this.txtDirectory.TabIndex = 3;
            this.txtDirectory.DoubleClick += new System.EventHandler(this.txtDirectory_DoubleClick);
            this.txtDirectory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirectory_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 23);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description :";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(115, 195);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(389, 23);
            this.txtDesc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Staff Id :";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(115, 226);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(154, 23);
            this.txtStaffId.TabIndex = 9;
            this.txtStaffId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStaffId_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(275, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbStaff
            // 
            this.lbStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStaff.FormattingEnabled = true;
            this.lbStaff.ItemHeight = 15;
            this.lbStaff.Location = new System.Drawing.Point(115, 255);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(389, 212);
            this.lbStaff.TabIndex = 54;
            // 
            // btnFolder
            // 
            this.btnFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolder.BackgroundImage")));
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Location = new System.Drawing.Point(486, 141);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(16, 16);
            this.btnFolder.TabIndex = 55;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnSave.Location = new System.Drawing.Point(1081, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 56;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MyCloudApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MyCloudApplication";
            this.Size = new System.Drawing.Size(1193, 636);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnOthers;
        private System.Windows.Forms.RadioButton rbtnForms;
        private System.Windows.Forms.RadioButton rbtnTools;
        private System.Windows.Forms.RadioButton rbtnApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffId;
        private CustomUtil.controls.button.CustomButton btnAdd;
        private System.Windows.Forms.ListBox lbStaff;
        private System.Windows.Forms.Button btnFolder;
        private CustomUtil.controls.button.CustomButton btnSave;
    }
}
