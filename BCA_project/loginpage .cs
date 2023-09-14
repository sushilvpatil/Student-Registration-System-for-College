using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;



namespace BCA_project
{
    public partial class loginpage : Form
    {
        Thread th;    //using namespace treading
        public loginpage()
        {
           

            InitializeComponent();
            
           
           

        }

       



        public void openmdi(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new ragisterer());

        }

        public void openlogin(object obj2)  //function for jump to login sucess main page
        {
            Application.Run(new Form1());
        }

        public void skippage(object obj2)  //function for jump to login sucess main page
        {
            Application.Run(new skipfor_now ());
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(skippage);     //calling function skippage  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (emaillogin.Text == "" && passlogin.Text == "")
            {

                loginfailedlbl.Visible = true;

            }
            else
            {


                string cs = ConfigurationManager.ConnectionStrings["signup.sql"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query4 = "select * from signup where email=@email and pass=@pass";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                cmd4.Parameters.AddWithValue("@email", emaillogin.Text);
                cmd4.Parameters.AddWithValue("@pass", passlogin.Text);
                con.Open();
                SqlDataReader rd2 = cmd4.ExecuteReader();
                if (rd2.HasRows == true)
                {

                    MessageBox.Show("Login success !!", "success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


                    this.Close();
                    th = new Thread(openlogin);  //calling of function openlogin   th is variable of thread
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    //Form1 f=new Form1();
                   // f.Show();


                }
                else
                {
                    MessageBox.Show("login failed !! Please check your email or password", "faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

            }  // this login failed label else brace
        }

        private void button1_Click(object sender, EventArgs e)
        {
             showbtn.BringToFront();
           passlogin.PasswordChar='\0';
           showbtn.Visible = false;
           hidebtn.Visible =true;
            
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            hidebtn.BringToFront();
            passlogin.PasswordChar = '*';
            hidebtn.Visible = false;
            showbtn.Visible = true;
        }
    }
}
