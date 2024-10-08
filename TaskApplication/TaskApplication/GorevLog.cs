using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApplication
{
    public partial class GorevLog : Form
    {
        public GorevLog()
        {
            InitializeComponent();
        }

        private void GorevLog_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorevDS.GorevLogTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("28b02d63-6855-41b8-a750-11b4fe016e20") || KullanıcıBilgileri.KullaniciYetki == Guid.Parse("383b04e6-9253-4ab1-9743-3165e56e4919") || KullanıcıBilgileri.KullaniciYetki == Guid.Parse("0a2bd29a-8c4c-4b55-99d8-8274b0f8e422"))
            {
                this.gorevLogTblTableAdapter.FillKID(gorevDS.GorevLogTbl, KullanıcıBilgileri.KullaniciID);

            }

            else if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
            {
              this.gorevLogTblTableAdapter.Fill(this.gorevDS.GorevLogTbl);


            }
         
        }

        private void GorevLogGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < GorevLogGrid.RowCount - 1; i++)
            {

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToBoolean(GorevLogGrid.Rows[i].Cells[4].Value) == true)
                {
                    renk.ForeColor = Color.BlueViolet;
                    renk.BackColor = Color.Yellow;

                }
                else if(Convert.ToBoolean(GorevLogGrid.Rows[i].Cells[2].Value) == true)
                {
                    renk.BackColor = Color.Aqua;
                    renk.ForeColor = Color.DarkBlue;
                }
                else
                {

                    renk.BackColor = Color.Turquoise;
                    renk.ForeColor = Color.OrangeRed;
                }
                GorevLogGrid.Rows[i].DefaultCellStyle = renk; // Satırın stilini ayarlama

            }
        }
    }
}
