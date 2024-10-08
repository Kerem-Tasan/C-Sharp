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
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("28b02d63-6855-41b8-a750-11b4fe016e20") || KullanıcıBilgileri.KullaniciYetki == Guid.Parse("383b04e6-9253-4ab1-9743-3165e56e4919") || KullanıcıBilgileri.KullaniciYetki == Guid.Parse("0a2bd29a-8c4c-4b55-99d8-8274b0f8e422"))
            {
                Kullanici_Grid.Columns["sifreDataGridViewTextBoxColumn"].Visible = false;
                Kullanici_Grid.Columns["kullaniciAdiDataGridViewTextBoxColumn"].Visible = false;
                kullaniciTblTableAdapter.FillByAd(gorevDS.KullaniciTbl, KullanıcıBilgileri.KullaniciAd,false);
                ekleToolStripMenuItem.Visible = false;
                silToolStripMenuItem.Visible = false;
                aktifleriListeleToolStripMenuItem.Visible = false;
                silinenleriListeleToolStripMenuItem.Visible = false;
            }

            else if (KullanıcıBilgileri.KullaniciYetki == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
            {
                kullaniciTblTableAdapter.FillByall(gorevDS.KullaniciTbl,false);
            }
            // TODO: Bu kod satırı 'gorevDS.KullaniciTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        void Kullanici_Load(bool IsDeleted)
        {
            this.kullaniciTblTableAdapter.FillByall(this.gorevDS.KullaniciTbl, IsDeleted);

        }
        private void Kullanici_Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    OnayVerileri.KullaniciGridID = Guid.Parse(Kullanici_Grid.Rows[selectedRow].Cells["ıDDataGridViewTextBoxColumn"].Value.ToString());

                }

                else
                {
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu satırla işlem yapamazsınız");
               
            }


        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnayVerileri.KullaniciGridID = Guid.Empty;
            KullanicEkle_Guncelle keKLE = new KullanicEkle_Guncelle();
            keKLE.IsGuncelle = false;
            keKLE.ShowDialog();
        }
        private void güncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KullanicEkle_Guncelle KeKLE = new KullanicEkle_Guncelle();
            KeKLE.IsGuncelle = true;
            KeKLE.ShowDialog();
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            DialogResult dia = MessageBox.Show("Silme İşlemini Onaylıyor musunuz ?", "Silme Onayı", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                InputForm inp = new InputForm();
                inp.IsWhat = 4;
                inp.ShowDialog();
                if (inp.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Kullanıcı Başarıyla Silindi!");
                }

            }
        }

        private void aktifleriListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kullanici_Load(false);
        }

        private void silinenleriListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kullanici_Load(true);
        }
    }
}
