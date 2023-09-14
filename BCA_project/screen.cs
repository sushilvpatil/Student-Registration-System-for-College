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
    public partial class screen : Form
    {
        
        public screen()
        {
            InitializeComponent();
        }

        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           


        }

        private void screen_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Width += 8;
            if (panel1.Width >= 800)
            { timer2.Stop();
            loginpage l = new loginpage();
            l.Show();
            this.Hide();
            
            
            }
        }

        }
    }

