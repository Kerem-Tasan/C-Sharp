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
    public partial class CardAddUpdate : Form
    {
        public int cardID;

        public CardAddUpdate()
        {
            InitializeComponent();
        }

        private void CardAddUpdate_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.Sehirler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sehirlerTableAdapter.Fill(this.cardDBDataSet.Sehirler);

            //// TODO: Bu kod satırı 'cardDBDataSet.HesapAltGrupDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hesapAltGrupDbTableAdapter.FillBy(this.cardDBDataSet.HesapAltGrupDb);
            //// TODO: Bu kod satırı 'cardDBDataSet.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapGrupDBTableAdapter.Fill(this.cardDBDataSet.HesapGrupDB);
            //// TODO: Bu kod satırı 'cardDBDataSet.HesapKartTuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTuruTableAdapter.Fill(this.cardDBDataSet.HesapKartTuru, false);
            //// TODO: Bu kod satırı 'cardDBDataSet.HesapKartTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTipiTableAdapter.Fill(this.cardDBDataSet.HesapKartTipi, false);
    
            InitData();
            if (cardID <= 0)
            {
                button1.Text = "Ekle";
                var row = cardDBDataSet.HesapKartıDB.NewHesapKartıDBRow();
                cardDBDataSet.HesapKartıDB.AddHesapKartıDBRow(row);

            }
            else
            {
         
                button1.Text = "Güncelle";
                hesapKartıDBTableAdapter.FillBy2(cardDBDataSet.HesapKartıDB, cardID);

            }
        }
        void InitData()
        {
            cardDBDataSet.HesapKartıDB.TableNewRow += (o, e) =>
            {

                e.Row[cardDBDataSet.HesapKartıDB.UnvanColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.VergiDairesiColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.VergiDaireNoColumn] = 0;
                e.Row[cardDBDataSet.HesapKartıDB.TCColumn] = 0;
                e.Row[cardDBDataSet.HesapKartıDB.AdresColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.TipAdıColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.TurAdıColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.GrupAdıColumn] = "";
                e.Row[cardDBDataSet.HesapKartıDB.AltGrupAdıColumn] = "";

            //    e.Row{ cardDBDataSet.HesapKartıDB}
         //       e.Row[cardDBDataSet.HesapKartıDB.reasonColumn] = "";

                e.Row[cardDBDataSet.HesapKartıDB.IsDeletedColumn]= 0;


            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapKartıDBBindingSource.EndEdit();
            cardDBDataSet.EndInit();
            hesapKartıDBTableAdapter.Update(cardDBDataSet.HesapKartıDB);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hesapAltGrupDbTableAdapter.FillByGrupID(cardDBDataSet.HesapAltGrupDb,Convert.ToInt32(comboBox3.SelectedValue));
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void fillAltGrupComboBoxToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.hesapKartıDBTableAdapter.(this.cardDBDataSet.HesapKartıDB, new System.Nullable<int>(((int)(System.Convert.ChangeType(grupIdToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
