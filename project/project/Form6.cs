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
    public partial class Form6 : Form
    {
        public string Pp_id { get; set; }
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x;
            if (txtTaskName.Text != "" && int.TryParse(txtTaskName.Text.ToString(), out x) != true&& txtTaskDescrption.Text != "" && int.TryParse(txtTaskDescrption.Text.ToString(), out x) !=true&& txtNameTeameMember.Text != "" && int.TryParse(txtNameTeameMember.Text.ToString(), out x) != true)
            {
                errorProvider1.SetError(btnAdd, "");

                SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[Task] values(@Tname,@TnameMemmber,@Tdesc,@Pp_id,0);", conn);
                cmd1.Parameters.AddWithValue("@Tname", txtTaskName.Text.ToString());
                cmd1.Parameters.AddWithValue("@Tdesc", txtTaskDescrption.Text.ToString());
                cmd1.Parameters.AddWithValue("@TnameMemmber", txtNameTeameMember.Text.ToString());
                cmd1.Parameters.AddWithValue("@Pp_id", Pp_id);
                conn.Open();
                int roww = cmd1.ExecuteNonQuery();
                conn.Close();
                if (roww > 0)
                {
                    DialogResult rsult = MessageBox.Show("insert ready", "insert", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (rsult == DialogResult.OK)
                    {
                        Form2 f2 = new Form2();
                       
                        f2.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("insert error");
                    txtTaskDescrption.Clear();
                    txtTaskName.Text = null;
                    txtNameTeameMember.Text = null;
                }


            }
            else
            {
                errorProvider1.SetError(btnAdd, "Enter all data and not null");
            }

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
