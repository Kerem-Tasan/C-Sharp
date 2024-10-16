using OtomasyonApp.CardDBDataSetTableAdapters;
using OtomasyonApp.datasetTableAdapters;
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
    public partial class SehirEkleGuncelle : Form
    {

        public int SehirID;
        public SehirEkleGuncelle()
        {
            InitializeComponent();
        }

        private void SehirEkleGuncelle_Load(object sender, EventArgs e)
        {
            InitData();
            if (SehirID<= 0)
            {
                Sehir_btn.Text = "Ekle";
                var row = cardDBDataSet.Sehirler.NewSehirlerRow();
                cardDBDataSet.Sehirler.AddSehirlerRow(row);

            }
            else
            {
                Sehir_btn.Text = "Güncelle";
                sehirlerTableAdapter.FillBy(cardDBDataSet.Sehirler,SehirID);

            }

        }
     void InitData()
        {

          cardDBDataSet.Sehirler.TableNewRow += (o, e) =>
            {

                e.Row[cardDBDataSet.Sehirler.SehirAdColumn] = "";
                e.Row[cardDBDataSet.Sehirler.IsDeletedColumn  ] = 0;
               
            };



        }

        private void Sehir_btn_Click(object sender, EventArgs e)
        {
            sehirlerBindingSource.EndEdit();
            cardDBDataSet.EndInit();
            sehirlerTableAdapter.Update(cardDBDataSet.Sehirler);
            MessageBox.Show("Veri Kaydedildi !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
