using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTS_Mini
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_LTS_MiniDataSet.Kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            GridLoad(false);

        }
        void GridLoad(bool IsDeleted)
        {
            this.kullaniciTableAdapter.FillWithD(_LTS_MiniDataSet.Kullanici, IsDeleted);
        }
        private void KullaniciEkle_btn_Click(object sender, EventArgs e)
        {
            KullaniciEkle_Guncelle Kekle = new KullaniciEkle_Guncelle();
            //Ardından güncelleme yapılırsa tekrar seçmek gereksin 
            SelectedColID = 0;
            Kekle.KullaniciID = SelectedColID;
            Kekle.ShowDialog();
            if (Kekle.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Tamamlandı!");
                GridLoad(false);
            }
        }

        private void KullaniciUndeleted_btn_Click(object sender, EventArgs e)
        {
            GridLoad(false);

        }

        private void KullaniciDeleted_btn_Click(object sender, EventArgs e)
        {
            GridLoad(true);
        }

        private void KullaniciSil_btn_Click(object sender, EventArgs e)
        {
            InputForm ınputForm = new InputForm();
            ınputForm.IsTester = 4;
            ınputForm.IstekID=SelectedColID;
            ınputForm.ShowDialog();

            if (ınputForm.DialogResult == DialogResult.OK)
            { 
                MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                    GridLoad(false);
            }
            else
            {
                MessageBox.Show("Silme İşlemi Tamamlanmadı !");
            }

          

        }
        public int SelectedColID;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.KullaniciGrid.ClearSelection();
                    this.KullaniciGrid.Rows[rowSelected].Selected = true;
                    var cellValue = KullaniciGrid.Rows[rowSelected].Cells["KullaniciID"].Value;
                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int istekId))
                    {
                        SelectedColID = istekId;
                        
                    }
                    else
                    {
                        // Handle the case where the value is null or not convertible to int
                        MessageBox.Show("Invalid IstekID value.");
                    }
                }


            }
        }

        private void KullaniciGuncelleme_Btn_Click(object sender, EventArgs e)
        {
            KullaniciEkle_Guncelle Kekle = new KullaniciEkle_Guncelle();
            Kekle.KullaniciID = SelectedColID;
            Kekle.ShowDialog();
            if (Kekle.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Tamamlandı!");
                GridLoad(false);
            }

        }
    }
}
