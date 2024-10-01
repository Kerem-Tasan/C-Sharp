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
    public partial class KullaniciEkle_Guncelle : Form
    {
        public int KullaniciID;
        public KullaniciEkle_Guncelle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_LTS_MiniDataSet.KullaniciTip' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciTipTableAdapter.Fill(this._LTS_MiniDataSet.KullaniciTip);
            InıtData();
            if (KullaniciID == 0)
            {
                KullaniciGrud_btn.Text = "Ekle";
                var row=_LTS_MiniDataSet.Kullanici.NewKullaniciRow();
                _LTS_MiniDataSet.Kullanici.AddKullaniciRow(row);

            }else if (KullaniciID >= 0)
            {
                KullaniciGrud_btn.Text = "Güncelle";
                kullaniciTableAdapter.FillByID(_LTS_MiniDataSet.Kullanici,KullaniciID);
            }
            

        }
        void InıtData()
        {


            _LTS_MiniDataSet.Kullanici.TableNewRow += (o, e) =>
            {
                e.Row[_LTS_MiniDataSet.Kullanici.KullaniciAdiColumn] = "";
                e.Row[_LTS_MiniDataSet.Kullanici.SifreColumn] = "";
                e.Row[_LTS_MiniDataSet.Kullanici.AdSoyadColumn] = "";
                e.Row[_LTS_MiniDataSet.Kullanici.SilindiMiColumn] = false;
                e.Row[_LTS_MiniDataSet.Kullanici.SilmeNedeniColumn] = "Silinmedi";
                e.Row[_LTS_MiniDataSet.Kullanici.KullaniciTipiColumn] = 1;
                e.Row[_LTS_MiniDataSet.Kullanici.KayitTarihiColumn] = DateTime.Now;

            };
         }

        private void KullaniciGrud_btn_Click(object sender, EventArgs e)
        {
            kullaniciBindingSource.EndEdit();
            _LTS_MiniDataSet.EndInit();
            kullaniciTableAdapter.Update(_LTS_MiniDataSet.Kullanici);
            
            this.DialogResult= DialogResult.OK;    
            this.Close();
        }
    }
}
