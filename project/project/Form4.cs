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
   
    public partial class Form4 : Form
    {
        public string p_Id { get; set; }
        public string p_Name { get; set; }
        public DateTime p_StartDAte { get; set; }
        public string p_logo { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");
        string sourcefilepath, destnionfilepath;
        string sourcefilename;
        DateTime currendate, Duration;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(p_Id);

                SqlCommand cmd3 = new SqlCommand("update  [dbo].[PRO] set pName = @pname, pDateStart =@pdatastart, pLogo =@plogo  where id = @id; ", conn);
                cmd3.Parameters.AddWithValue("@id", id);
                cmd3.Parameters.AddWithValue("@pname", txtName.Text);
                cmd3.Parameters.AddWithValue("@pdatastart", dateTimePicker.Value);
                cmd3.Parameters.AddWithValue("@plogo", destnionfilepath);



                conn.Open();
                int rowupdate = cmd3.ExecuteNonQuery();
                conn.Close();
                if (rowupdate > 0)
                {
                    MessageBox.Show("update is good");
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("update is not good");
                }

            }
            catch (Exception)
            {

               
            }
           
       }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtName.Text = p_Name;
            txtProjectId.Text =p_Id;
            pictureBox.Image = Image.FromFile(@p_logo);
            dateTimePicker.Value = DateTime.Parse(p_StartDAte.ToString());
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
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
    }
}
