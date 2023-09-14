using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;

namespace BCA_project
{
    public partial class Fee_payment : Form
    {
        Thread th;
        public Fee_payment()
        {
            InitializeComponent();
        }

        public void homepage(object obj)
        {
            Application.Run(new Form1());
        }

        private void Fee_payment_Load(object sender, EventArgs e)
        {

        }

        private void gentatbtn_Click(object sender, EventArgs e)
        {

            if (idtxt.Text == "")
            {
                MessageBox.Show("Please Enter All Deatails", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nametxt.Text == "")
            { MessageBox.Show("Please Enter All Deatails", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (coursetxt.Text == "")
            { MessageBox.Show("Please Enter All Deatails", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (amounttxt.Text == "")
            { MessageBox.Show("Please Enter All Deatails", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            else
            {


                string coneection = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                OleDbConnection con4 = new OleDbConnection(coneection);

                string query7 = "select * from student where ID=@id  ";
                OleDbCommand cmd7 = new OleDbCommand(query7, con4);
                cmd7.Parameters.AddWithValue("@id", idtxt.Text);

                con4.Open();
                OleDbDataReader rd1 = cmd7.ExecuteReader();
                if (rd1.HasRows == true)
                {
                    notetxt.Clear();
                    notetxt.Text += "************************************\n";
                    notetxt.Text += "**        Fee Reciept      ** \n";
                    notetxt.Text += "************************************\n";
                    notetxt.Text += "Date:    " + DateTime.Now + "\n\n";


                    notetxt.Text += "Student id:   " + idtxt.Text + "\n\n";
                    notetxt.Text += "Student Name:   " + nametxt.Text + "\n\n";
                    notetxt.Text += " Course:   " + coursetxt.Text + "\n\n";
                    notetxt.Text += "Amount :   " + amounttxt.Text + "\n\n\n";

                    notetxt.Text += "                        Signature";


                    string con = ConfigurationManager.ConnectionStrings["fee_payment.sql"].ConnectionString;
                   SqlConnection con5 = new SqlConnection(con);

                   string query8 = "insert into fee_payment values(@id,@name,@course,@Amount)  ";
                   SqlCommand cmd8 = new SqlCommand(query8, con5);
                    cmd8.Parameters.AddWithValue("@id", idtxt.Text);
                    cmd8.Parameters.AddWithValue("@name", nametxt.Text);
                    cmd8.Parameters.AddWithValue("@course", coursetxt.Text);
                    cmd8.Parameters.AddWithValue("@Amount", amounttxt.Text);


                    con5.Open();
                    int a = cmd8.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("  Fees paid Successfully !!  ",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else { con5.Close(); MessageBox.Show("payment details not saved"); }
                    

                }

                else
                {

                    MessageBox.Show("  you have not Ragistered yet !! please Ragisterd first then pay the fees ",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    con4.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idtxt.Clear();
            nametxt.Clear();
            coursetxt.Clear();
            amounttxt.Clear();
            notetxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(notetxt.Text, new Font("Microsoft Sans Serif",20,FontStyle.Bold),Brushes.Black,new Point(10,10));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(homepage);     //calling function homepage  and th is variable of treahde
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
