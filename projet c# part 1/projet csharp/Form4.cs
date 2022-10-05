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
namespace projet_csharp
{
    public partial class Form4 : Form
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");
       
        public SqlDataReader Reader;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load (Object sender ,EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
             SqlCommand cmd = new SqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM BULLTIN ";
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                dataGridView1.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[4]);

            }
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
             SqlCommand cmd = new SqlCommand("SELECT * FROM BULLTIN where idCIN_EMP = " + int.Parse(textBox1.Text) + ";",cnx);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                dataGridView1.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[4]);

            }
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;

        }
    }
}
