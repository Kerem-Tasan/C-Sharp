using LTS_Mini._LTS_MiniDataSetTableAdapters;
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
    public partial class IstekKategorisiEkleGuncelle : Form
    {
        public int KategoriID;
        public IstekKategorisiEkleGuncelle()
        {
            InitializeComponent();
        }

        private void IstekKategorisiEkleGuncelle_Load(object sender, EventArgs e)
        {
            InıtData();
           if (KategoriID == 0)
            {

                button1.Text = "Ekle";
              var row=  _LTS_MiniDataSet.IstekKategori.NewIstekKategoriRow();
                _LTS_MiniDataSet.IstekKategori.AddIstekKategoriRow(row);
                    
            }
            else if (KategoriID > 0)
            {
                button1.Text = "Güncelle";
                istekKategoriTableAdapter.FillWithID(_LTS_MiniDataSet.IstekKategori,KategoriID);
            }
        }
        void InıtData()
        {
            _LTS_MiniDataSet.IstekKategori.TableNewRow += (o, e) =>
            {
                e.Row[_LTS_MiniDataSet.IstekKategori.IstekAdıColumn] = "";
                e.Row[_LTS_MiniDataSet.IstekKategori.IsDeletedColumn] = false;
                e.Row[_LTS_MiniDataSet.IstekKategori.SilinmeNedeniColumn] = "Silinmedi";

            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ıstekKategoriBindingSource.EndEdit();
            _LTS_MiniDataSet.EndInit();
            istekKategoriTableAdapter.Update(_LTS_MiniDataSet.IstekKategori);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

