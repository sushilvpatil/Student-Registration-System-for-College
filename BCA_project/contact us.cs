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
    public partial class contact_us : Form
    {
        Thread th;
        public contact_us()
        {
            InitializeComponent();
        }

        public void homepage(object obj)
        {
            Application.Run(new Form1());
        
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(homepage);     //calling function home page  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
