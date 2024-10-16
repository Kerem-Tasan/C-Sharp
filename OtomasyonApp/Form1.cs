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
namespace OtomasyonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NU0IEU7\KEREMT;Initial Catalog=CardDB;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;

            try
            {
                con.Open();

                string q1 = "Select KullanıcıAdı, Sifre from KullanıcıDb where KullanıcıAdı=@ad and Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(q1, con);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader d1 = cmd.ExecuteReader();

                if (d1.Read()) // Eğer kullanıcı bulunursa
                {
                    Anasayfa anasayfa = new Anasayfa();
                    this.Hide();
                    anasayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
