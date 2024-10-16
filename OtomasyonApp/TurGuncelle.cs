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
    public partial class TurGuncelle : Form
    {
        public TurGuncelle()
        {
            InitializeComponent();
        }
      public int TurGuncelleId{  get; set; }    


        private void TurGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTuruTableAdapter.Fill(this.cardDBDataSet.HesapKartTuru, false);
           
            hesapKartTuruTableAdapter.SelectWithId(cardDBDataSet.HesapKartTuru, TurGuncelleId);
        }

        private void TurguncelleFormu_btn_Click(object sender, EventArgs e)
        {
            hesapKartTuruBindingSource.EndEdit();
            hesapKartTuruTableAdapter.Update(cardDBDataSet.HesapKartTuru);
            DialogResult dialogresult = MessageBox.Show("Tür Başarıyla Güncellendi!"+MessageBoxButtons.OK);
            if (dialogresult==DialogResult.OK){
                this.Close();
            }
            else
            {
                this.Refresh();
            }
        }
    }
}
