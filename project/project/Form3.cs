using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace project
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");
        string sourcefilepath, destnionfilepath;
        string sourcefilename;
        DateTime currendate, Duration;


        public Form3()
        {
            InitializeComponent();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProjectName_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if(txtProjectName.Text=="")
            {
                errorProvider1.SetError(txtProjectName,"Enter vaild Name");
                txtProjectName.Focus();
                ok = false;
            }
            else if(pictureBox.Image == null)
            {
                errorProvider1.SetError(pictureBox, "Select image");
                btnAdd.Focus();
                ok = false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if(ok==true)
            {
                SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[PRO] values(@pname,convert(varchar, getdate(), 101),@logo)", conn);
                cmd1.Parameters.AddWithValue("@pname",txtProjectName.Text);
                //cmd1.Parameters.AddWithValue("@daartdate", DateTime.Parse(dateTimePicker1.Value.ToString()));
                cmd1.Parameters.AddWithValue("@logo",destnionfilepath.ToString());
                conn.Open();
                int roww=cmd1.ExecuteNonQuery();
                conn.Close();
                if (roww > 0)
                {
                    DialogResult rsult= MessageBox.Show("insert ready","insert",MessageBoxButtons.OK,MessageBoxIcon.None);
                    if(rsult==DialogResult.OK)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("insert error");
                    txtProjectName.Clear();
                    pictureBox.Image = null;
                }
                

            }
           
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                
                InitialDirectory = @"D:\",
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...",
            FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
                
            };
           
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcefilename = openFileDialog1.SafeFileName;
                sourcefilepath = openFileDialog1.FileName;
                destnionfilepath = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\pic\\" + sourcefilename;
                System.IO.File.Copy(sourcefilepath, destnionfilepath, true);
                pictureBox.Image = Image.FromFile(destnionfilepath);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            currendate = DateTime.Today;
            txtDuration.Text = ((currendate - dateTimePicker1.Value).Days/365).ToString();



        }
    }
}
