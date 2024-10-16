using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TheModul
{
    public partial class Kilavuz : Form
    {
        public Kilavuz()
        {
            InitializeComponent();
        }
        private void Kilavuz_Load(object sender, EventArgs e)
        {

            this.KilavuzTA.Fill(this.ds_Modul.KilavuzTbl);

            int rowCount = Sirket_TA.Fill(ds_Modul.SirketTbl);

            // Eğer satır sayısı 0'dan büyükse, verileri kontrol et ve ekle
            if (rowCount > 0)
            {// Öncelikle SelectedSirketTbl'yi çekin, içinde SirketID ve IsSelected olan satırları almak için
                DataTable selectedSirketTbl = Tbl_SelectedSirket.GetData(); // Tüm verileri alırsınız.

                // SirketTbl'den verileri çekin ve CheckedListBox'a ekleyin
                foreach (DataRow row in ds_Modul.SirketTbl.Rows)
                {
                    // SirketTbl'den ID'yi alın
                    var sirketId = (Guid)row["ID"];  // Guid türündeki ID

                    // SelectedSirketTbl'deki bu SirketID'ye sahip satırı bulun
                    DataRow[] selectedRows = selectedSirketTbl.Select($"SirketID = '{sirketId}' AND IsSelected = true");

                    // Eğer bu SirketID IsSelected true ise, checked olarak ekleyin
                    bool isChecked = selectedRows.Length > 0; // Eğer satır bulunduysa, checked olacak

                    // CheckedListBox'a öğeyi ekleyin, isChecked true olanları checked yapar
                    checkedListBox1.Items.Add(row["Ad"].ToString(), isChecked);
                }
            }
        }
        public bool IsListVisible = false;
        private void SirketMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsListVisible)
            {
                IsListVisible = true;
                checkedListBox1.Location = new Point(12, 28);
                checkedListBox1.Size = new Size(120, 89);
                checkedListBox1.Dock = DockStyle.None;
                checkedListBox1.BringToFront();
            }
            else if (IsListVisible)
            {
                IsListVisible = false;
            }
            checkedListBox1.Visible = IsListVisible;
        }
        public Guid RowOnayIndex;
        public int RowIndex;
        public bool IsDone = true;


        public Guid SelectedSehirKID;

        void InitData()
        {
            ds_Modul.KilavuzLogTbl.TableNewRow += (o, e) =>
            {
                e.Row[ds_Modul.KilavuzLogTbl.KilavuzIDColumn] = Guid.Empty;
                e.Row[ds_Modul.KilavuzLogTbl.OnayColumn] = false;
                e.Row[ds_Modul.KilavuzLogTbl.OnayAciklamasiColumn] = "";
                e.Row[ds_Modul.KilavuzLogTbl.SirketIDColumn] = Guid.Empty;
                e.Row[ds_Modul.KilavuzLogTbl.TarihColumn] = DateTime.Now;
                e.Row[ds_Modul.KilavuzLogTbl.ModulIDColumn] = Guid.Empty;
            };
        }
        public int counter = 0;
        private void KaydetMenuItem_Click(object sender, EventArgs e)
        {
            bs_Kilavuz.EndEdit();
            bs_Sirket.EndEdit();
            KilavuzGrid.EndEdit();
            checkedListBox1.Visible = false;
            InitData();
            bool IsContinue = true;
            int mboxCacl = 0;
            // CheckedItems'i geçici bir listeye kopyala
            var checkedItems = checkedListBox1.CheckedItems.Cast<object>().ToList();
            if (checkedItems.Count > 0)
            {
                // DataGridView'deki satırları geçici bir listeye kopyala
                var rows = KilavuzGrid.Rows.Cast<DataGridViewRow>().ToList();

                foreach (var item in checkedItems)
                {

                    foreach (var row1 in rows)
                    {
                        if (IsContinue == false)
                        {
                            break;
                        }
                        if (row1.Cells["IDData"].Value == null) continue;

                        if (Convert.ToBoolean(row1.Cells["Onay"].Value) == false)
                        {

                            if (string.IsNullOrWhiteSpace(row1.Cells["Aciklama"].Value.ToString()))
                            {
                                IsDone = false;
                                IsContinue = false;
                                break;
                            }
                            else if (!string.IsNullOrWhiteSpace(row1.Cells["Aciklama"].Value.ToString()))
                            {
                                IsContinue = true;

                            }

                        }

                        else if (Convert.ToBoolean(row1.Cells["Onay"].Value) == true)
                        {
                            IsContinue = true;
                        }
                    }

                    if (IsContinue == true)
                    {
                        foreach (var row in rows)
                        {
                            if (row.Cells["IDData"].Value == null) continue;

                            else
                            {
                                var UpdateRow = ds_Modul.KilavuzLogTbl.NewKilavuzLogTblRow();
                                UpdateRow.ID = Guid.NewGuid();
                                UpdateRow.KilavuzID = Guid.Parse(row.Cells["IDData"].Value.ToString());

                                // var SameRow = KilavuzTA.GetDataKilavuz(UpdateRow.KilavuzID);
                                UpdateRow.Onay = Convert.ToBoolean(row.Cells["Onay"].Value);
                                UpdateRow.OnayAciklamasi = Convert.ToString(row.Cells["Aciklama"].Value);
                                var SirketRow = Sirket_TA.GetDataBy(item.ToString());
                                UpdateRow.SirketID = Guid.Parse(SirketRow.Rows[0]["ID"].ToString());
                                UpdateRow.Tarih = DateTime.Now;
                                UpdateRow.ModulID = Guid.Parse(row.Cells["modulIDDataGridViewTextBoxColumn"].Value.ToString());

                                var SameRow = LogKilavuz_TableAdapter.GetDataForSameRow(UpdateRow.KilavuzID, UpdateRow.SirketID);


                                ds_Modul.KilavuzLogTbl.AddKilavuzLogTblRow(UpdateRow);
                                counter++;
                                if (SameRow.Count > 0)
                                {
                                    LogKilavuz_TableAdapter.UpdateVarOlan(UpdateRow.Onay, UpdateRow.OnayAciklamasi, UpdateRow.SirketID, UpdateRow.KilavuzID);
                                    KilavuzTA.UpdateKaydedilenSutunlar(UpdateRow.Onay, Convert.ToString(row.Cells["Aciklama"].Value), UpdateRow.KilavuzID);
                                }
                                else
                                {
                                    ds_Modul.EndInit();
                                    LogKilavuz_TableAdapter.Update(ds_Modul.KilavuzLogTbl);
                                    KilavuzTA.UpdateKaydedilenSutunlar(UpdateRow.Onay, Convert.ToString(row.Cells["Aciklama"].Value), UpdateRow.KilavuzID);
                                }
                            }
                        }
                    }
                }
                if (IsDone)
                {
                    MessageBox.Show("İşlem Tamamlandı", "Kaydetme İşlemi Tamamlandı", MessageBoxButtons.OK);
                    this.KilavuzTA.Fill(this.ds_Modul.KilavuzTbl);
                    int SelectedSirketRow=0;
                    foreach (var item in checkedListBox1.Items)
                    {
                        int index = checkedListBox1.Items.IndexOf(item); // Öğenin indeksini al

                        if (checkedListBox1.GetItemChecked(index)) // Eğer işaretli ise
                        {
                            // checked olan 1 tane şirket ismi var elimde şu an 
                            var row = Sirket_TA.GetAd(item.ToString());
                            Guid sirketID = (Guid)row.Rows[0]["ID"];

                            //selectedSirkete true yapmam lazım 
                            Tbl_SelectedSirket.UpdateSelected(true, sirketID);

                        }
                        else
                        {
                            // İşaretlenmemiş öğe için yapılacak işlem
                            var row = Sirket_TA.GetAd(item.ToString());
                            Guid sirketID = (Guid)row.Rows[0]["ID"];

                            //selectedSirkete true yapmam lazım 
                            Tbl_SelectedSirket.UpdateSelected(false, sirketID);
                        }
                    }

                    mboxCacl++;
                }
            }
            else
            {
                if (mboxCacl == 0)
                {
                    MessageBox.Show("Herhangi bir Şirket seçilmedi Lütfen Şirket Seçin");
                    mboxCacl++;
                }
            }

            if (IsContinue == false)
            {
                MessageBox.Show("İşlem Tamamlanmadı", "Boş Açıklama veya Onaylanmayan Kılavuz");
                this.KilavuzTA.Fill(this.ds_Modul.KilavuzTbl);
                menuStrip1.Refresh();
            }
        }
        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.KilavuzTA.Fill(this.ds_Modul.KilavuzTbl);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KilavuzTA.UpdateResetKilavuzOnayAndAciklama(false);
            Tbl_SelectedSirket.UpdateResetSelectedSirket(false);
            menuStrip1.Refresh();

        }

        private void resimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resimler resims = new Resimler();
            resims.ID = RowID;
            resims.ShowDialog();
            if (resims.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Tamamlandı.");
            }

        }
        public Guid RowID;
        private void KilavuzGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int selectedRow = e.RowIndex;
                //   MessageBox.Show(KilavuzGrid.Rows[selectedRow].Cells["mIcerikIDDataGridViewTextBoxColumn"].Value.ToString());
                RowID = Guid.Parse(KilavuzGrid.Rows[selectedRow].Cells["mIcerikIDDataGridViewTextBoxColumn"].Value.ToString());
            }
            catch (Exception)
            {
            }
            
        }
    }
}
