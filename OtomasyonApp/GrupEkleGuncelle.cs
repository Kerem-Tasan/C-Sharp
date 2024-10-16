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
    public partial class GrupEkleGuncelle : Form
    {
        public int GrupEkleGuncelleId;
        public GrupEkleGuncelle()
        {
            InitializeComponent();
        }

        private void GrupEkleGuncelle_Load(object sender, EventArgs e)
        {

            InitData();
            // TODO: Bu kod satırı 'cardDBDataSet.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //    this.hesapGrupDBTableAdapter.Fill(this.cardDBDataSet.HesapGrupDB);
            if (GrupEkleGuncelleId == 0)
            {
                GrupEkleGuncelle_btn.Text = "Ekle";
                var row = cardDBDataSet.HesapGrupDB.NewHesapGrupDBRow();
                cardDBDataSet.HesapGrupDB.AddHesapGrupDBRow(row);

            }
            else
            {
                GrupEkleGuncelle_btn.Text = "Güncelle";
                hesapGrupDBTableAdapter.FillById(cardDBDataSet.HesapGrupDB, GrupEkleGuncelleId);


            }

        }
        void InitData()
        {
            cardDBDataSet.HesapGrupDB.TableNewRow += (o, e) =>
            {
                e.Row[cardDBDataSet.HesapGrupDB.GrupAdıColumn] = "";
                e.Row[cardDBDataSet.HesapGrupDB.IsdeletedColumn] = 0;

            };
        }

        private void GrupEkleGuncelle_btn_Click(object sender, EventArgs e)
        {
            hesapGrupDBBindingSource.EndEdit();
            cardDBDataSet.EndInit();

            hesapGrupDBTableAdapter.Update(cardDBDataSet.HesapGrupDB);
            
            MessageBox.Show("Kişi Kaydedildi"); 
            
            
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }
    }
}
