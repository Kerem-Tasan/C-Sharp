using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheModul
{
    public partial class ModelIcerikPopUp : Form
    {
        public Guid ID;
        public Guid IcerikID;
        public ModelIcerikPopUp()
        {
            InitializeComponent();
        }
        private void ModelIcerikPopUp_Load(object sender, EventArgs e)
        {
            InitData();
            InitKilavuzData();
            InitResimData();
            this.resimTblTableAdapter.Fill(this.ds_modul.ResimTbl);
            this.tbl_Modul.Fill(this.ds_modul.ModulTbl);
            if (ID == Guid.Empty)
            {
                mipp_btn.Text = "Ekle";
                var row = ds_modul.Modul_Icerik.NewModul_IcerikRow();
                row.ID = Guid.NewGuid();
                ID = row.ID;
                IcerikID = row.ID;
                ds_modul.Modul_Icerik.AddModul_IcerikRow(row);
            }
            else if (ID != Guid.Empty)
            {
                mipp_btn.Text = "Güncelle";
                this.tbl_ModulIcerik.FillByID(this.ds_modul.Modul_Icerik, ID);
                tbl_resim.FillByIcerikID(ds_modul.ResimTbl, ID);

                ds_modul.ResimTbl.ToList().ForEach(x =>
                {

                    MemoryStream ms = new MemoryStream();
                    ms.Write(x.Resim, 0, x.Resim.Length);
                    ımageList1.Images.Add(Image.FromStream(ms));
                    listView1.View = View.LargeIcon; // Görsel boyutlarını ayarlayın
                    listView1.LargeImageList = ımageList1; // ImageList'i ayarlayın
                });

                // ImageList'teki her resim için ListViewItem oluşturma
                for (int i = 0; i < ımageList1.Images.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;  // Her item'a ilgili resmin indeksini veriyoruz
                    listView1.Items.Add(item);  // ListView'a item ekliyoruz
                }
            }
        }
        void InitResimData()
        {
            ds_modul.ResimTbl.TableNewRow += (o, e) =>
            {
                e.Row[ds_modul.ResimTbl.AdiColumn] = "";
                e.Row[ds_modul.ResimTbl.TarihColumn] = DateTime.Now;
                e.Row[ds_modul.ResimTbl.ResimColumn] = DBNull.Value;
                e.Row[ds_modul.ResimTbl.IcerikIDColumn] = Guid.Empty;
            };
        }
        void InitKilavuzData()
        {
            ds_modul.KilavuzTbl.TableNewRow += (o, e) =>
            {
                e.Row[ds_modul.KilavuzTbl.MIcerikIDColumn] = IcerikID;
                e.Row[ds_modul.KilavuzTbl.OnayColumn] = false;
                e.Row[ds_modul.KilavuzTbl.OnayAciklamasiColumn] = "";
                e.Row[ds_modul.KilavuzTbl.ModulIDColumn] = cmb_Modul.SelectedValue;
                e.Row[ds_modul.KilavuzTbl.TarihColumn] = DateTime.Now;
                //e.Row[ds_modul.KilavuzTbl.SirketIDColumn] = Guid.Parse("ee0ae694-514d-41ae-b3a2-6f490a485875");
            };
        }
        void InitData()
        {
            ds_modul.Modul_Icerik.TableNewRow += (o, e) =>
            {
                e.Row[ds_modul.Modul_Icerik.IcerikAdiColumn] = "";
                e.Row[ds_modul.Modul_Icerik.IcerikAciklamasiColumn] = "";
                e.Row[ds_modul.Modul_Icerik.KayitTarihiColumn] = DateTime.Now;
                e.Row[ds_modul.Modul_Icerik.ModulIDColumn] = Guid.Empty;
            };
        }
        private void mipp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mipp_btn.Text == "Ekle")
                {
                    var row1 = ds_modul.KilavuzTbl.NewKilavuzTblRow();
                    row1.ID = Guid.NewGuid();
                    row1.MIcerikID = ID;
                    ds_modul.KilavuzTbl.AddKilavuzTblRow(row1);

                }
                else
                {
                    ds_modul.EndInit();
                    modulIcerikBindingSource.EndEdit();
                    var rowIcerik = ds_modul.Modul_Icerik.FindByID(ID);
                    rowIcerik.IcerikAdi = txt_IcerikAdi.Text;
                    rowIcerik.IcerikAciklamasi = txt_Aciklama.Text;
                    rowIcerik.ModulID = Guid.Parse(cmb_Modul.SelectedValue.ToString());
                    tbl_ModulIcerik.Update(ds_modul.Modul_Icerik);
                }
                int a = 0;

                // Imageleri geziyor
                foreach (var item in listBox1.Items)
                //foreach (var item in listBox1.Items)
                {
                    if (listBox1.Items.Count == 0) { continue; }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (FileStream fs = new FileStream(item.ToString(), FileMode.Open, FileAccess.Read))
                        {
                            fs.CopyTo(ms);  // Dosyayı MemoryStream'e kopyala
                        }

                        // Dosya byte dizisine dönüştürülüyor
                        byte[] fileBytes = ms.ToArray();
                        //Kılavuza eklemek için açılan yeni row'a ID atayıp belirleme 

                        // Yeni satır ekle
                        var row = ds_modul.ResimTbl.NewResimTblRow();
                        row.ID = Guid.NewGuid();  // Yeni bir GUID oluştur
                        row.Adi = item.ToString();  // Dosya adını ekle
                        row.IcerikID = ID;  // İlgili IcerikID ekleniyor

                        // Byte verisini veritabanına ekle
                        row.Resim = fileBytes;  // Resim sütununa byte dizisini atıyoruz

                        // DataSet'e ekleme işlemleri
                        ds_modul.ResimTbl.AddResimTblRow(row);
                        a += 1;  // a değişkenini artır


                    }
                    bs_modul.EndEdit();
                    modulIcerikBindingSource.EndEdit();
                    ds_modul.EndInit();
                    tbl_Kilavuz.Update(ds_modul.KilavuzTbl);
                    tbl_ModulIcerik.Update(ds_modul.Modul_Icerik);
                    tbl_resim.Update(ds_modul.ResimTbl);
                }

                //bs_modul.EndEdit();
                //modulIcerikBindingSource.EndEdit();
                //ds_modul.EndInit();
                //tbl_Kilavuz.Update(ds_modul.KilavuzTbl);
                //tbl_ModulIcerik.Update(ds_modul.Modul_Icerik);
                //tbl_resim.Update(ds_modul.ResimTbl);
                //MessageBox.Show("İşlem Tamamlandı!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");

            }

        }
        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar (*.*)|*.*";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in fileDialog.FileNames)
                {
                    bool iscontineu = true;
                    var row = tbl_resim.GetDataByIcerikID(ID);

                    // Eğer satır varsa

                    if (row.Rows.Count > 0)
                    {
                        int a = 0;
                        foreach (DataRow dr in row.Rows)
                        {
                            // İlk satırdaki "Adi" sütununa erişim
                            var adiDegeri = row.Rows[a]["Adi"].ToString(); // "Adi" sütununun değeri
                            a++;
                            if (adiDegeri == item.ToString())
                            {
                                iscontineu = true;
                                continue;
                            }
                            else
                            {
                                if (iscontineu)
                                {
                                    iscontineu = false;
                                    listBox1.Items.Add(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        listBox1.Items.Add(item);
                    }
                }
                int imagesayisi = ımageList1.Images.Count;
                foreach (var item in listBox1.Items)
                {
                    byte[] imageData = File.ReadAllBytes(item.ToString()); // Dosyayı byte dizisine çevir

                    using (MemoryStream ms = new MemoryStream(imageData)) // MemoryStream ile byte dizisini kullan
                    {
                        Image selectedImage = Image.FromStream(ms); // MemoryStream'den resmi yükle

                        ımageList1.Images.Add(selectedImage); // ImageList'e ekle
                        listView1.Items.Add(new ListViewItem { ImageIndex = imagesayisi });

                    }
                }
            }
        }
        public List<string> selectedItemsTexts = new List<string>();

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //foreach (ListViewItem item in listView1.SelectedItems)
            //{
            //    selectedItemsTexts.Add(item.Text);  // Öğenin metnini listeye ekle
            //}
            //// Listede olan öğeleri göster (deneme amaçlı)
            ////MessageBox.Show("Seçilen öğeler: " + string.Join(", ", selectedItemsTexts));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ımageList1.Images.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
