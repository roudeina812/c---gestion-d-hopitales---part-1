using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace projet_csharp
{
    public partial class Form1 : Form
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader Reader;

        public Form1()
        {
            InitializeComponent();
        }
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Visible = false;

        }
    }
}
