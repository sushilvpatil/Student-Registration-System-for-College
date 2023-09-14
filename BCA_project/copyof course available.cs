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
    public partial class copyof_course_available : Form
    {
        Thread th;
        public copyof_course_available()
        {
            InitializeComponent();
        }

        public void skip_page()
        {
            Application.Run(new skipfor_now());
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(skip_page);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
           
           
        }
    }
}
