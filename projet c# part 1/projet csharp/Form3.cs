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
    public partial class Form3 : Form
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");

        public SqlDataReader Reader;


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.Show();
            Visible = false;

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Deconnecter();
                cnx.Open();
                SqlCommand cmd = new SqlCommand("delete EMPLOYEE where matricule=@matricule;",cnx);
                cmd.Parameters.AddWithValue("@matricule", int.Parse(textBoxForm3.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("effacé avec succés");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnx.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE", cnx);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                dataGridView1.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[4], Reader[5], Reader[6], Reader[7], Reader[8], Reader[9], Reader[10], Reader[11],Reader[12]);

            }
        }
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE", cnx);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {  if(Reader[2].ToString()==textBoxForm3.Text)
                dataGridView1.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[4], Reader[5], Reader[6], Reader[7], Reader[8], Reader[9], Reader[10], Reader[11], Reader[12]);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;

        }
    }
}
