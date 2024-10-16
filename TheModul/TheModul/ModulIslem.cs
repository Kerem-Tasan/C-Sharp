using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheModul.ModulDBDataSetTableAdapters;

namespace TheModul
{
    public partial class ModulIslem : Form
    {
        public ModulIslem()
        {
            InitializeComponent();
        }





        public Guid RowID;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                int rowSelected = e.RowIndex;

                if (e.RowIndex != -1)
                {
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[rowSelected].Selected = true;
                    var cellValue = dataGridView1.Rows[rowSelected].Cells["IDData"].Value;

                    if (cellValue != null && Guid.TryParse(cellValue.ToString(), out Guid id))
                    {
                        RowID = id;

                    }
                    else
                    {

                    }
                }

            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelPopUp mpp = new ModelPopUp();
            mpp.ID = Guid.Empty;
            mpp.ShowDialog();
            if (mpp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşleminiz başarıyla tamamlandı");
            }
        }

        private void ModulIslem_Load(object sender, EventArgs e)
        {
            this.modulTblTableAdapter.Fill(ds_modul.ModulTbl);
        }

        private void güncelelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelPopUp mpp = new ModelPopUp();
            mpp.ID =RowID;
            mpp.ShowDialog();
            if (mpp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşleminiz başarıyla tamamlandı");
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modulTblTableAdapter.Fill(ds_modul.ModulTbl);
        }
    }
}
