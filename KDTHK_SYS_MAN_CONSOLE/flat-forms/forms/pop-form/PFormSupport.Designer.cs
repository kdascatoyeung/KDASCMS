namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    partial class PFormSupport
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
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.customPanel5 = new CustomUtil.controls.panel.CustomPanel();
            this.lbSuggestionAnswer = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.customPanel4 = new CustomUtil.controls.panel.CustomPanel();
            this.lbSuggestionQuestion = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSoftware = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHardware = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbComplete = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAssign = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(416, 305);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(300, 27);
            this.txtEnd.TabIndex = 148;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 147;
            this.label4.Text = "End";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(102, 305);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(238, 27);
            this.txtStart.TabIndex = 146;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 145;
            this.label3.Text = "Start";
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
            this.customPanel1.Location = new System.Drawing.Point(102, 84);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(614, 215);
            this.customPanel1.TabIndex = 143;
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
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 144;
            this.label2.Text = "Content";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(102, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(614, 27);
            this.txtName.TabIndex = 142;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 141;
            this.label1.Text = "Applicant";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(77)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnAdd.Location = new System.Drawing.Point(102, 685);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 30);
            this.btnAdd.TabIndex = 158;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
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
            this.btnSave.Location = new System.Drawing.Point(494, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 157;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // customPanel5
            // 
            this.customPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel5.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel5.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel5.BorderWidth = 1;
            this.customPanel5.Controls.Add(this.lbSuggestionAnswer);
            this.customPanel5.Curvature = 1;
            this.customPanel5.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel5.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel5.Location = new System.Drawing.Point(102, 574);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(614, 101);
            this.customPanel5.TabIndex = 156;
            // 
            // lbSuggestionAnswer
            // 
            this.lbSuggestionAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuggestionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSuggestionAnswer.FormattingEnabled = true;
            this.lbSuggestionAnswer.ItemHeight = 15;
            this.lbSuggestionAnswer.Location = new System.Drawing.Point(3, 3);
            this.lbSuggestionAnswer.Name = "lbSuggestionAnswer";
            this.lbSuggestionAnswer.Size = new System.Drawing.Size(608, 90);
            this.lbSuggestionAnswer.TabIndex = 25;
            this.lbSuggestionAnswer.DoubleClick += new System.EventHandler(this.lbSuggestionAnswer_DoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 155;
            this.label14.Text = "Suggestion";
            // 
            // txtSolution
            // 
            this.txtSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolution.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolution.Location = new System.Drawing.Point(102, 541);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(614, 27);
            this.txtSolution.TabIndex = 154;
            this.txtSolution.TextChanged += new System.EventHandler(this.txtSolution_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 545);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 18);
            this.label15.TabIndex = 153;
            this.label15.Text = "Solution";
            // 
            // customPanel4
            // 
            this.customPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel4.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel4.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel4.BorderWidth = 1;
            this.customPanel4.Controls.Add(this.lbSuggestionQuestion);
            this.customPanel4.Curvature = 1;
            this.customPanel4.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel4.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel4.Location = new System.Drawing.Point(102, 437);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(614, 98);
            this.customPanel4.TabIndex = 152;
            // 
            // lbSuggestionQuestion
            // 
            this.lbSuggestionQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSuggestionQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSuggestionQuestion.FormattingEnabled = true;
            this.lbSuggestionQuestion.ItemHeight = 15;
            this.lbSuggestionQuestion.Location = new System.Drawing.Point(3, 3);
            this.lbSuggestionQuestion.Name = "lbSuggestionQuestion";
            this.lbSuggestionQuestion.Size = new System.Drawing.Size(608, 90);
            this.lbSuggestionQuestion.TabIndex = 25;
            this.lbSuggestionQuestion.DoubleClick += new System.EventHandler(this.lbSuggestionQuestion_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 151;
            this.label13.Text = "Suggestion";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(102, 404);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(614, 27);
            this.txtQuestion.TabIndex = 150;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 149;
            this.label12.Text = "Question";
            // 
            // cbSoftware
            // 
            this.cbSoftware.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoftware.FormattingEnabled = true;
            this.cbSoftware.Location = new System.Drawing.Point(416, 338);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(300, 27);
            this.cbSoftware.TabIndex = 162;
            this.cbSoftware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 161;
            this.label10.Text = "Software";
            // 
            // cbHardware
            // 
            this.cbHardware.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHardware.FormattingEnabled = true;
            this.cbHardware.Location = new System.Drawing.Point(102, 338);
            this.cbHardware.Name = "cbHardware";
            this.cbHardware.Size = new System.Drawing.Size(238, 27);
            this.cbHardware.TabIndex = 160;
            this.cbHardware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 159;
            this.label9.Text = "Hardware";
            // 
            // ckbComplete
            // 
            this.ckbComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbComplete.AutoSize = true;
            this.ckbComplete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbComplete.Location = new System.Drawing.Point(398, 690);
            this.ckbComplete.Name = "ckbComplete";
            this.ckbComplete.Size = new System.Drawing.Size(90, 23);
            this.ckbComplete.TabIndex = 163;
            this.ckbComplete.Text = "Complete";
            this.ckbComplete.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(102, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(614, 27);
            this.txtTitle.TabIndex = 165;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 164;
            this.label5.Text = "Title";
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
            this.btnDelete.Location = new System.Drawing.Point(608, 686);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 30);
            this.btnDelete.TabIndex = 166;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAssign
            // 
            this.cbAssign.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssign.FormattingEnabled = true;
            this.cbAssign.Location = new System.Drawing.Point(102, 371);
            this.cbAssign.Name = "cbAssign";
            this.cbAssign.Size = new System.Drawing.Size(238, 27);
            this.cbAssign.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 167;
            this.label6.Text = "Assign To";
            // 
            // PFormSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(727, 727);
            this.Controls.Add(this.cbAssign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbComplete);
            this.Controls.Add(this.cbSoftware);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbHardware);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PFormSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFormSupport";
            this.customPanel1.ResumeLayout(false);
            this.customPanel5.ResumeLayout(false);
            this.customPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private CustomUtil.controls.panel.CustomPanel customPanel5;
        private System.Windows.Forms.ListBox lbSuggestionAnswer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label label15;
        private CustomUtil.controls.panel.CustomPanel customPanel4;
        private System.Windows.Forms.ListBox lbSuggestionQuestion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSoftware;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHardware;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbComplete;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbAssign;
        private System.Windows.Forms.Label label6;
    }
}