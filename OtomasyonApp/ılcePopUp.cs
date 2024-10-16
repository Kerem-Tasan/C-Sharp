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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtomasyonApp
{
    
    public partial class ılcePopUp : Form
    
    {
        public int IlceID;
        
        public ılcePopUp()
        {
            InitializeComponent();
        }

        private void ılcePopUp_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.Sehirler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sehirlerTableAdapter.Fill(this.cardDBDataSet.Sehirler);
            // TODO: Bu kod satırı 'cardDBDataSet.ILCEDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.iLCEDBTableAdapter.Fill(this.cardDBDataSet.ILCEDB,false);
            InıtData();
            if (IlceID == 0)
            {
                ilceekle_btn.Text = "Ekle";
                var row=cardDBDataSet.ILCEDB.NewILCEDBRow();
                cardDBDataSet.ILCEDB.AddILCEDBRow(row);
                panel1.Visible = true;

            }
            else
            {
                ilceekle_btn.Text = "Güncelle";
                iLCEDBTableAdapter.FillBy(cardDBDataSet.ILCEDB, IlceID);
                panel1.Visible = false;
            }


        }
        void InıtData()
        {
            cardDBDataSet.HesapAltGrupDb.TableNewRow += (o, e) =>
            {
                e.Row[cardDBDataSet.ILCEDB.IlceAdıColumn] = "";
                e.Row[cardDBDataSet.ILCEDB.SehirIDColumn] = 0;
                e.Row[cardDBDataSet.ILCEDB.IsDeletedColumn] = false;

            };
        }

        private void ilceekle_txt_Click(object sender, EventArgs e)
        {
            ıLCEDBBindingSource.EndEdit();
            cardDBDataSet.EndInit();
            if (IlceID == 0)
            {
                // SehirID'nin ComboBox'tan alındığından emin olalım
                cardDBDataSet.ILCEDB.First().SehirID = Convert.ToInt32(Sehir_cmb.SelectedValue);

                // IsDeleted değerini açık bir şekilde false olarak atayın
                cardDBDataSet.ILCEDB.First().IsDeleted = false;
            }
            iLCEDBTableAdapter.Update(cardDBDataSet.ILCEDB);
            MessageBox.Show("Kayıt başarıyla tamamlandı.!");
            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
