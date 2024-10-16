using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheModul
{
    public partial class ModulIcerik : Form
    {
        public ModulIcerik()
        {
            InitializeComponent();
        }

        private void ModulIcerik_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'modulDBDataSet.Modul_Icerik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ModulIcerik.Fill(this.ds_modul.Modul_Icerik);


        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelIcerikPopUp mipp = new ModelIcerikPopUp();
            mipp.ID = Guid.Empty;
            mipp.ShowDialog();
        }


        public Guid RowID;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int rowSelected = e.RowIndex;

                    if (e.RowIndex != -1)
                    {
                        this.dataGridView1.ClearSelection();
                        this.dataGridView1.Rows[rowSelected].Selected = true;
                        var cellValue = dataGridView1.Rows[rowSelected].Cells["ıDData"].Value;

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
            catch (Exception)
            {

            }

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelIcerikPopUp mipp = new ModelIcerikPopUp();
            mipp.ID = RowID;
            mipp.ShowDialog();

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_ModulIcerik.Fill(this.ds_modul.Modul_Icerik);
        }
    }
}
