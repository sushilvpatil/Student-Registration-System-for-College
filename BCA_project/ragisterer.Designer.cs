namespace BCA_project
{
    partial class ragisterer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ragisterer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idbtn = new System.Windows.Forms.TextBox();
            this.namebtn = new System.Windows.Forms.TextBox();
            this.surnamebtn = new System.Windows.Forms.TextBox();
            this.emailbtn = new System.Windows.Forms.TextBox();
            this.passbtn = new System.Windows.Forms.TextBox();
            this.confirmpassbtn = new System.Windows.Forms.TextBox();
            this.ragiterbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classcombo = new System.Windows.Forms.ComboBox();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hidebtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(438, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ragister Yourself";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(386, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(358, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(330, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(358, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Class";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(342, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enter Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(358, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(325, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(324, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Confirm Password";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // idbtn
            // 
            this.idbtn.Location = new System.Drawing.Point(468, 86);
            this.idbtn.Name = "idbtn";
            this.idbtn.Size = new System.Drawing.Size(160, 20);
            this.idbtn.TabIndex = 0;
            // 
            // namebtn
            // 
            this.namebtn.Location = new System.Drawing.Point(468, 135);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(160, 20);
            this.namebtn.TabIndex = 1;
            // 
            // surnamebtn
            // 
            this.surnamebtn.Location = new System.Drawing.Point(468, 181);
            this.surnamebtn.Name = "surnamebtn";
            this.surnamebtn.Size = new System.Drawing.Size(160, 20);
            this.surnamebtn.TabIndex = 2;
            // 
            // emailbtn
            // 
            this.emailbtn.Location = new System.Drawing.Point(468, 314);
            this.emailbtn.Name = "emailbtn";
            this.emailbtn.Size = new System.Drawing.Size(160, 20);
            this.emailbtn.TabIndex = 5;
            this.emailbtn.TextChanged += new System.EventHandler(this.emailbtn_TextChanged);
            this.emailbtn.Leave += new System.EventHandler(this.emailbtn_Leave);
            // 
            // passbtn
            // 
            this.passbtn.Location = new System.Drawing.Point(470, 357);
            this.passbtn.Name = "passbtn";
            this.passbtn.PasswordChar = '*';
            this.passbtn.Size = new System.Drawing.Size(160, 20);
            this.passbtn.TabIndex = 6;
            // 
            // confirmpassbtn
            // 
            this.confirmpassbtn.Location = new System.Drawing.Point(485, 408);
            this.confirmpassbtn.Name = "confirmpassbtn";
            this.confirmpassbtn.PasswordChar = '*';
            this.confirmpassbtn.Size = new System.Drawing.Size(160, 20);
            this.confirmpassbtn.TabIndex = 7;
            this.confirmpassbtn.Leave += new System.EventHandler(this.confirmpassbtn_Leave);
            // 
            // ragiterbtn
            // 
            this.ragiterbtn.BackColor = System.Drawing.Color.Black;
            this.ragiterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ragiterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ragiterbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ragiterbtn.Location = new System.Drawing.Point(448, 451);
            this.ragiterbtn.Name = "ragiterbtn";
            this.ragiterbtn.Size = new System.Drawing.Size(106, 32);
            this.ragiterbtn.TabIndex = 18;
            this.ragiterbtn.Text = "Ragister";
            this.ragiterbtn.UseVisualStyleBackColor = false;
            this.ragiterbtn.Click += new System.EventHandler(this.ragiterbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(570, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // classcombo
            // 
            this.classcombo.FormattingEnabled = true;
            this.classcombo.Items.AddRange(new object[] {
            "BBA",
            "BCA",
            "BE COMP.",
            "DIPLOMA",
            "BSC",
            "B.TECH",
            "MBA",
            "MCA",
            "ME COMP",
            "MSC",
            "M TECH",
            "CIVIL EG."});
            this.classcombo.Location = new System.Drawing.Point(470, 270);
            this.classcombo.Name = "classcombo";
            this.classcombo.Size = new System.Drawing.Size(160, 21);
            this.classcombo.TabIndex = 4;
            // 
            // gendercombo
            // 
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gendercombo.Location = new System.Drawing.Point(468, 223);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(160, 21);
            this.gendercombo.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.confirmpassbtn_Leave);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // hidebtn
            // 
            this.hidebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidebtn.BackgroundImage")));
            this.hidebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidebtn.Location = new System.Drawing.Point(602, 357);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(28, 20);
            this.hidebtn.TabIndex = 44;
            this.hidebtn.UseVisualStyleBackColor = true;
            this.hidebtn.Click += new System.EventHandler(this.hidebtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showbtn.BackgroundImage")));
            this.showbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showbtn.Location = new System.Drawing.Point(601, 355);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(29, 22);
            this.showbtn.TabIndex = 45;
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(616, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 22);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ragisterer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.hidebtn);
            this.Controls.Add(this.gendercombo);
            this.Controls.Add(this.classcombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ragiterbtn);
            this.Controls.Add(this.confirmpassbtn);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.emailbtn);
            this.Controls.Add(this.surnamebtn);
            this.Controls.Add(this.namebtn);
            this.Controls.Add(this.idbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ragisterer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ragisterer";
            this.Load += new System.EventHandler(this.ragisterer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idbtn;
        private System.Windows.Forms.TextBox namebtn;
        private System.Windows.Forms.TextBox surnamebtn;
        private System.Windows.Forms.TextBox emailbtn;
        private System.Windows.Forms.TextBox passbtn;
        private System.Windows.Forms.TextBox confirmpassbtn;
        private System.Windows.Forms.Button ragiterbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classcombo;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button hidebtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button button2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}