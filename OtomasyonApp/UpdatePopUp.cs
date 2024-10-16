using OtomasyonApp.CardDBDataSetTableAdapters;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtomasyonApp
{
    public partial class UpdatePopUp : Form
    {
        public int KartId { get; set; }
        public UpdatePopUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NU0IEU7\KEREMT;Initial Catalog=CardDB;Integrated Security=True");

        private void UpdatePopUp_Load(object sender, EventArgs e)
        {// TODO: Bu kod satırı 'cardDBDataSet.HesapAltGrupDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapAltGrupDbTableAdapter.FillBy(this.cardDBDataSet.HesapAltGrupDb, false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapGrupDBTableAdapter.Fill(this.cardDBDataSet.HesapGrupDB);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTuruTableAdapter.Fill(this.cardDBDataSet.HesapKartTuru,false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTipiTableAdapter.Fill(this.cardDBDataSet.HesapKartTipi, false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartıDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            comboBox4.Enabled = false;
            try
            {
                con.Open();

                // TC kimlikli kullanıcının verilerini sorgula ve göster
                string queryWho = "SELECT TC FROM HesapKartıDB WHERE KartId = @KartId";
                SqlCommand kmt = new SqlCommand(queryWho, con);
                kmt.Parameters.AddWithValue("@KartId", KartId);
                SqlDataReader readerOfWho = kmt.ExecuteReader();
                if (readerOfWho.Read())
                {
                    MessageBox.Show(readerOfWho["TC"].ToString() + " TC kimlikli kullanıcının verilerini güncelliyorsunuz!");
                }
                readerOfWho.Close();

                // Kullanıcının tüm bilgilerini çekmek için sorgu
                string queryData = "SELECT t1.Unvan, t1.VergiDairesi, t1.VergiDaireNo, t1.TC, t1.Adres, " +
                                   "t2.TipAdı AS KartTipi, t3.TurAdı AS KartTürü, t4.GrupAdı AS Grup, t5.AltGrupAdı AS AltGrup " +
                                   "FROM HesapKartıDB t1 " +
                                   "INNER JOIN HesapKartTipi t2 ON t1.TipId = t2.TipId " +
                                   "INNER JOIN HesapKartTuru t3 ON t1.TurId = t3.TurId " +
                                   "INNER JOIN HesapGrupDB t4 ON t1.GrupId = t4.GrupID " +
                                   "INNER JOIN HesapAltGrupDb t5 ON t1.AltGrupId = t5.AltGrupId " +
                                   "WHERE t1.KartId = @KartId";

                SqlCommand komut2 = new SqlCommand(queryData, con);
                komut2.Parameters.AddWithValue("@KartId", KartId);
                SqlDataReader reader = komut2.ExecuteReader();

                if (reader.Read())
                {
                    // TextBox'ları doldur
                    textBox1.Text = reader["Unvan"].ToString();
                    textBox2.Text = reader["VergiDairesi"].ToString();
                    textBox3.Text = reader["VergiDaireNo"].ToString();
                    textBox4.Text = reader["TC"].ToString();
                    textBox5.Text = reader["Adres"].ToString();

                    // ComboBox'lara verileri uygun şekilde atayın

                    comboBox1.SelectedItem = reader["KartTipi"].ToString().Trim();
                    comboBox2.SelectedItem = reader["KartTürü"].ToString().Trim();
                    comboBox3.SelectedItem = reader["Grup"].ToString().Trim();
                    comboBox4.SelectedItem = reader["AltGrup"].ToString().Trim();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string sqlUpdateQuery = "UPDATE HesapKartıDB SET Unvan = @Unvan, VergiDairesi = @VergiDairesi, VergiDaireNo = @VergiDaireNo, TC = @TC, Adres = @Adres, TipId = @TipId, TurId = @TurId, GrupId = @GrupId, AltGrupId = @AltGrupId WHERE KartId = @KartId";

            try
            {
                SqlCommand commandForUpdate = new SqlCommand(sqlUpdateQuery, con);
                commandForUpdate.Parameters.AddWithValue("@Unvan", textBox1.Text);
                commandForUpdate.Parameters.AddWithValue("@VergiDairesi", textBox2.Text);
                commandForUpdate.Parameters.AddWithValue("@VergiDaireNo", textBox3.Text);
                commandForUpdate.Parameters.AddWithValue("@TC", textBox4.Text);
                commandForUpdate.Parameters.AddWithValue("@Adres", textBox5.Text);

                // ComboBox'lardan ID'leri çekme
                commandForUpdate.Parameters.AddWithValue("@TipId", comboBox1.SelectedValue);  // TipId ComboBox'tan
                commandForUpdate.Parameters.AddWithValue("@TurId", comboBox2.SelectedValue);  // TurId ComboBox'tan
                commandForUpdate.Parameters.AddWithValue("@GrupId", comboBox3.SelectedValue); // GrupId ComboBox'tan
                commandForUpdate.Parameters.AddWithValue("@AltGrupId", comboBox4.SelectedValue); // AltGrupId ComboBox'tan
                commandForUpdate.Parameters.AddWithValue("@KartId", KartId); // Güncellenen kayıt için KartId

                commandForUpdate.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hesapKartTipiTableAdapter.FillBy(this.cardDBDataSet.HesapKartTipi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gerekli işlem
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hesapKartTuruTableAdapter.FillBy(this.cardDBDataSet.HesapKartTuru);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            var selectedRow = ((System.Windows.Forms.ComboBox)sender).SelectedItem as System.Data.DataRowView;

            if (selectedRow != null)
            {
                // DataRowView'in içindeki değeri almak için doğru sütunu belirtin
                int grupID = Convert.ToInt32(selectedRow["GrupID"]); // veya AltGrupId

                // hesapAltGrupDbTableAdapter ile sorguyu çalıştırın
                hesapAltGrupDbTableAdapter.AltgrupIdSecme(cardDBDataSet.HesapAltGrupDb, grupID);
            }
        }
    }
}
