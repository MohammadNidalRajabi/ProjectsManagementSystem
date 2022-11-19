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
using System.IO;

namespace project
{

   
public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C1Q9KA9;Initial Catalog=project;Integrated Security=True");
        int rowselecte;
        Form1 f1 = new Form1();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        public string Pname { get; set; }
        

       
        public Form2()
        {
            InitializeComponent();
        }
      
       

        private void Form2_Load(object sender, EventArgs e)
        {
            adminToolStripMenuItem.Text = Pname;
            SqlCommand cmd1 = new SqlCommand("select id,pName,pDateStart,DATEDIFF(DD,pDateStart,GETDATE()) as [duration] ,pLogo from [dbo].[PRO]", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            dt.Columns.Add("Project Logo",Type.GetType("System.Byte[]"));
            
            //show imag in data grid view 
            foreach(DataRow drow in dt.Rows)
            {
                drow["Project Logo"] = File.ReadAllBytes(drow["pLogo"].ToString());
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Project ID";
            dataGridView1.Columns[1].HeaderText = "Project Name";
            dataGridView1.Columns[2].HeaderText = "Project Start Date";
            dataGridView1.Columns[3].HeaderText = "Project Duration";
            dataGridView1.Columns[4].HeaderText = "Project Logo";




        }



        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            f1.Show();
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewProject_Click(object sender, EventArgs e)
        {
           
            f3.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                rowselecte = e.RowIndex;
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
            if (e.Button == MouseButtons.Left)
            {
                rowselecte = e.RowIndex;
                try
                {
                    
                    pictureBox1.Image = Image.FromFile(@dataGridView1.Rows[rowselecte].Cells[4].Value.ToString());
                }
                catch (Exception)
                {

                    MessageBox.Show("select row fill");
                }
                



            }
        }

        private void toolStripMenuItemDeleteProject_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(dataGridView1.Rows[rowselecte].Cells[0].Value.ToString(), out id);
            DialogResult result = MessageBox.Show("are you sure delete this row", "delete project", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                
                
                
                SqlCommand cmd2 = new SqlCommand("delete from [dbo].[PRO] where id=@id;", conn);
                cmd2.Parameters.AddWithValue("@id", id.ToString());
                conn.Open();
                int rowcount = cmd2.ExecuteNonQuery();
                conn.Close();
                if (rowcount > 0)
                {
                    MessageBox.Show("delete row good");


                    adminToolStripMenuItem.Text = Pname;
                    SqlCommand cmd1 = new SqlCommand("select id,pName,pDateStart,DATEDIFF(DD,pDateStart,GETDATE()) as [duration] ,pLogo from [dbo].[PRO]", conn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable ds = new DataTable();
                    da1.Fill(ds);
                    ds.Columns.Add("Project Logo", Type.GetType("System.Byte[]"));


                    foreach (DataRow drow in ds.Rows)
                    {
                        drow["Project Logo"] = File.ReadAllBytes(drow["pLogo"].ToString());
                    }
                    dataGridView1.DataSource = ds;
                    dataGridView1.Columns[0].HeaderText = "Project ID";
                    dataGridView1.Columns[1].HeaderText = "Project Name";
                    dataGridView1.Columns[2].HeaderText = "Project Start Date";
                    dataGridView1.Columns[3].HeaderText = "Project Duration";
                    dataGridView1.Columns[4].HeaderText = "Project Logo";


                }
                else
                {
                    MessageBox.Show("delete row not good");
                }
            }

            

        }

        private void toolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {
            
               
                
                f4.p_Id = dataGridView1.Rows[rowselecte].Cells[0].Value.ToString();
                f4.p_Name = dataGridView1.Rows[rowselecte].Cells[1].Value.ToString();
                f4.p_StartDAte = DateTime.Parse( dataGridView1.Rows[rowselecte].Cells[2].Value.ToString());
                f4.p_logo =@dataGridView1.Rows[rowselecte].Cells[4].Value.ToString();
                f4.ShowDialog();
                this.Hide();
                
            
                
           
            
            



        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.p_Id= dataGridView1.Rows[rowselecte].Cells[0].Value.ToString();
            f5.ShowDialog();
            this.Hide();
            
        }
    }
    
}

