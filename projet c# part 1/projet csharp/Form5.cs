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
    public partial class Form5 : Form
    {
        Form3 f3;
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");
        public SqlDataReader Reader;
        
        public Form5(Form3 frm3)
        {
            InitializeComponent();
            this.f3 = frm3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM EMPLOYEE", cnx);
                Reader = cmd1.ExecuteReader();
                while (Reader.Read())
                {
                    if (Reader[2].ToString() == textBox13.Text)
                    {
                        textBox1.Text = Reader[0].ToString();
                        textBox3.Text = Reader[1].ToString();
                        textBox2.Text = Reader[3].ToString();
                        textBox5.Text = Reader[5].ToString();
                        textBox4.Text = Reader[6].ToString();
                        textBox12.Text= Reader[7].ToString();
                        textBox11.Text = Reader[8].ToString();
                        textBox10.Text = Reader[9].ToString();
                        textBox9.Text = Reader[10].ToString();
                        textBox8.Text = Reader[11].ToString();
                        textBox7.Text = Reader[12].ToString();
                    }

                }
                int matricul = int.Parse(textBox13.Text);
                SqlCommand cmd = new SqlCommand("Update EMPLOYEE set nom=@nom ,prenom=@prenom, cin=@cin , dateNais=@dateNais ,adresse=@adresse ,grade=@grade , numTel=@numTel , codeCNAM=@codeCNAM , etatCivil=@etatCivil , nomConjoint=@nomConjoint , prenomConjoint=@prenomConjoint , nbEnfant=@nbEnfant where matricule="+matricul+";", cnx);
                
                cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                cmd.Parameters.AddWithValue("@prenom", textBox3.Text);
                cmd.Parameters.AddWithValue("@cin", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@dateNais", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@adresse", textBox5.Text);
                cmd.Parameters.AddWithValue("@grade", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@numTel", int.Parse(textBox12.Text));
                cmd.Parameters.AddWithValue("@codeCNAM", int.Parse(textBox11.Text));
                cmd.Parameters.AddWithValue("@etatCivil", textBox10.Text);
                cmd.Parameters.AddWithValue("@nomConjoint", textBox9.Text);
                cmd.Parameters.AddWithValue("@prenomConjoint", textBox8.Text);
                cmd.Parameters.AddWithValue("@nbEnfant", int.Parse(textBox7.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("employéé modifié avec succés");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox13.Text = f3.textBoxForm3.Text;
        }
    }
}
