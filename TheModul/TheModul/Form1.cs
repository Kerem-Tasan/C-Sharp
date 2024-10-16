using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheModul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 4000; // 2 saniye
            timer1.Tick += timer1_Tick; // Timer'ın Tick olayına abone ol
        }
        //GorevDS.KullaniciTblDataTable Kullanicidt = new GorevDS.KullaniciTblDataTable();
        ModulDBDataSet.KullaniciTblDataTable KDT = new ModulDBDataSet.KullaniciTblDataTable();

        private void txt_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_kad.Text))
            {
                // Hata mesajı ayarlama
                errorProvider1.SetError(txt_kad, "Bu alan boş bırakılamaz.");
                timer1.Start(); // Timer'ı başlat
                                // e.Cancel = true; // Geçersiz giriş olduğunda odak kaybını önler
            }
            if (string.IsNullOrEmpty(txt_sifre.Text))
            {
                // Hata mesajını temizleme
                errorProvider1.SetError(txt_sifre, "Bu alan boş bırakılamz");
                timer1.Start();

            }
            else
            {

                var x = Kullanici_TA.FillControlLogin(KDT, txt_kad.Text, txt_sifre.Text);

                if (x != 0)
                {
                    var row = KDT.Rows[0];
                    KullaniciBilgileri.Kad = row["Ad"].ToString();

                    Anasayfa a = new Anasayfa();
                    a.Show();
                    this.Hide();

                }
                else
                {
                    errorProvider1.SetError(txt_sifre, "Girilen bilgiler Herhangi bir bilgi ile uyuşmuyor");
                    timer1.Start();
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Hata mesajını temizle
            errorProvider1.SetError(txt_kad, string.Empty);
            timer1.Stop(); // Timer'ı durdur
        }

        private void label1_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri KIslem=new KullaniciIslemleri();
            KIslem.ShowDialog();
            if(KIslem.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Kullanıcı Başarıyla Kaydedildi");
            } 
        }
    }
}
