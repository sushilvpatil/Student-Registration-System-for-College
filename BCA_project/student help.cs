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
    public partial class student_help : Form
    {

        Thread th;

        public student_help()
        {
            InitializeComponent();
        }

        public void openmdi(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new student2());

        }

        public void form1(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new Form1());

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact to Admin or Teacher", "Addmition", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void holidaybtn_Click(object sender, EventArgs e)
        {
            holidaylbl.Visible = true;
        }

        private void syllabusbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.elcomblus.com/the-different-types-of-syllabus-according-to-reilley/");
        }

        private void Resultbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Results Not Published yet","Result",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact To Admin", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(form1);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
