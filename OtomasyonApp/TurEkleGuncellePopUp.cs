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
    public partial class TurEkleGuncellePopUp : Form
    {

        public int TurEkleGuncelleID;
        public TurEkleGuncellePopUp()
        {
            InitializeComponent();
        }
        

        private void TurEkleGuncellePopUp_Load(object sender, EventArgs e)
        {
            InitData();
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //   this.hesapKartTuruTableAdapter.Fill(this.cardDBDataSet.HesapKartTuru);


            if (TurEkleGuncelleID == 0)
            {
                TurPopUpEkleguncelle_btn.Text = "Ekle";
                var row = cardDBDataSet.HesapKartTuru.NewHesapKartTuruRow();
                cardDBDataSet.HesapKartTuru.AddHesapKartTuruRow(row);
            }
            else
            {
                TurPopUpEkleguncelle_btn.Text = "Güncelle";
                hesapKartTuruTableAdapter.FillByID(cardDBDataSet.HesapKartTuru,TurEkleGuncelleID);
            }
        }
        void InitData()
        {
           cardDBDataSet.HesapKartTuru.TableNewRow += (o,e)=>
            {
                e.Row[cardDBDataSet.HesapKartTuru.TurAdıColumn]="";
                e.Row[cardDBDataSet.HesapKartTuru.IsDeletedColumn]=0;

            };

        }

        private void TurPopUpEkleguncelle_btn_Click(object sender, EventArgs e)
        {
            hesapKartTuruBindingSource.EndEdit();

            cardDBDataSet.EndInit();
            hesapKartTuruTableAdapter.Update(cardDBDataSet.HesapKartTuru);
            this.Close();
            this.DialogResult = DialogResult.OK;    

        }
    }
}
