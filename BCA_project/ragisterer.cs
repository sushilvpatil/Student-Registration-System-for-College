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
using System.Text.RegularExpressions;
using System.Threading;

namespace BCA_project
{
    public partial class ragisterer : Form
    {
        Thread th;
        public ragisterer()
        {
            InitializeComponent();
        }



        string s = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


        public void openmdi(object obj)     //function for jump to  ragistration page
        {
            Application.Run(new loginpage());

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void ragiterbtn_Click(object sender, EventArgs e)
        {
           



                if (idbtn.Text == "")
               {
                    MessageBox.Show("plese fill every detail", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (namebtn.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (surnamebtn.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (gendercombo.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (classcombo.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (emailbtn.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (passbtn.Text == "") { MessageBox.Show("plese fill every detail", " failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }



                else
                {
                   

                    string cs = ConfigurationManager.ConnectionStrings["signup.sql"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);
                    string query3 = "select * from signup where id=@id";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.Parameters.AddWithValue("@id",idbtn.Text);
                    con.Open();
                    SqlDataReader rd1 = cmd3.ExecuteReader();
                    if (rd1.HasRows == true)
                    { MessageBox.Show(idbtn.Text + " this id alredy exist !! please select another ID"); }

                    else
                    {
                        con.Close();
                        string query2 = "select * from signup where pass=@pass";
                        SqlCommand cmd2 = new SqlCommand(query2, con);         
                                                                                
                        cmd2.Parameters.AddWithValue("@pass", passbtn.Text);
                        con.Open();
                        SqlDataReader rd = cmd2.ExecuteReader();
                        if (rd.HasRows == true)
                        {
                            MessageBox.Show(passbtn.Text + " this password alredy exist !! please select another password");
                        }
                        else

                        {

                            con.Close();

                            String query = "insert into signup values(@id,@name,@surname,@gender,@class,@email,@Pass)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@id", idbtn.Text);
                            cmd.Parameters.AddWithValue("@name", namebtn.Text);
                            cmd.Parameters.AddWithValue("@surname", surnamebtn.Text);
                            cmd.Parameters.AddWithValue("@gender", gendercombo.Text);
                            cmd.Parameters.AddWithValue("@class", classcombo.Text);
                            cmd.Parameters.AddWithValue("@email", emailbtn.Text);
                            cmd.Parameters.AddWithValue("@pass", passbtn.Text);
                            con.Open();
                            int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {
                                MessageBox.Show("ragisterd succesfully !!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                                th = new Thread(openmdi);     //calling function openmdi  and th is variable of treahde
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();

                            }
                            else
                            {
                                MessageBox.Show("ragisterd failed !!", "faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con.Close();
                        }//password check else brace
                    }//id check validation else
                    
                }   //first else paranthisis
            

            }// second else paranthiss





        private void confirmpassbtn_Leave(object sender, EventArgs e)
        {
            if (passbtn.Text != confirmpassbtn.Text)
            {
                passbtn.Focus();

                errorProvider1.SetError(this.confirmpassbtn, "Password  not matched");
            }
            else { errorProvider1.Clear(); }
        }




        private void emailbtn_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(emailbtn.Text, s)==false)
            {
                emailbtn.Focus();
                errorProvider2.SetError(this.emailbtn, "invalied email");
            }

            else { errorProvider2.Clear(); }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            showbtn.BringToFront();
            passbtn.PasswordChar = '\0';
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            hidebtn.BringToFront();
            passbtn.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirmpassbtn.PasswordChar = '\0';
        }

        private void emailbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void ragisterer_Load(object sender, EventArgs e)
        {

        }  


        
    }
}
