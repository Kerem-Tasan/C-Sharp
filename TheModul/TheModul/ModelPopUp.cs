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

    public partial class ModelPopUp : Form
    {

        public Guid ID;
        public ModelPopUp()
        {
            InitializeComponent();
        }

        private void ModelPopUp_Load(object sender, EventArgs e)
        {

            // TODO: Bu kod satırı 'modulDBDataSet.ModulTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            InitData();
            if (ID == Guid.Empty)
            {
                var row=ds_modul.ModulTbl.NewModulTblRow();
                row.ID = Guid.NewGuid();
                ds_modul.ModulTbl.AddModulTblRow(row);
                btn_mpp.Text = "EKLE";
            }
            else if (ID != Guid.Empty)
            {

                this.tbl_modul.FillBy(this.ds_modul.ModulTbl,ID);

                btn_mpp.Text = "Güncelle";
            }
        }
        void InitData()
        {
            ds_modul.ModulTbl.TableNewRow += (o, e) =>
            {

                e.Row[ds_modul.ModulTbl.AdiColumn] = "";
                e.Row[ds_modul.ModulTbl.KayitTarihiColumn] = DateTime.Now;

            };

        }

        private void btn_mpp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_mpp.Text))
                {


                    bs_modul.EndEdit();
                    ds_modul.EndInit();

                    modulTblTableAdapter1.Update(ds_modul.ModulTbl);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(txt_mpp, "Boş bırakılamaz alan");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
