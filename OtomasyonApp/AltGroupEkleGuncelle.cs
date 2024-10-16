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
    public partial class AltGroupEkleGuncelle : Form
    {
        public int AltgrupID;
        public AltGroupEkleGuncelle()
        {
            InitializeComponent();
        }

        private void AltGroupEkleGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapGrupDBTableAdapter.FillBy2(this.cardDBDataSet.HesapGrupDB, false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapAltGrupDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hesapAltGrupDbTableAdapter.Fill(this.cardDBDataSet.HesapAltGrupDb);
            InitData();
            if(AltgrupID == 0)
            {
                AltgrupGrud_btn.Text = "Ekle";
                var row = cardDBDataSet.HesapAltGrupDb.NewHesapAltGrupDbRow();
                cardDBDataSet.HesapAltGrupDb.AddHesapAltGrupDbRow(row);
                panel1.Visible = true;
              


            }
            else
            {
                AltgrupGrud_btn.Text = "Güncelle";
                hesapAltGrupDbTableAdapter.FillBy1GrupAdTextBox(cardDBDataSet.HesapAltGrupDb, AltgrupID);
            //    hesapGrupDBTableAdapter.FillById(cardDBDataSet.HesapGrupDB, GrupEkleGuncelleId);

                panel1.Visible = false;
            }


            

        }
        void InitData()
        {
            cardDBDataSet.HesapAltGrupDb.TableNewRow += (o, e) =>
            {
                e.Row[cardDBDataSet.HesapAltGrupDb.AltGrupAdıColumn] = "";
                e.Row[cardDBDataSet.HesapAltGrupDb.GrupIdColumn] = 0;

            };

        }


        private void AltgrupGrud_btn_Click(object sender, EventArgs e)
        {
           
            hesapAltGrupDbBindingSource.EndEdit();
            cardDBDataSet.EndInit();
            if(AltgrupID == 0)
                cardDBDataSet.HesapAltGrupDb.First().GrupId = Convert.ToInt32(comboBox2.SelectedValue);
            hesapAltGrupDbTableAdapter.Update(cardDBDataSet.HesapAltGrupDb);
            MessageBox.Show("Alt Grup Başarıyla Kaydedildi Eklendi!");
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }

    }
}
