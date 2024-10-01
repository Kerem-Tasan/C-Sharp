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
    public partial class IstekTanimlari : Form
    {
        public int IstekKID;
        public IstekTanimlari()
        {
            InitializeComponent();
        }

        private void IstekTanimlari_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_LTS_MiniDataSet.IstekKategori' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istekKategoriTableAdapter.FillWithD(this._LTS_MiniDataSet.IstekKategori,false);

        }
        public void Doldur(bool IsDeleted)
        {
            this.istekKategoriTableAdapter.FillWithD(this._LTS_MiniDataSet.IstekKategori, IsDeleted);
        }

        private void Listele_btn_Click(object sender, EventArgs e)
        {
            Doldur(false);
        }

        private void SilinenleriListele_btn_Click(object sender, EventArgs e)
        {
            SilinmeNedeni.Visible = true;
            
            //IstekTanimları_Grid.Columns,
            
            Doldur(true);

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?","Silme Onayı",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                InputForm ınp=new InputForm();
                ınp.IsTester = 5;
                ınp.IstekID=IstekKID ;
                ınp.ShowDialog();
                if (ınp.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Silme İşlemi Tamamlandı.");
                    Doldur(false);
                }

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.IstekTanimları_Grid.ClearSelection();
                    this.IstekTanimları_Grid.Rows[rowSelected].Selected = true;
                    var cellValue = IstekTanimları_Grid.Rows[rowSelected].Cells["ıstekIDDataGridViewTextBoxColumn"].Value;
                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int istekId))
                    {
                        IstekKID = istekId;

                    }
                    else
                    {
                        // Handle the case where the value is null or not convertible to int
                        MessageBox.Show("Invalid IstekID value.");
                    }
                }


            }
        }

        private void Guncelle_btn_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Güncelleme İşlemine Devam etmek istiyor musunuz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                IstekKategorisiEkleGuncelle kategori=new IstekKategorisiEkleGuncelle();
                kategori.KategoriID=IstekKID;
                kategori.ShowDialog();
                if (kategori.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Güncelleme İşlemi Tamamlandı.");
                   Doldur(false);
                }
            }
        }

        private void IstekEkle_btn_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Güncelleme İşlemine Devam etmek istiyor musunuz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                IstekKategorisiEkleGuncelle kategori = new IstekKategorisiEkleGuncelle();
                kategori.KategoriID = 0;

                kategori.ShowDialog();
                if (kategori.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Ekleme İşlemi Tamamlandı.");
                    Doldur(false);
                }
            }
        }
    }
}
