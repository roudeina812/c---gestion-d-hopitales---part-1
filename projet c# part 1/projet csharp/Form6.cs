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
    public partial class Form6 : Form
    {
        public SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-ROUDEIN;Initial Catalog=orojet csharp;Integrated Security=True");
        public SqlDataReader Reader;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select fraisActe from BULLTIN where idCIN_EMP =" +int.Parse(textBox1.Text)+ " and YEAR(depotDate)= ' " + textBox2.Text  +" ' ; " , cnx);
            Reader=cmd.ExecuteReader();
            double sum=0 ;
            while (Reader.Read())
            {
                double a = Convert.ToDouble(Reader[0]) ;
                sum += a;
            }
            double rem =0;
            rem = sum * 0.3 ;

            MessageBox.Show("votre remboursement de l'année " + textBox2.Text + "=" + rem);
            cnx.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select fraisActe from BULLTIN where idCIN_EMP =" + int.Parse(textBox1.Text) + " and MONTH(depotDate)= ' " + textBox2.Text + " ' ; ", cnx);
            Reader = cmd.ExecuteReader();
            double sum = 0;
            while (Reader.Read())
            {
                double a = Convert.ToDouble(Reader[0]);
                sum += a;
            }
            double rem = 0;
            rem = sum * 0.3;

            MessageBox.Show("votre remboursement du mois " + textBox2.Text + "=" + rem);
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
