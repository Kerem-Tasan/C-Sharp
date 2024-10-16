using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheModul
{
    public partial class ResimSayfasi : Form
    {
        public ResimSayfasi()
        {
            InitializeComponent();
        }


        private void ResimSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'modulDBDataSet.ResimTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            dataLoad();

        }
        public void dataLoad()
        {
            this.tbl_resim.Fill(this.ds_modul.ResimTbl);
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimPopUp pp = new ResimPopUp();
            pp.ID = Guid.Empty;
            pp.ShowDialog();
        }
        public Guid RowID;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int SelectedRow = e.RowIndex;
                RowID = Guid.Parse(dataGridView1.Rows[SelectedRow].Cells["ID"].Value.ToString());
            }
            catch (Exception)
            {
            }

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimPopUp pp = new ResimPopUp();
            pp.ID = RowID;
            pp.ShowDialog();
        }

        private void resimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resimler resimler = new Resimler();
            resimler.ID = RowID;
            resimler.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Silme İşlemini Onaylıyor Musunuz ? ", "Silme Onayı", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                //tbl_resim.Delete(RowID);
                dataLoad();
            }

        }
    }
}
