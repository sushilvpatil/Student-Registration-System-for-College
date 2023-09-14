namespace BCA_project
{
    partial class Fee_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fee_payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coursetxt = new System.Windows.Forms.TextBox();
            this.gentatbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.notetxt = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 77);
            this.panel1.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Black;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home.Location = new System.Drawing.Point(748, 28);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 28);
            this.home.TabIndex = 14;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(380, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fess payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Id";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(151, 116);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(157, 20);
            this.idtxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(67, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "enter name";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(151, 167);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(157, 20);
            this.nametxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(67, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "enter Course\r\n";
            // 
            // coursetxt
            // 
            this.coursetxt.Location = new System.Drawing.Point(151, 216);
            this.coursetxt.Name = "coursetxt";
            this.coursetxt.Size = new System.Drawing.Size(157, 20);
            this.coursetxt.TabIndex = 2;
            // 
            // gentatbtn
            // 
            this.gentatbtn.BackColor = System.Drawing.Color.Black;
            this.gentatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gentatbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gentatbtn.Location = new System.Drawing.Point(28, 350);
            this.gentatbtn.Name = "gentatbtn";
            this.gentatbtn.Size = new System.Drawing.Size(75, 28);
            this.gentatbtn.TabIndex = 8;
            this.gentatbtn.Text = "Generate";
            this.gentatbtn.UseVisualStyleBackColor = false;
            this.gentatbtn.Click += new System.EventHandler(this.gentatbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Black;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetbtn.Location = new System.Drawing.Point(151, 350);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 28);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(272, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(67, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "enter Amount\r\n";
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(151, 264);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(157, 20);
            this.amounttxt.TabIndex = 3;
            // 
            // notetxt
            // 
            this.notetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetxt.Location = new System.Drawing.Point(401, 73);
            this.notetxt.Name = "notetxt";
            this.notetxt.Size = new System.Drawing.Size(442, 365);
            this.notetxt.TabIndex = 13;
            this.notetxt.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Fee_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(846, 440);
            this.Controls.Add(this.notetxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.gentatbtn);
            this.Controls.Add(this.coursetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fee_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee_payment";
            this.Load += new System.EventHandler(this.Fee_payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coursetxt;
        private System.Windows.Forms.Button gentatbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.RichTextBox notetxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button home;
    }
}