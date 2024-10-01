using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LTS_Mini._LTS_MiniDataSet;

namespace LTS_Mini
{
    public partial class YeniIstek : Form
    {
        public int IstekID;

        public YeniIstek()
        {
            InitializeComponent();
        }

        private void YeniIstek_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_LTS_MiniDataSet.FirmaTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmaTblTableAdapter.Fill(this._LTS_MiniDataSet.FirmaTbl);
         //   InitData();
            // TODO: Bu kod satırı '_LTS_MiniDataSet.TesterAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.testerAdTableAdapter.Fill(this._LTS_MiniDataSet.TesterAd);
            // TODO: Bu kod satırı '_LTS_MiniDataSet.YazilimciAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.yazilimciAdTableAdapter.Fill(this._LTS_MiniDataSet.YazilimciAd);
            // TODO: Bu kod satırı '_LTS_MiniDataSet.IstekKategori' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istekKategoriTableAdapter.Fill(this._LTS_MiniDataSet.IstekKategori);
            if (YetkiBelirleme.YetkiID == 1)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                YeniIstek_btn.Location = new Point(-8, 258);
                KullaniciMesaj_txt.Enabled = true;
                FirmaAdi_cmb.Enabled = true;
                konu_txt.Enabled = true;
                IstekKategori_txt.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else if (YetkiBelirleme.YetkiID == 2)
            {
              
            }
            else if (YetkiBelirleme.YetkiID == 3)
            {
                TesterMesajı_txt.Enabled = true;    
            }
            else if (YetkiBelirleme.YetkiID == 4)
            {
                dateTimePicker2.Enabled=true;
                yazilimci_cmb.Enabled = true;
                Tester_cmb.Enabled = true;
            }
            // TODO: Bu kod satırı '_LTS_MiniDataSet.FirmaTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //    this.firmaTblTableAdapter.Fill(this._LTS_MiniDataSet.FirmaTbl);
        //    this.istekKategoriTableAdapter.FillWithD(this._LTS_MiniDataSet.IstekKategori);

            // TODO: Bu kod satırı '_LTS_MiniDataSet.TesterAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.testerAdTableAdapter.Fill(this._LTS_MiniDataSet.TesterAd);
            // TODO: Bu kod satırı '_LTS_MiniDataSet.YazilimciAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazilimciAdTableAdapter.Fill(this._LTS_MiniDataSet.YazilimciAd);
            // TODO: Bu kod satırı '_LTS_MiniDataSet1.IstekTbl1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        //    this.istekTbl1TableAdapter.FillBy(this._LTS_MiniDataSet.IstekTbl1, false);
            // İstekKategori ve IstekTbl tablolarını doldur
            //this.istekKategoriTableAdapter.Fill(this._LTS_MiniDataSet.IstekKategori);
            //this.istekTbl1TableAdapter.Fill(this._LTS_MiniDataSet.IstekTbl1);
             InitData();

            IstekID = YetkiBelirleme.IslemID;
            YetkiBelirleme.IslemID = 0;
            if (IstekID <= 0)
            {
                YeniIstek_btn.Text = "Ekle";
                var row = _LTS_MiniDataSet.IstekTbl1.NewIstekTbl1Row();
                _LTS_MiniDataSet.IstekTbl1.AddIstekTbl1Row(row);
            }
            else if (IstekID > 0)
            {
                YeniIstek_btn.Text = "Güncelle";
                istekTbl1TableAdapter.FillByEveryContact(_LTS_MiniDataSet.IstekTbl1, IstekID);

            }
           
        }

        void InitData()
        {


            _LTS_MiniDataSet.IstekTbl1.TableNewRow += (o, e) =>
            {

                e.Row[_LTS_MiniDataSet.IstekTbl1.KonuColumn] = "";
                e.Row[_LTS_MiniDataSet.IstekTbl1.IstekGonderenKisiColumn] = DBNull.Value;
                // e.Row[_LTS_MiniDataSet.IstekTbl1.IstekIDColumn] = DBNull.Value;
                e.Row[_LTS_MiniDataSet.IstekTbl1.IstekKategorisiColumn] = 1;
                e.Row[_LTS_MiniDataSet.IstekTbl1.IstekAciklamasiColumn] = "";
                e.Row[_LTS_MiniDataSet.IstekTbl1.KayitTarihiColumn] = DateTime.Now;
                //DateTime tomorrow = DateTime.Now.AddDays(1);


                e.Row[_LTS_MiniDataSet.IstekTbl1.YazilimciDurumColumn] = 1;
                e.Row[_LTS_MiniDataSet.IstekTbl1.YazilimciColumn] = 4;
                e.Row[_LTS_MiniDataSet.IstekTbl1.YazilimciAciklamaColumn] = "";

                e.Row[_LTS_MiniDataSet.IstekTbl1.TesterDurumColumn] = 1;
                e.Row[_LTS_MiniDataSet.IstekTbl1.TesterColumn] = 4;
                e.Row[_LTS_MiniDataSet.IstekTbl1.TesterAciklamaColumn] = "";


                e.Row[_LTS_MiniDataSet.IstekTbl1.YoneticiAciklamaColumn] = "";

                e.Row[_LTS_MiniDataSet.IstekTbl1.TamamlandiMiColumn] = false;
                e.Row[_LTS_MiniDataSet.IstekTbl1.FirmaAdiColumn] = "";

                e.Row[_LTS_MiniDataSet.IstekTbl1.SilindiMiColumn]=false;
             //   e.Row[_LTS_MiniDataSet.IstekTbl1.TahminiBitisTarihiColumn] = null ;





            };
        }

        private void YeniIstek_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ıstekTbl1BindingSource.EndEdit();
                _LTS_MiniDataSet.EndInit();
                istekTbl1TableAdapter.Update(_LTS_MiniDataSet.IstekTbl1);

                MessageBox.Show("Bilgiler Kaydedildi!");
            }
            catch (Exception)
            {

                throw;
            }


            //  kullanıcıDbTableAdapter.Update(dataset.KullanıcıDb);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}


