namespace BCA_project
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emaillogin = new System.Windows.Forms.TextBox();
            this.passlogin = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.skipbtn = new System.Windows.Forms.Button();
            this.loginfailedlbl = new System.Windows.Forms.Label();
            this.showbtn = new System.Windows.Forms.Button();
            this.hidebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(336, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(336, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password:";
            // 
            // emaillogin
            // 
            this.emaillogin.Location = new System.Drawing.Point(471, 177);
            this.emaillogin.Name = "emaillogin";
            this.emaillogin.Size = new System.Drawing.Size(162, 20);
            this.emaillogin.TabIndex = 2;
            // 
            // passlogin
            // 
            this.passlogin.Location = new System.Drawing.Point(471, 223);
            this.passlogin.Name = "passlogin";
            this.passlogin.PasswordChar = '*';
            this.passlogin.Size = new System.Drawing.Size(162, 20);
            this.passlogin.TabIndex = 3;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Black;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(471, 272);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 32);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(321, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to The university";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(422, 330);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not Ragister Yet ? Ragister Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // skipbtn
            // 
            this.skipbtn.BackColor = System.Drawing.Color.Black;
            this.skipbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skipbtn.Location = new System.Drawing.Point(457, 369);
            this.skipbtn.Name = "skipbtn";
            this.skipbtn.Size = new System.Drawing.Size(159, 32);
            this.skipbtn.TabIndex = 7;
            this.skipbtn.Text = "guest ? Skip for Now";
            this.skipbtn.UseVisualStyleBackColor = false;
            this.skipbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginfailedlbl
            // 
            this.loginfailedlbl.AutoSize = true;
            this.loginfailedlbl.BackColor = System.Drawing.Color.Transparent;
            this.loginfailedlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfailedlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginfailedlbl.Location = new System.Drawing.Point(387, 115);
            this.loginfailedlbl.Name = "loginfailedlbl";
            this.loginfailedlbl.Size = new System.Drawing.Size(246, 19);
            this.loginfailedlbl.TabIndex = 8;
            this.loginfailedlbl.Text = "Login Failed ! Please Fill Both Fields";
            this.loginfailedlbl.Visible = false;
            // 
            // showbtn
            // 
            this.showbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showbtn.BackgroundImage")));
            this.showbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showbtn.Location = new System.Drawing.Point(604, 222);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(29, 22);
            this.showbtn.TabIndex = 42;
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // hidebtn
            // 
            this.hidebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidebtn.BackgroundImage")));
            this.hidebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidebtn.Location = new System.Drawing.Point(604, 223);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(34, 20);
            this.hidebtn.TabIndex = 43;
            this.hidebtn.UseVisualStyleBackColor = true;
            this.hidebtn.Visible = false;
            this.hidebtn.Click += new System.EventHandler(this.hidebtn_Click);
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 445);
            this.Controls.Add(this.hidebtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.loginfailedlbl);
            this.Controls.Add(this.skipbtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlogin);
            this.Controls.Add(this.emaillogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginpage";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emaillogin;
        private System.Windows.Forms.TextBox passlogin;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button skipbtn;
        private System.Windows.Forms.Label loginfailedlbl;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button hidebtn;
    }
}