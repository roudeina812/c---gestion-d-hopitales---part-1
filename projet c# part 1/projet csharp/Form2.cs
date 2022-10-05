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
    public partial class Form2 : Form
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");
        public SqlDataReader Reader;

        
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
           


              cnx.Open();
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")
                || (textBox5.Text == "")  || (textBox7.Text == "") || (textBox8.Text == "")
                || (textBox9.Text == "") || (textBox10.Text == "") || (textBox11.Text == "") || (textBox12.Text == ""))
            { MessageBox.Show("il faut saisir toute vos coordonnées");
                
            }
             else
            {
                try
                {
                    cmd.CommandText = "INSERT INTO EMPLOYEE  VALUES (@nom , @prenom , @matricule , @cin , @dateNais ,@adresse ,@grade , @numTel , @codeCNAM , @etatCivil , @nomConjoint , @prenomConjoint , @nbEnfant ) ;";
                    cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                    cmd.Parameters.AddWithValue("@prenom", textBox3.Text);
                    cmd.Parameters.AddWithValue("@matricule", int.Parse(textBox13.Text));
                    cmd.Parameters.AddWithValue("@cin", int.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@dateNais",dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@adresse", textBox5.Text);
                    cmd.Parameters.AddWithValue("@grade", int.Parse(textBox4.Text));
                    cmd.Parameters.AddWithValue("@numTel", int.Parse(textBox12.Text));
                    cmd.Parameters.AddWithValue("@codeCNAM", int.Parse(textBox11.Text));
                    cmd.Parameters.AddWithValue("@etatCivil", textBox10.Text);
                    cmd.Parameters.AddWithValue("@nomConjoint", textBox9.Text);
                    cmd.Parameters.AddWithValue("@prenomConjoint", textBox8.Text);
                    cmd.Parameters.AddWithValue("@nbEnfant", int.Parse(textBox7.Text));
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("employéé ajouté avec succés");

            }
            cnx.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
