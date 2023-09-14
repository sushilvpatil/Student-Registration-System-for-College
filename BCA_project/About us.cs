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
    public partial class About_us : Form
    {

        Thread th;

        public About_us()
        {
            InitializeComponent();
        }


        public void form1(object obj)     //function for jump to  home  page
        {
            Application.Run(new Form1());

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(form1);     //calling function form  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
