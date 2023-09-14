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
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        public void openmdi(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new student2());

        }


        public void open(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new loginpage());

        }

        public void coursepage(object obj)     //function for jump to  course available page
        {
            Application.Run(new course_availalble());

        }

        public void studenthelp(object obj)     //function for jump to  student help page
        {
            Application.Run(new student_help());

        }


        public void aboutus(object obj)
        {

            Application.Run(new About_us());      //function to jump to about us page
        }

        public void contactus(object obj)
        {

            Application.Run(new contact_us());      //function to jump to contact us us page
        }

        public void feepay(object obj)
        {

            Application.Run(new Fee_payment());      //function to jump to fee payment us page
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
           
            //loginpage l = new loginpage();
           // l.Show();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/sushil.patil.984991");
        }

        private void youtubbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://WWW.youtube.com/univerity");
        }

        private void twiterbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twiter.com");
        }

        private void instagrambtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.instagram.com/university");
        }

        private void googlebtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com/sushilpatil562@gmail.com");
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(coursepage);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void studenthelpbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(studenthelp);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(aboutus);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(contactus);     //calling function ocontaus  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void feepaymentbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(feepay);     //calling function feepay  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
