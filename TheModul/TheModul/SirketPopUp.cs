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

    public partial class SirketPopUp : Form
    {
        public Guid ID;
        public SirketPopUp()
        {
            InitializeComponent();
        }

        private void SirketPopUp_Load(object sender, EventArgs e)
        {
            InitData();
            // TODO: Bu kod satırı 'modulDBDataSet.SirketTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            if (ID != Guid.Empty)
            {
                this.tbl_Sirket.FillByID(this.ds_Modul.SirketTbl,ID);
                btn_Sirket.Text = "Güncelle"; 
         
            }
            else if(ID==Guid.Empty)
            {
                btn_Sirket.Text = "Ekle";
                var row = ds_Modul.SirketTbl.NewSirketTblRow();
                row.ID = Guid.NewGuid();
                ds_Modul.SirketTbl.AddSirketTblRow(row);
            }


        }
        void InitData()
        {
            ds_Modul.SirketTbl.TableNewRow += (o, e) => {
                e.Row[ds_Modul.SirketTbl.AdColumn] = "";
                e.Row[ds_Modul.SirketTbl.KayitTarihiColumn]=DateTime.Now;
                e.Row[ds_Modul.SirketTbl.KIDColumn] = Guid.Parse("a2302c12-de4b-42fa-a025-4b98cccd4aac");
                e.Row[ds_Modul.SirketTbl.DurumColumn] = false;
                e.Row[ds_Modul.SirketTbl.IsDeletedColumn] = false;

            };
        }

        private void btn_Sirket_Click(object sender, EventArgs e)
        {
            ds_Modul.EndInit();
            bs_Sirket.EndEdit();

            tbl_Sirket.Update(ds_Modul.SirketTbl);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
