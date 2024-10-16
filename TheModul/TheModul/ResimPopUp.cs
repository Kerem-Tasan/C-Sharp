using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheModul
{
    public partial class ResimPopUp : Form
    {
        public Guid ID;
        public ResimPopUp()
        {
            InitializeComponent();
        }

        private void btn_Resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar (*.*)|*.*";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmin dosya yollarını listboxa atama
                foreach (var item in fileDialog.FileNames)
                {
               listBox1.Items.Add(item) ;
                }
                // Önceki resimleri temizleyin
                ımageList1.Images.Clear();
                int j = 0;
                // Yeni seçilen resmi ImageList'e ekleyin
                fileDialog.FileNames.ToList().ForEach(file =>
                {
                   Image selectedImage=Image.FromFile(file);
                    ımageList1.ImageSize = new Size(100, 100);
                    listView1.Items.Add(new ListViewItem
                    {
                        ImageIndex = j // Resmin indexini ayarla
                                       // Öğenin metnini ayarla
                    });
                    j++;
                });

                // Seçilen resmi PictureBox'ta göstermek için

                // ListView'de de güncelleme yapabilirsiniz, isterseniz
                listView1.Items.Clear();
                int i = 0;
                foreach (var image in ımageList1.Images)
                {
                    listView1.Items.Add(new ListViewItem
                    {
                        ImageIndex = i, // Resmin indexini ayarla
                       // Öğenin metnini ayarla 
                    });
                    i += 1;
                }
            }
        }
        private void ResimPopUp_Load(object sender, EventArgs e)
        {
            this.modul_IcerikTableAdapter.Fill(this.ds_modul.Modul_Icerik);

            // TODO: Bu kod satırı 'ds_modul.Modul_Icerik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            InitData();
            if (ID == Guid.Empty)
            {
                rpp_btn.Text = "Ekle";

            }
            else
            {// Buton metni

                rpp_btn.Text = "Güncelle";
                tbl_resim.FillByID(ds_modul.ResimTbl, ID);
                // Veritabanından görüntü verisini almak için gerekli satır
                //var row = tbl_resim.GetDataBy(ID);
                var row = ds_modul.ResimTbl.FirstOrDefault();
                if (row == null) return;
                else
                {
                    byte[] imageData = row.Resim; // Veya row[0]["Resim"] şeklinde de olabilir

                    // Byte dizisini bir görüntüye dönüştürme
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image img = Image.FromStream(ms);

                        // ImageList'i güncelleyin
                        ımageList1.ImageSize = new Size(100, 100); // Görsel boyutunu 100x100 olarak ayarlayın
                        ımageList1.Images.Clear(); // Önceki görselleri temizleyin (isteğe bağlı)
                        ımageList1.Images.Add(img); // Yeni resmi ekleyin

                        // Form tasarımında ListView kontrolünü oluşturun ve ImageList ile ilişkilendirin
                        listView1.View = View.LargeIcon; // Görsel boyutlarını ayarlayın
                        listView1.LargeImageList = ımageList1; // ImageList'i ayarlayın

                        // ImageList'e eklenen her görüntü için ListView'e bir öğe ekleme
                        listView1.Items.Clear(); // ListView'i temizleyin (isteğe bağlı)
                        for (int i = 0; i < ımageList1.Images.Count; i++)
                        {
                            // Her görsel için bir ListViewItem oluşturun
                            ListViewItem item = new ListViewItem
                            {
                                ImageIndex = i // Görselin ImageList içindeki indeksini ayarlayın
                            };
                            listView1.Items.Add(item); // ListView'e öğeyi ekleyin
                        }

                        // PictureBox'a dönen resmi gösterme

                    }
                    // row.ResimColumn'un verisini byte dizisine atama
                }
            }
        }
        void InitData()
        {
            ds_modul.ResimTbl.TableNewRow += (o, e) =>
            {
                e.Row[ds_modul.ResimTbl.AdiColumn] = "";
                e.Row[ds_modul.ResimTbl.TarihColumn] = DateTime.Now;
                e.Row[ds_modul.ResimTbl.ResimColumn] = new byte[0];
                e.Row[ds_modul.ResimTbl.IcerikIDColumn] = Guid.Parse("3b8734f1-f3d7-4815-9fa6-0553d5de3e5a");
            };
        }
        private void rpp_btn_Click(object sender, EventArgs e)
        {
            if (rpp_btn.Text == "Ekle")
            {
                //    foreach (var item in )
                //    {

                //    }
                foreach(var item in listBox1.Items)
                {
                    var row = ds_modul.ResimTbl.NewResimTblRow();

                    row.ID = Guid.NewGuid();
                    row.Adi = txt_resim.Text;
                    row.IcerikID = Guid.Parse(comboBox1.SelectedValue.ToString());

                    row.Resim = File.ReadAllBytes(item.ToString());
                    ds_modul.ResimTbl.AddResimTblRow(row);
                    ds_modul.EndInit();
                    tbl_resim.Update(ds_modul.ResimTbl);
                    MessageBox.Show("işlem tamamlandı");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
               
            }
            else
            {
                // Güncellenmesi gereken mevcut satırın ID'si ile satırı buluyoruz
                var row = ds_modul.ResimTbl.FindByID(ID); // guncellenecekID, güncellemek istediğiniz satırın ID'si

                if (row != null)
                {
                    // ImageList'te en az bir resim var mı diye kontrol ediyoruz
                    if (ımageList1.Images.Count > 0)
                    {
                        // İlk resmi alıyoruz (veya istediğiniz indexteki resmi seçebilirsiniz)
                        Image img = ımageList1.Images[0]; // İlk resim için [0] kullandık

                        // Image'ı byte[]'a çevirmek için MemoryStream kullanıyoruz
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Resmi JPEG formatında kaydediyoruz
                            byte[] resimBytes = ms.ToArray(); // Resmi byte dizisine çeviriyoruz

                            // Satırın "Resim" kolonunu güncelliyoruz
                            row.Resim = resimBytes;
                        }

                        // Diğer alanları da güncelleyin (örneğin, resim adını güncelleyebilirsiniz)
                        row.Adi = txt_resim.Text;

                        // Değişiklikleri DataSet'e yansıttıktan sonra Update çağrılır
                        ds_modul.EndInit();
                        bs_resim.EndEdit();
                        tbl_resim.Update(ds_modul.ResimTbl);

                        MessageBox.Show("Güncelleme Tamamlandı!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ImageList'te resim bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek satır bulunamadı.");
                }
            }
        }
    }
}

