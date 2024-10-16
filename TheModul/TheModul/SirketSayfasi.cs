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
    public partial class SirketSayfasi : Form
    {
        public SirketSayfasi()
        {
            InitializeComponent();
        }
        void DataLoad(bool IsDeleted)
        {
            this.tbl_Sirket.FillUnDeleted(this.ds_Modul.SirketTbl, IsDeleted);
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SirketPopUp s_Pp = new SirketPopUp();
            s_Pp.ID = Guid.Empty;
            s_Pp.ShowDialog();
            if (s_Pp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Tamamlandı !");
                DataLoad(false);

            }
        }

        private void SirketSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ds_Modul.SirketTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            DataLoad(false);

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SirketPopUp s_Pp = new SirketPopUp();
            s_Pp.ID = RowID;

            s_Pp.ShowDialog();
            if (s_Pp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Tamamlandı !");
                DataLoad(false);

            }
        }
        public Guid RowID;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                RowID = Guid.Parse(dataGridView1.Rows[selectedRow].Cells["IDCol"].Value.ToString());

            }
            catch (Exception)
            {

            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Silme İşlemini Onaylıyor musunuz?", "Silme Onay", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                tbl_Sirket.UpdateIsDeleted(true, RowID);
                DataLoad(false);

            }

        }

        private void durumAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KilavuzLog kLog = new KilavuzLog();
            kLog.IsWhat = 2;
            kLog.IsVisible = 1;
            kLog.SirketID = RowID;
            kLog.ShowDialog();
            if (kLog.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İŞLEM tAMAMLANDI");
                DataLoad(false);
            }
            else if (kLog.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem Başarısız oldu !");
            }
        }
    }
}
