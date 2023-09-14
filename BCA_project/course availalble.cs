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
    public partial class course_availalble : Form
    {
        Thread th;
        public course_availalble()
        {
            InitializeComponent();
        }


        public void openmdi(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new Form1());

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            this.Close();
            th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.Show();
            this.Hide();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
