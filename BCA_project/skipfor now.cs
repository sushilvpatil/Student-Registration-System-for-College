using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BCA_project
{
    public partial class skipfor_now : Form
    {
        Thread th;
        public skipfor_now()
        {
            InitializeComponent();
        }

        public void copy_coursepage(object obj)
        { 
           Application.Run(new copyof_course_available());
        
        }

        public void loginpage(object obj)
        {
            Application.Run(new loginpage());

        }

        private void student_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have to Ragisterd and Login First", "Can't Open",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(copy_coursepage);     //calling function coursepage  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void feepaymentbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Have to Ragisterd and Login First", "Can't Open", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            abooutuslbl.Visible = false;
            aboutuslbl2.Visible = false;
            contactlbl.Visible = true;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(loginpage);     //calling function coursepage  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutusbtn_Click(object sender, EventArgs e)
        {
            contactlbl.Visible = false;
            abooutuslbl.Visible = true;
            aboutuslbl2.Visible = true;
        }

        private void studenthelpbtn_Click(object sender, EventArgs e)
        {
            ragisterer r = new ragisterer();
            r.Show();
            this.Hide();
        }

        private void googlebtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com/sushilpatil562@gmail.com");
        }

        private void twiterbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twiter.com");
        }

        private void instagrambtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instagram.com/university");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/sushil.patil.984991");
        }

        private void youtubbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://WWW.youtube.com/univerity");
        }

        private void recordbtn_Leave(object sender, EventArgs e)
        {
            contactlbl.Visible = false;
        }

        private void recordbtn_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void aboutusbtn_Leave(object sender, EventArgs e)
        {
            abooutuslbl.Visible = false;
            aboutuslbl2.Visible = false;
        }
    }
}
