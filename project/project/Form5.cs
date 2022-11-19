using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace project
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");
        int rowselecte;
        public string p_Id { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select *  from [dbo].[Task] where Pid=@Tid", conn);
            cmd1.Parameters.AddWithValue("@Tid", p_Id);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da1.Fill(ds, "Project");

            dataGridView1.DataSource = ds.Tables[0];
            //////////////////////////////////
            SqlCommand cmd2 = new SqlCommand("select COUNT(*)  FROM [dbo].[Task] where Pid=@Tid;", conn);
            cmd2.Parameters.AddWithValue("@Tid", p_Id);
            SqlDataReader dr;
            conn.Open();
            dr = cmd2.ExecuteReader();
            dr.Read();
            
            labelNumberAllTask.Text = dr[0].ToString();
            conn.Close();
            ///////////////////////////////
            SqlCommand cmd3 = new SqlCommand("select COUNT(*)  FROM [dbo].[Task] where Pid=@Tid and Tcompleate=0;", conn);
            cmd3.Parameters.AddWithValue("@Tid", p_Id);
            SqlDataReader dr3;
            conn.Open();
            dr3 = cmd3.ExecuteReader();
            dr3.Read();

            labelNumberAllTaskUncompleted.Text = dr3[0].ToString();
            conn.Close();
            ///////////////////////////////////////
            SqlCommand cmd4 = new SqlCommand("select COUNT(*)  FROM [dbo].[Task] where Pid=@Tid and Tcompleate=1;", conn);
            cmd4.Parameters.AddWithValue("@Tid", p_Id);
            SqlDataReader dr4;
            conn.Open();
            dr4 = cmd4.ExecuteReader();
            dr4.Read();

            labelNumberAllTaskCompleted.Text = dr4[0].ToString();
            conn.Close();














        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Pp_id = p_Id;
            f6.Show();
            this.Hide();
        }

        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Tid = 0;
            int.TryParse(dataGridView1.Rows[rowselecte].Cells[0].Value.ToString(), out Tid);
            DialogResult result = MessageBox.Show("are you sure delete this row", "delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {



                SqlCommand cmd2 = new SqlCommand("delete from [dbo].[Task] where Tid=@Tid;", conn);
                cmd2.Parameters.AddWithValue("@Tid", Tid);
                conn.Open();
                int rowcount = cmd2.ExecuteNonQuery();
                conn.Close();
                
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
                else
                {
                    MessageBox.Show("delete row not good");
                }
            
            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowselecte = e.RowIndex;
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void taskCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Tid = 0;
            int.TryParse(dataGridView1.Rows[rowselecte].Cells[0].Value.ToString(), out Tid);
            DialogResult result = MessageBox.Show("are you sure update this row", "update task", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {



                SqlCommand cmd2 = new SqlCommand("update [dbo].[Task] set Tcompleate=1 where Tid=@Tid;", conn);
                cmd2.Parameters.AddWithValue("@Tid", Tid);
                conn.Open();
                int rowcount = cmd2.ExecuteNonQuery();
                conn.Close();

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("update row not good");
            }

        }
    }
}
