using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApplication
{
    public partial class GorevPopUp : Form
    {

        public Guid GorevIDPopup;
        public Guid PopUpYetki;
        public Guid id;



        public GorevPopUp()
        {
            InitializeComponent();
        }

        private void GrupPopUp_Load(object sender, EventArgs e)
        {
            Guid a = KullanıcıBilgileri.KullaniciYetki;
            LogData();
            InitData();
            // TODO: Bu kod satırı 'gorevDS.GorevTipiTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevTipiTblTableAdapter.Fill(this.gorevDS.GorevTipiTbl);
            // TODO: Bu kod satırı 'gorevDS.GorevLogTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevLogTblTableAdapter.Fill(this.gorevDS.GorevLogTbl);

            var x = kullaniciTblTableAdapter.GetDataBy1(false);
            var y = kullaniciTblTableAdapter.GetAllByID(KullanıcıBilgileri.KullaniciAd);




            // TODO: Bu kod satırı 'gorevDS.GorevTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.gorevTblTableAdapter.Fill(this.gorevDS.GorevTbl);
            // TODO: Bu kod satırı 'gorevDS.KullaniciTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciTblTableAdapter.Fill(this.gorevDS.KullaniciTbl, false);
            // 
            Console.WriteLine(KullanıcıBilgileri.KullaniciAd);

            if (GorevIDPopup == Guid.Empty)
            {
                ekle_btn.Text = "Ekle";

                if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
                {
                    foreach (DataRow row in x.Rows)
                    {
                        // Her satırın KullaniciAdi sütunundaki değeri alıp CheckedListBox'a ekliyoruz.
                        checkedListBox1.Items.Add(row["Ad"].ToString());

                    }

                }
                else if (KullanıcıBilgileri.KullaniciYetki != Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
                {
                    checkedListBox1.Items.Add(KullanıcıBilgileri.KullaniciAd.ToString());
                }


                    var z = kullaniciTblTableAdapter.GetAllByID(KullanıcıBilgileri.RowID.ToString());

                if (z.Rows.Count > 0)
                {
                    string ad = z.Rows[0]["Ad"].ToString();
                    checkedListBox1.Items.Add($"{ad}\n{ad}");
                }


            }
            else
            {

                ekle_btn.Text = "Güncelle";
                // TODO: Bu kod satırı 'gorevDS.GorevTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.gorevTblTableAdapter.FillByID(this.gorevDS.GorevTbl, GorevIDPopup);
                // TODO: Bu kod satırı 'gorevDS.KullaniciTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.kullaniciTblTableAdapter.Fill(this.gorevDS.KullaniciTbl, false);
            }
        }
        void LogData()
        {

            gorevDS.GorevLogTbl.TableNewRow += (o, e) =>
            {
                e.Row[gorevDS.GorevLogTbl.KullaniciOnayliMiColumn] = false;
                e.Row[gorevDS.GorevLogTbl.KullaniciOnayAciklamasiColumn] = "";
                e.Row[gorevDS.GorevLogTbl.YoneticiOnayliMiColumn] = false;
                e.Row[gorevDS.GorevLogTbl.YoneticiOnayAciklamaColumn] = "";

                e.Row[gorevDS.GorevLogTbl.GorevIDColumn] = Guid.Empty;

            };

        }
        void InitData()
        {
            gorevDS.GorevTbl.TableNewRow += (o, e) =>
            {

                e.Row[gorevDS.GorevTbl.KullaniciIDColumn] = Guid.Empty;
                e.Row[gorevDS.GorevTbl.GörevTipiColumn] = Guid.Parse("63bfa77a-d483-4e40-93de-348d38ae28ac");
                e.Row[gorevDS.GorevTbl.AciklamaColumn] = "";
                e.Row[gorevDS.GorevTbl.TamamlandiMiColumn] = false;
                e.Row[gorevDS.GorevTbl.KayitTarihiColumn] = DateTime.Now;
                e.Row[gorevDS.GorevTbl.BaslangicTarihiColumn] = DBNull.Value;
                e.Row[gorevDS.GorevTbl.BitisTarihiColumn] = DBNull.Value;
                e.Row[gorevDS.GorevTbl.IsDeletedColumn] = 0;
                e.Row[gorevDS.GorevTbl.SilinmeNedeniColumn] = DBNull.Value;
            };
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            var checkedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems.Add(item.ToString());

            }
            if (ekle_btn.Text.Equals("Ekle"))
            {
                foreach (var kullaniciAd in checkedItems)
                {

                    var row = gorevDS.GorevTbl.NewGorevTblRow();
                    row.Ad = kullaniciAd;
                    row.ID = Guid.NewGuid();
                    row.IsDeleted = false;
                    var LogRow = gorevDS.GorevLogTbl.NewGorevLogTblRow();
                    LogRow.GorevID = row.ID;

                    var kullanici = kullaniciTblTableAdapter.GetDataByAd(kullaniciAd,false);
                    if (kullanici != null && kullanici.Rows.Count > 0)
                        row.KullaniciID = kullanici.FirstOrDefault().ID;
                    row.Aciklama = txt_Aciklama.Text;
                    row.BaslangicTarihi = BaslangicTarihi_dtp.Value;
                    row.BitisTarihi = Bitis_dtp.Value;

                    LogRow.ID = Guid.NewGuid();



                    gorevDS.GorevTbl.AddGorevTblRow(row);
                    gorevDS.GorevLogTbl.AddGorevLogTblRow(LogRow);
                    //gorevTblTableAdapter.UpdateForKID(row.ID, kullaniciAd);


                }
            }

            // Şimdi checkedItems listesini kullanarak işlem yapabilirsiniz.

            try
            {

                gorevLogTblBindingSource.EndEdit();
                gorevTblBindingSource.EndEdit();
                gorevDS.EndInit();
                gorevTblTableAdapter.Update(gorevDS.GorevTbl);
                gorevLogTblTableAdapter.Update(gorevDS.GorevLogTbl);
                MessageBox.Show("İşleminiz Kaydedildi!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
