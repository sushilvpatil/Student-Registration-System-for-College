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
using System.Threading;
using System.Text.RegularExpressions;

namespace BCA_project
{
    public partial class student2 : Form
    {
        Thread th;
        string s = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public student2()
        {
            InitializeComponent();
        }

        public void openmdi(object obj)
        {
            Application.Run(new Form1());
        
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (firsttxt.Text == "")
            { MessageBox.Show("Please fill all details", "Ragisteration failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {

                string coneection = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                OleDbConnection con4 = new OleDbConnection(coneection);


                string query7 = "select * from student where ID=@id";
                OleDbCommand cmd7 = new OleDbCommand(query7, con4);
                cmd7.Parameters.AddWithValue("@id", idtxt.Text);
                con4.Open();
                OleDbDataReader rd1 = cmd7.ExecuteReader();
                if (rd1.HasRows == true)
                { MessageBox.Show(idtxt.Text + " this id alredy ragistered !! please check if you have ragistered before ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



                else
                {
                    con4.Close();



 String query5 = "insert into student values(@id,@first_name,@middlename,@lastname,@email,@mobile_no,@course,@gender,@home_adress,@addhar_no,@percentage1,@percentage2,@city,@father_name,@mother_name,@pass,@DOB,@cast)";


                    OleDbCommand cmd4 = new OleDbCommand(query5, con4);

                    cmd4.Parameters.AddWithValue("@id", idtxt.Text);
                    cmd4.Parameters.AddWithValue("@first_name", firsttxt.Text);
                    cmd4.Parameters.AddWithValue("@middlename", middletxt.Text);
                    cmd4.Parameters.AddWithValue("@lastname", lasttxt.Text);
                    cmd4.Parameters.AddWithValue("@email", emailtxt.Text);
                    cmd4.Parameters.AddWithValue("@mobile_no", mobiletxt.Text);
                    cmd4.Parameters.AddWithValue("@course", coursetxt.Text);
                    cmd4.Parameters.AddWithValue("@gender", gendertxt.Text);
                    cmd4.Parameters.AddWithValue("@home_adress", addresstxt.Text);
                    cmd4.Parameters.AddWithValue("@addhar_no", aadhartxt.Text);
                    cmd4.Parameters.AddWithValue("@percentage1", percentage1txt.Text);
                    cmd4.Parameters.AddWithValue("@percentage2", percentage2txt.Text);
                    cmd4.Parameters.AddWithValue("@city", citytxt.Text);
                    cmd4.Parameters.AddWithValue("@father_name", fathernametxt.Text);
                    cmd4.Parameters.AddWithValue("@mother_name", mobiletxt.Text);
                    cmd4.Parameters.AddWithValue("@pass", passtxt.Text);
                    cmd4.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                    cmd4.Parameters.AddWithValue("@cast", casttxt.Text);

                    con4.Open();
                    int a = cmd4.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("ragisterd succesfully !!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        richTextBox1.Clear();
                        richTextBox1.Visible = true;
                        cancelbtn.Visible = true;
                        prinbtn.Visible = true;

                        richTextBox1.Text += "                 *************Student Ragistration*************\n";
                        richTextBox1.Text += " Student Id :    " + idtxt.Text + "\n";
                        richTextBox1.Text += " First Name :    " + firsttxt.Text + "\n";
                        richTextBox1.Text += " Middle Name:    " + middletxt.Text + "\n";
                        richTextBox1.Text += " Last Name  :    " + lasttxt.Text + "\n";
                        richTextBox1.Text += " Email      :    " + emailtxt.Text + "\n";
                        richTextBox1.Text += " Mobile Number:  " + firsttxt.Text + "\n";
                        richTextBox1.Text += " Course  Name :  " + coursetxt.Text + "\n";
                        richTextBox1.Text += " Gender     :    " + gendertxt.Text + "\n";
                        richTextBox1.Text += " Address    :    " + addresstxt.Text + "\n";
                        richTextBox1.Text += " Aadhar     :    " + aadhartxt.Text + "\n";
                        richTextBox1.Text += " 12th Pecentage: " + percentage1txt.Text + "\n";
                        richTextBox1.Text += " 10th Pecentage: " + percentage2txt.Text + "\n";
                        richTextBox1.Text += " City       :    " + citytxt.Text + "\n";
                        richTextBox1.Text += " Father Name:    " + fathernametxt.Text + "\n";
                        richTextBox1.Text += " Mother Name:    " + mothertxt.Text + "\n";
                        richTextBox1.Text += " Cast       :    " + casttxt.Text + "\n";
                        richTextBox1.Text += " Password   :    " + passtxt.Text + "\n";
                        richTextBox1.Text += " Date of Birth:  " + dateTimePicker1.Text + "\n\n\n\n";
                        richTextBox1.Text += "                                                Signature             ";
           



                        

                    }
                    else
                    {
                        MessageBox.Show("ragisterd failed !!", "faliure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con4.Close();
                }


            }  //id alredy exist else brace
        }    // this is first name validation brace

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idtxt.Clear();
            firsttxt.Clear();
            middletxt.Clear();
            lasttxt.Clear();
            emailtxt.Clear();
            mobiletxt.Clear();
            addresstxt.Clear();
            aadhartxt.Clear();
            percentage1txt.Clear();
            percentage2txt.Clear();
            citytxt.Clear();
            fathernametxt.Clear();
            mothertxt.Clear();
            passtxt.Clear();
            casttxt.Clear();
            
            
               

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(openmdi);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
       
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
           
        }

        private void idtxt_Leave(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                idtxt.Focus();

                confirmerror.SetError(this.idtxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void firsttxt_Leave(object sender, EventArgs e)
        {
            if (firsttxt.Text == "")
            {
                firsttxt.Focus();

                confirmerror.SetError(this.firsttxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void middletxt_Leave(object sender, EventArgs e)
        {
            if (middletxt.Text == "")
            {
               middletxt.Focus();

                confirmerror.SetError(this.middletxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void lasttxt_Leave(object sender, EventArgs e)
        {
            if (lasttxt.Text == "")
            {
               lasttxt.Focus();

                confirmerror.SetError(this.lasttxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void emailtxt_Leave(object sender, EventArgs e)
        {
            if (emailtxt.Text == "")
            {
                emailtxt.Focus();

                confirmerror.SetError(this.emailtxt, "Mandetary to Fill");
            }

              


            else { confirmerror.Clear();

           if (Regex.IsMatch(emailtxt.Text, s) == false)
            {
                emailtxt.Focus();
                confirmerror.SetError(this.emailtxt, "invalied email");
            }

            else { confirmerror.Clear(); }
            
            
            }
        }



        private void mobiletxt_Leave(object sender, EventArgs e)
        {

            
            if (mobiletxt.Text == "")
            {
               mobiletxt.Focus();

                confirmerror.SetError(this.mobiletxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void coursetxt_Leave(object sender, EventArgs e)
        {
            if (coursetxt.Text == "")
            {
                coursetxt.Focus();

                confirmerror.SetError(this.coursetxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void addresstxt_Leave(object sender, EventArgs e)
        {
            if (addresstxt.Text == "")
            {
                addresstxt.Focus();

                confirmerror.SetError(this.addresstxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void aadhartxt_Leave(object sender, EventArgs e)
        {
            
            if (aadhartxt.Text == "")
            {
                aadhartxt.Focus();

                confirmerror.SetError(this.aadhartxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void gendertxt_Leave(object sender, EventArgs e)
        {
            if (gendertxt.Text == "")
            {
                gendertxt.Focus();

                confirmerror.SetError(this.gendertxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void percentage1txt_Leave(object sender, EventArgs e)
        {
            if (percentage1txt.Text == "")
            {
                percentage1txt.Focus();

                confirmerror.SetError(this.percentage1txt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void percentage2txt_Leave(object sender, EventArgs e)
        {
            if (percentage2txt.Text == "")
            {
                percentage2txt.Focus();

                confirmerror.SetError(this.percentage2txt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void citytxt_Leave(object sender, EventArgs e)
        {
            if (citytxt.Text == "")
            {
               citytxt.Focus();

                confirmerror.SetError(this.citytxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void fathernametxt_Leave(object sender, EventArgs e)
        {
            if (fathernametxt.Text == "")
            {
                fathernametxt.Focus();

                confirmerror.SetError(this.fathernametxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void mothertxt_Leave(object sender, EventArgs e)
        {
            if (mothertxt.Text == "")
            {
                mothertxt.Focus();

                confirmerror.SetError(this.mothertxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Focus();

                confirmerror.SetError(this.passtxt, "Mandetary to Fill");
            }
            else { confirmerror.Clear(); }
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = false;
            cancelbtn.Visible = false;
            prinbtn.Visible = false;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Visible = true;
            cancelbtn.Visible = true;
            prinbtn.Visible = true;

            richTextBox1.Text += "                 *************Student Ragistration*************\n";
            richTextBox1.Text += " Student Id :    " + idtxt.Text + "\n";
            richTextBox1.Text += " First Name :    " + firsttxt.Text + "\n";
            richTextBox1.Text += " Middle Name:    " + middletxt.Text + "\n";
            richTextBox1.Text += " Last Name  :    " + lasttxt.Text + "\n";
            richTextBox1.Text += " Email      :    " + emailtxt.Text + "\n";
            richTextBox1.Text += " Mobile Number:  " + firsttxt.Text + "\n";
            richTextBox1.Text += " Course  Name :  " + coursetxt.Text + "\n";
            richTextBox1.Text += " Gender     :    " + gendertxt.Text + "\n";
            richTextBox1.Text += " Address    :    " + addresstxt.Text + "\n";
            richTextBox1.Text += " Aadhar     :    " + aadhartxt.Text + "\n";
            richTextBox1.Text += " 12th Pecentage: " + percentage1txt.Text + "\n";
            richTextBox1.Text += " 10th Pecentage: " + percentage2txt.Text + "\n";
            richTextBox1.Text += " City       :    " + citytxt.Text + "\n";
            richTextBox1.Text += " Father Name:    " + fathernametxt.Text + "\n";
            richTextBox1.Text += " Mother Name:    " + mothertxt.Text + "\n";
            richTextBox1.Text += " Cast       :    " + casttxt.Text + "\n";
            richTextBox1.Text += " Password   :    " + passtxt.Text + "\n";
            richTextBox1.Text += " Date of Birth:  " + dateTimePicker1.Text + "\n\n\n\n";
            richTextBox1.Text += "                                                Signature             ";
           
        }

        private void student2_Load(object sender, EventArgs e)
        {

        }
    }
}
    
 
