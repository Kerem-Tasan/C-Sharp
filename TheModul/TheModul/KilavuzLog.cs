using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheModul
{
    public partial class KilavuzLog : Form
    {
        public int IsWhat;
        public Guid SirketID;
        public int IsVisible;
        public KilavuzLog()
        {
            InitializeComponent();
        }
        private void KilavuzLog_Load(object sender, EventArgs e)
        {
            yenileToolStripMenuItem.Visible = (IsVisible == 0) ? false : true;

            if (IsWhat == 1)
            {
                this.tbl_Log.Fill(this.ds_modul.KilavuzLogTbl);
            }
            // TODO: Bu kod satırı 'modulDBDataSet.KilavuzLogTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            else if (IsWhat == 2)
            {
                dataGridView1.Columns["OnayData"].ReadOnly = false;
                this.tbl_Log.FillBySirketID(this.ds_modul.KilavuzLogTbl, SirketID);
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) == true)
                {
                    renk.ForeColor = Color.BlueViolet;
                    renk.BackColor = Color.Yellow;

                }
                else if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString()) == false)
                {
                    renk.BackColor = Color.Aqua;
                    renk.ForeColor = Color.DarkBlue;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk; // Satırın stilini ayarlama
            }
        }

        //Onayla Butonu eski Adı yenile 
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {


            bool IsContineu = true;
            bool isDone = false;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                // item, her bir DataGridViewRow nesnesini temsil eder.
                // Örneğin, bir hücreye erişmek için:
                if (item.Cells["IDData"].Value == null) continue;
                if (IsContineu)
                {
                    if (Convert.ToBoolean(item.Cells["OnayData"].Value))
                    {
                        // Tüm datalar onaylıysa false olmayacağı için else if e girmediği sürece contrienu devam edecek ama 1 tane bile false varsa bir daha true olmayacak 
                        isDone = true;


                    }
                    else if (!Convert.ToBoolean(item.Cells["OnayData"].Value))
                    {
                        IsContineu = false;
                        isDone = false;
                        break;

                    }
                }
            }


            if (isDone)
            {
                foreach (DataGridViewRow item1 in dataGridView1.Rows)
                {
                    if (item1.Cells["IDData"].Value == null) continue;
                    Guid ROWgID = Guid.Parse(item1.Cells["IDData"].Value.ToString());
                    tbl_sirket.UpdateDurum(true, SirketID);
                    Guid ROWsID = Guid.Parse(item1.Cells["SirketData"].Value.ToString());
                    tbl_Kilavuz.UpdateOnay(true, ROWgID);
                    tbl_Log.UpdateOnays(true, ROWsID);


                }
                MessageBox.Show("İşlem Tamamlandı");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else if (!isDone)
            {
                MessageBox.Show("İşlem Tamamlanmadı! Onaylı olmayan Şirketler var!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            }



        }
    }
}