using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ok = false;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");
        private void CHKEmail()
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!reg.IsMatch(MTxtBEmailAddress.Text))
            {
                errorProvider1.SetError(MTxtBEmailAddress, "Email not valid");
                MTxtBEmailAddress.Clear();
                MTxtBEmailAddress.Focus();
                ok = false;
            }

            else
            {
                errorProvider1.SetError(MTxtBEmailAddress, "");
                ok = true;

            }
        }
        private void CHKPassword()
        {
            if (MTxtBPassword.Text.Length < 8)
            {
                errorProvider1.SetError(MTxtBPassword, "Password not valid Length < 8");
                MTxtBPassword.Clear();
                MTxtBPassword.Focus();
                ok = false;
            }
            else
            {
                errorProvider1.SetError(MTxtBPassword, "");
                ok = true;
            }
        }

        private void CHKBShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKBShowpassword.Checked)
            {
                MTxtBPassword.PasswordChar = '\0';
            }
            else
            {
                MTxtBPassword.PasswordChar = '*';
            }
        }
        private void CHKLogin_stats()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM [dbo].[user] WHERE EmailAddress='" + MTxtBEmailAddress.Text + "' AND Password='" + MTxtBPassword.Text + "'", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if(MTxtBEmailAddress.Text != ""&& MTxtBPassword.Text!="")
                MessageBox.Show("Hello " + dt.Rows[0][3].ToString());
                Form2 f2 = new Form2();

                f2.Pname = dt.Rows[0][3].ToString();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email Address or password");
                MTxtBPassword.Clear();
                MTxtBEmailAddress.Clear();

            }


        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(MTxtBEmailAddress.Text!=""||MTxtBPassword.Text!="")
            {
                errorProvider1.SetError(btnLogin, "");
                CHKEmail();
                CHKPassword();
                    if (ok == true)
                    {
                        CHKLogin_stats();
                        errorProvider1.SetError(btnLogin,"");
                    }
                    else
                    {
                        errorProvider1.SetError(btnLogin,"enter vaild data");
                    }
            }
            else
            {
                errorProvider1.SetError(btnLogin, "enter vaild data");
            }







        }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }

        }
    }

