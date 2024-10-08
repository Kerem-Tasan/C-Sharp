using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApplication
{
    public partial class Form1 : Form
    {
        GorevDS.KullaniciTblDataTable Kullanicidt = new GorevDS.KullaniciTblDataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            KullanicEkle_Guncelle kEkle = new KullanicEkle_Guncelle();
            kEkle.KID = Guid.Empty;
            kEkle.ShowDialog();
            if (kEkle.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Kaydetme İşlemi Tamamlandı");

            }
        }

        private void Giris_btn_Click(object sender, EventArgs e)
        {
            var x = kullaniciTblTableAdapter.FindUser(Kullanicidt, Giris_txt.Text, GirisSifre_txt.Text);
            if (x != 0)
            {
                var row = Kullanicidt.Rows[0];
               
              
               KullanıcıBilgileri.KullaniciYetki = Guid.Parse(row["KullaniciTipi"].ToString());
                KullanıcıBilgileri.KullaniciID = Guid.Parse(row["ID"].ToString());
                KullanıcıBilgileri.KullaniciAd = Convert.ToString(row["Ad"]);

                Anasayfa ana = new Anasayfa();
               // ana.id = Guid.Parse( kullanıcıBilgileri.KullaniciID);
                ana.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Girilen Kullanıcı Bulunamadı!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

