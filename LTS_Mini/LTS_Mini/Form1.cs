using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTS_Mini
{
    public partial class Form1 : Form
    {
        _LTS_MiniDataSetTableAdapters.KullaniciTableAdapter adapter = new _LTS_MiniDataSetTableAdapters.KullaniciTableAdapter();
        _LTS_MiniDataSet.KullaniciDataTable Kullanicidt = new _LTS_MiniDataSet.KullaniciDataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {// FillByLogin metodunun kaç satır döndürdüğünü kontrol ediyoruz
            int result = adapter.FillByLogin(Kullanicidt, LoginSifre_txt.Text, LoginUsername_txt.Text);
            if (result == 0) // Eğer kullanıcı adı veya şifre yanlışsa
            {
                DialogResult dialog = MessageBox.Show("Lütfen Bilgilerin Doğru Olduğunu Kontrol Edin", "Yanlış Kullanıcı Adı veya Şifre", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    LoginUsername_txt.Text = "";
                    LoginSifre_txt.Text = "";
                }
            }
            else
            {

                adapter.SelectUserWithLogin(Kullanicidt, LoginUsername_txt.Text, LoginSifre_txt.Text);
                var row = Kullanicidt.Rows[0];
                if (Convert.ToBoolean(row["SilindiMi"]) == true)
                {
                    // SilindiMi true ise yapılacak işlemler
                    DialogResult dialog = MessageBox.Show("Silinen Kullanıcı İle Giriş Yapamazsınız", "Silinen Kullanıcı", MessageBoxButtons.OK);
                    if (dialog == DialogResult.OK)
                    {
                        LoginUsername_txt.Text = "";
                        LoginSifre_txt.Text = "";
                    }

                }
                else
                {
                    YetkiBelirleme.ad = row["KullaniciAdi"].ToString();
                    YetkiBelirleme.YetkiID = Convert.ToInt32(row["KullaniciTipi"]);
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.UserType = YetkiBelirleme.YetkiID;

                    this.Hide();
                    anaSayfa.Show();

                }

;


            }
        }

        private void Kayit_lbl_Click(object sender, EventArgs e)
        {
            KullaniciEkle_Guncelle Kekle = new KullaniciEkle_Guncelle();
            Kekle.KullaniciID = 0;
            Kekle.ShowDialog();
            if (Kekle.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Kayıt Olma İşlemi Tamamlandı!");
            }
            else
            {
                MessageBox.Show("Kullanıcı Ekleme İşlemi İptal Edildi!");

            }
        }
    }
}
