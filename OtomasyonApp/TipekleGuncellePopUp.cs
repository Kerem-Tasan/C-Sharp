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
    public partial class TipekleGuncellePopUp : Form
    {
        public int TipekleGuncelleID{get; set; } 
        public TipekleGuncellePopUp()
        {
            InitializeComponent();
        }
 //public int TipEkleId {  get; set; }
        private void TipeklePopUp_Load(object sender, EventArgs e)
        {
            InitData();
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         // this.hesapKartTipiTableAdapter.Fill(this.cardDBDataSet.HesapKartTipi);
            if (TipekleGuncelleID==0)
            {
                TipPopUpEkle_btn.Text = "Ekle";
                var row = cardDBDataSet.HesapKartTipi.NewHesapKartTipiRow();
                cardDBDataSet.HesapKartTipi.AddHesapKartTipiRow(row);
            }
            else
            {
                TipPopUpEkle_btn.Text = "Güncelle";
                hesapKartTipiTableAdapter.FillByTipID(cardDBDataSet.HesapKartTipi, TipekleGuncelleID);
            }

        }
        void InitData()
        {
            cardDBDataSet.HesapKartTipi.TableNewRow += (o, e) =>
            {
                e.Row[cardDBDataSet.HesapKartTipi.TipAdıColumn] = "";
                e.Row[cardDBDataSet.HesapKartTipi.IsDeletedColumn] =0;
            };
            
            }
        private void TipPopUpEkle_btn_Click(object sender, EventArgs e)
        {

            hesapKartTipiBindingSource.EndEdit();

            cardDBDataSet.EndInit();
            hesapKartTipiTableAdapter.Update(cardDBDataSet.HesapKartTipi);
            this.Close();
            this.DialogResult = DialogResult.OK;
            //hesapKartTipiTableAdapter.TipInsert(tipadekle_txt.Text);
            //MessageBox.Show("Kart Tipi Başarıyla Eklendi!");
        }
    }
}
