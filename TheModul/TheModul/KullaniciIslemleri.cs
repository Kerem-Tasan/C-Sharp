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

namespace TheModul
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {            
            InitData();
            // TODO: Bu kod satırı 'modulDBDataSet.KullaniciTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            if (string.IsNullOrEmpty(KullaniciBilgileri.Kad))
            {
                btn_Ekle.Text = "Ekle";
                var row = ds_modul.KullaniciTbl.NewKullaniciTblRow();
                row.ID = Guid.NewGuid();
                ds_modul.KullaniciTbl.AddKullaniciTblRow(row);
            }
            else
            {
                btn_Ekle.Text = "Güncelle";
                this.Kullanici_TA.Fill(this.ds_modul.KullaniciTbl);

            }
        }
        void InitData()
        {
            ds_modul.KullaniciTbl.TableNewRow += (o, e) =>
            {
                e.Row[ds_modul.KullaniciTbl.AdColumn] = "";
                e.Row[ds_modul.KullaniciTbl.KAdColumn] = "";
                e.Row[ds_modul.KullaniciTbl.SifreColumn] = "";
                e.Row[ds_modul.KullaniciTbl.KayitTarihiColumn] = DateTime.Now;
            };

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            var kontrol = Kullanici_TA.GetDataBykad(txt_kad.Text);
            if (kontrol.Rows.Count == 1 && string.IsNullOrEmpty(KullaniciBilgileri.Kad))
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı Değiştirin");
                txt_kad.Text = "";

            }
            else
            {
                try
                {
                    ds_modul.EndInit();
                    bs_Kullanici.EndEdit();
                    Kullanici_TA.Update(ds_modul.KullaniciTbl);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("İşlem Başarısız oldu!");
                    throw;
                }

            }

        }
    }
}
