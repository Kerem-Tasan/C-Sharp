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
    public partial class TipUpdate : Form
    {
        public int UpdateID { get; set; }
        public TipUpdate()
        {
            InitializeComponent();
        }

        private void TipUpdate_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTipiTableAdapter.Fill(this.cardDBDataSet.HesapKartTipi, false);

            hesapKartTipiTableAdapter.SelectTypyeWithID(cardDBDataSet.HesapKartTipi,UpdateID);

        }

        private void Tip_guncelle_btn_Click(object sender, EventArgs e)
        {
            hesapKartTipiBindingSource.EndEdit();
            hesapKartTipiTableAdapter.Update(cardDBDataSet.HesapKartTipi); 
            this.Close();
        }
    }
}
