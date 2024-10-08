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
    public partial class KullanicEkle_Guncelle : Form
    {
        public Guid KID=OnayVerileri.KullaniciGridID;
        public bool IsGuncelle=false;
        public KullanicEkle_Guncelle()
        {
            InitializeComponent();
        }

        private void KullanicEkle_Guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorevDS.KullaniciTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          
            // TODO: Bu kod satırı 'gorevDS2.KullaniciTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'gorevDS1.GorevTipiTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'gorevDS.KullaniciTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            InitData();

     
      
            if ((KID == Guid.Empty || KullanıcıBilgileri.KullaniciYetki==Guid.Empty) && IsGuncelle==false)
            {
                this.dtKullaniciTipi.Fill(this.gorevDS.KullaniciTipi);
                kayit_btn.Text = "Ekle"; 
                var row = gorevDS.KullaniciTbl.NewKullaniciTblRow();
                row.ID = Guid.NewGuid();

               gorevDS.KullaniciTbl.AddKullaniciTblRow(row);  
                if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
                {
                    cmbTip.Visible = true;
                    lbl_Tip.Visible = true;
                }
              
            }
            else if (KID !=Guid.Empty && KID ==OnayVerileri.KullaniciGridID && IsGuncelle==true)
            {
                kayit_btn.Text = "Güncelle";
                this.dtKullanici.FillAll(this.gorevDS.KullaniciTbl,KID);
                cmbTip.Visible = false;
                lbl_Tip.Visible=false;  
           
            }
           
        }

        void InitData()
        {
            gorevDS.KullaniciTbl.TableNewRow += (o, e) =>
            {
                e.Row[gorevDS.KullaniciTbl.AdColumn] = "";
                e.Row[gorevDS.KullaniciTbl.KullaniciAdiColumn] = "";
                e.Row[gorevDS.KullaniciTbl.SifreColumn] = "";

                e.Row[gorevDS.KullaniciTbl.KullaniciTipiColumn] = "28b02d63-6855-41b8-a750-11b4fe016e20";
                e.Row[gorevDS.KullaniciTbl.KayitTarihiColumn] = DateTime.Now;
                e.Row[gorevDS.KullaniciTbl.SilindiMiColumn] = false;
                e.Row[gorevDS.KullaniciTbl.SilmeNedeniColumn] = "";


            };
        }

        private void kayit_btn_Click(object sender, EventArgs e)
        {
            var kontrol = dtKullanici.GetDataKullanici(K_ad_txt.Text);
           
            if(  kontrol.Rows.Count == 1 || string.IsNullOrEmpty( KullanıcıBilgileri.KullaniciAd) || KullanıcıBilgileri.KullaniciAd.Equals(kontrol.Rows[0]["KullaniciAdi"].ToString()))
            {
                try
                {
                    gorevDS.EndInit();
                    bsKullanici.EndEdit();
                    dtKullanici.Update(gorevDS.KullaniciTbl);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("İşlem Başarısız oldu!");
                    throw;
                }

            }
            else 
            {
                MessageBox.Show("Sayın " + Ad_txt.Text + ". \n\nLütfen Kullanıcı Adını Değiştirin");
                K_ad_txt.Text = "";
                Sifre_txt.Text = "";
            }
           
            





        }
    }
}
