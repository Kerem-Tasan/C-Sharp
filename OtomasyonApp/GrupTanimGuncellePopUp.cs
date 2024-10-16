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
    public partial class GrupTanimGuncellePopUp : Form
    {
        public int GrupId {  get; set; }
        public GrupTanimGuncellePopUp()
        {
            InitializeComponent();
        }

        private void GrupTanimGuncellePopUp_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet1.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapGrupDBTableAdapter.FillById(this.cardDBDataSet.HesapGrupDB, GrupId);



        }

        private void GrupTanimGuncelle_btn_Click(object sender, EventArgs e)
        {
           




        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            hesapGrupDBBindingSource.EndEdit();
            hesapGrupDBTableAdapter.Update(cardDBDataSet.HesapGrupDB);
            MessageBox.Show("Grup Güncellendi!");
            this.Close();


        }
    }
}
