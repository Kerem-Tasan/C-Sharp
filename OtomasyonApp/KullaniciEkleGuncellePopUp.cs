using OtomasyonApp.CardDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonApp
{
    public partial class KullaniciEkleGuncellePopUp : Form
    {

        public int KullaniciRowID;
        public KullaniciEkleGuncellePopUp()
        {
            InitializeComponent();
        }

        private void KullaniciEkleGuncellePopUp_Load(object sender, EventArgs e)
        {
            InitData();
            // TODO: Bu kod satırı 'dataset.KullanıcıDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.kullanıcıDbTableAdapter.FillSelectPersonel(this.dataset.KullanıcıDb);
            if (KullaniciRowID <= 0)
            {
                kullaniciform_btn.Text = "Ekle";
                var row = dataset.KullanıcıDb.NewKullanıcıDbRow();
                dataset.KullanıcıDb.AddKullanıcıDbRow(row);
               
            }
            else
            {
                kullaniciform_btn.Text = "Güncelle";
                kullanıcıDbTableAdapter.FillBy2(dataset.KullanıcıDb,KullaniciRowID);
         
            }
        }
        
        void InitData()
        {
            dataset.KullanıcıDb.TableNewRow += (o, e) =>
            {
               
                e.Row[dataset.KullanıcıDb.AdColumn] = "";
                e.Row[dataset.KullanıcıDb.SoyadColumn] = "";
                e.Row[dataset.KullanıcıDb.KullanıcıAdıColumn] = "";
                e.Row[dataset.KullanıcıDb.EmailColumn] = "";
                e.Row[dataset.KullanıcıDb.TelefonNoColumn] = 0;
                e.Row[dataset.KullanıcıDb.IsDeletedColumn] = false;
                e.Row[dataset.KullanıcıDb.SifreColumn] = "";

            };
          
        }

        private void kullaniciform_btn_Click(object sender, EventArgs e)
        {
            kullanıcıDbBindingSource.EndEdit();
            dataset.EndInit();
            kullanıcıDbTableAdapter.Update(dataset.KullanıcıDb);
            this.DialogResult=DialogResult.OK;
            this.Close();
        }
    }
}
