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
    public partial class IstekIslemleri : Form
    {
        public int UserTypeIslem;

        public IstekIslemleri()
        {
            InitializeComponent();
        }
        // Sınıf seviyesi field tanımlıyoruz

        //_LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter adapter=new _LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter();
        // _LTS_MiniDataSetTableAdapters.IstekTblTableAdapter adapter1 = new _LTS_MiniDataSetTableAdapters.IstekTblTableAdapter();
        _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter adapter1 = new _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter();



        public void GridDoldur(bool IsTamamlandi)
        {
            adapter1.FillBy(this._LTS_MiniDataSet.IstekTbl1,IsTamamlandi);

        }
        private void BekleyenIstek_Click(object sender, EventArgs e)
        {

        }

        private void IstekIslemleri_Load(object sender, EventArgs e)
        {// TODO: Bu kod satırı '_LTS_MiniDataSet.YazilimciAd' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //   this.yazilimciAdTableAdapter.Fill(this._LTS_MiniDataSet.YazilimciAd);
         // TODO: Bu kod satırı '_LTS_MiniDataSet.IstekTbl1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //  this.istekTbl1TableAdapter.Fill(this._LTS_MiniDataSet.IstekTbl1);
         // TODO: Bu kod satırı '_LTS_MiniDataSet.IstekTbl1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //   this.istekTbl1TableAdapter.FillBy(this._LTS_MiniDataSet.IstekTbl1, false);
         // TODO: Bu kod satırı '_LTS_MiniDataSet.IstekTbl1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //    this.istekTbl1TableAdapter.Fill(this._LTS_MiniDataSet.IstekTbl1);
         // TODO: Bu kod satırı 'LTS_MiniDataSet.IstekTbl1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
         //  this.istekTbl1TableAdapter.Fill(this.LTS_MiniDataSet.IstekTbl1);
         // Yönetici İşlem Yetkileri


            GridDoldur(false);
            UserTypeIslem = YetkiBelirleme.YetkiID;
            if (UserTypeIslem == 4)
            {
                // Yazılımcı İşlemleri
                contextMenuStrip1.Items["yazilimciDurumToolStripMenuItem"].Visible = true;
                contextMenuStrip1.Items["yazılımcıMesajToolStripMenuItem"].Visible = true;


                // Tester İşlemi                                           
                contextMenuStrip1.Items["testerDurumToolStripMenuItem"].Visible = true;
                contextMenuStrip1.Items["testerMesajToolStripMenuItem"].Visible = true;

                // Yönetici İşlemleri                                      
                contextMenuStrip1.Items["yöneticiMesajToolStripMenuItem"].Visible = true;

                // Tamamlanma İşlemi                                       
                contextMenuStrip1.Items["tamamlandıToolStripMenuItem"].Visible = true;
            }

            else if (UserTypeIslem == 3)
            {
                contextMenuStrip1.Items["testerDurumToolStripMenuItem"].Visible = true;
                contextMenuStrip1.Items["testerMesajToolStripMenuItem"].Visible = true;

            }
            else if (UserTypeIslem == 2)
            {
                contextMenuStrip1.Items["testerMesajToolStripMenuItem"].Visible = true;
                contextMenuStrip1.Items["testerDurumToolStripMenuItem"].Visible = true;

            }
            else if (UserTypeIslem == 1)
            {

            }
            GridDoldur(false);


        }
        private bool IsTrue = false;
        private void IstekIslemTab_Control_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (IstekIslemTab_Control.SelectedIndex == 0)
            {
                GridDoldur(false);
            }
           else  if (IstekIslemTab_Control.SelectedIndex == 1)
            {
                GridDoldur(true);

            }
            


            //if (IsTrue == true)
            //{
            //    IsTrue = false;
            //}
            //else if (IsTrue == false)
            //{

            //    IsTrue = true;

            //}

            //GridDoldur(IsTrue);


        }

        private void beklemedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["yazilimciDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir yazılımcı atayın !");
                row = "";
            }
            else
            {
 DialogResult dailog = MessageBox.Show(IstekID + " 'li Yazılımcının Durumu 'Beklemede' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
            if (dailog == DialogResult.OK)
            {
                adapter1.UpdateYazilimciDurum(1,null,null, IstekID);
                GridDoldur(IsTrue);
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
            }
           
        }
        public int IstekID;
        public int selectdrow;
        private void IstekIslemleriGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    int rowSelected = e.RowIndex;
                    selectdrow = rowSelected;
                    if (e.RowIndex != -1)
                    {
                        this.IstekIslemleriGrid.ClearSelection();
                        this.IstekIslemleriGrid.Rows[rowSelected].Selected = true;
                        var cellValue = IstekIslemleriGrid.Rows[rowSelected].Cells["ıstekIDDataGridViewTextBoxColumn"].Value;

                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int istekId))
                        {
                            IstekID = istekId;
                            YetkiBelirleme.IslemID = IstekID;

                        }
                        else
                        {
                          
                        }
                    }
                    contextMenuStrip1.Show(MousePosition);
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int rowSelected = e.RowIndex;
                    if (e.RowIndex != -1)
                    {
                        this.IstekIslemleriGrid.ClearSelection();
                        this.IstekIslemleriGrid.Rows[rowSelected].Selected = true;
                        var cellValue = IstekIslemleriGrid.Rows[rowSelected].Cells["ıstekIDDataGridViewTextBoxColumn"].Value;

                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int istekId))
                        {
                            IstekID = istekId;
                            YetkiBelirleme.IslemID = IstekID;

                        }
                        else
                        {
                         
                        }
                    }


                }
                //  int selectedIndex=e.RowIndex;
                //IstekID = Convert.ToInt32(IstekIslemleriGrid.Rows[selectedIndex].Cells["ıstekIDDataGridViewTextBoxColumn"].Value);
                //GridDoldur(IsTrue);
            }
            catch (Exception)
            {


            }

        }
       
        private void başladıToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["yazilimciDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir yazılımcı atayın !");
                row = "";
            }
            else
            {
                DateTime anlik = DateTime.Now;

                DialogResult dailog = MessageBox.Show(IstekID + " 'li Yazılımcının Durumu 'Başladı' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
                if (dailog == DialogResult.OK)
                {

                    adapter1.UpdateYazilimciDurum(2, Convert.ToString(anlik), null, IstekID);
                    GridDoldur(IsTrue);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
        }

        private void bittiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["yazilimciDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir yazılımcı atayın !");
                row = "";
            }
            else
            {
                int rowSelected = selectdrow;
                var cellValue = IstekIslemleriGrid.Rows[rowSelected].Cells["YazilimciBaslangicTarihi"].Value;


                DateTime anlik = DateTime.Now;
                DialogResult dailog = MessageBox.Show(IstekID + " 'li Yazılımcının Durumu 'Testera Gönderildi' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
                if (dailog == DialogResult.OK)
                {
                    adapter1.UpdateYazilimciDurum(3, cellValue.ToString(), Convert.ToString(anlik), IstekID);
                    GridDoldur(IsTrue);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
        }

        private void yazılımcıMesajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row1 = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["yazilimciDataGridViewTextBoxColumn"].Value);
            if (row1.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir yazılımcı atayın !");
                row1 = "";
            }
            else
            {

                if (IstekIslemleriGrid.SelectedRows.Count > 0)
                {
                    var row = IstekIslemleriGrid.SelectedRows[0];


                    string mesaj = row.Cells["yazilimciAciklamaData"].Value.ToString();

                    DialogResult dia = MessageBox.Show(" Yazılımcı Güncel Açıklama:  '" + mesaj + "'\n Yeni bir açıklama girmek için Evet'e tıklayın.", "Güncelleme Onayı", MessageBoxButtons.YesNoCancel);
                    if (dia == DialogResult.Yes)
                    {
                        YetkiBelirleme.mesaj = mesaj;
                        // Yazılımcı mesajı için InputBox
                        InputForm ınputForm = new InputForm();
                        ınputForm.IstekID = IstekID;
                        ınputForm.IsTester = 1;
                        ınputForm.ShowDialog();
                        GridDoldur(true);

                    }
                    else if (dia == DialogResult.No || dia == DialogResult.Cancel)
                    {

                    }

                }
            }

        }

        private void IstekIslemleriGrid_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void beklemedeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["testerDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir tester atayın !");
                row = "";
            }
            else
            {
                DialogResult dailog = MessageBox.Show(IstekID + " 'li Tester'ın Durumu 'Beklemede' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
                if (dailog == DialogResult.OK)
                {
                    adapter1.UpdateTesterDurum(1, null, null, IstekID);
                    GridDoldur(IsTrue);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
        }

        private void testAşamasıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["testerDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir tester atayın !");
                row = "";
            }
            else
            {
                DateTime anlik = DateTime.Now;

                DialogResult dailog = MessageBox.Show(IstekID + " 'li Tester'ın Durumu 'Test Aşaması' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
                if (dailog == DialogResult.OK)
                {
                    adapter1.UpdateTesterDurum(3, Convert.ToString(anlik), null, IstekID);
                    GridDoldur(IsTrue);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
        }

        private void onaylandıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["testerDataGridViewTextBoxColumn"].Value);
            if (row.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir tester atayın !");
                row = "";
            }
            else
            {
                int rowSelected = selectdrow;
                var cellValue = IstekIslemleriGrid.Rows[rowSelected].Cells["TesterBaslangicTarihi"].Value;



                DateTime anlik = DateTime.Now;
                DialogResult dailog = MessageBox.Show(IstekID + " 'li Tester'ın Durumu 'Onaylandı' Olacak Onaylıyor Musunuz?", "Güncelleme Onayı", MessageBoxButtons.OKCancel);
                if (dailog == DialogResult.OK)
                {
                    adapter1.UpdateTesterDurum(4, cellValue.ToString(), Convert.ToString(anlik), IstekID);
                    GridDoldur(IsTrue);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
        }

        private void testerMesajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rowq = Convert.ToString(IstekIslemleriGrid.Rows[selectdrow].Cells["testerDataGridViewTextBoxColumn"].Value);
            if (rowq.Equals("Atanmadı"))
            {
                MessageBox.Show("Öncelikle bir tester atayın !");
                rowq = "";
            }
            else
            {
                if (IstekIslemleriGrid.SelectedRows.Count > 0)
                {
                    var row = IstekIslemleriGrid.SelectedRows[0];


                    string mesaj = row.Cells["testerAciklamaDataGridViewTextBoxColumn"].Value.ToString();
                    DialogResult dailog = MessageBox.Show("Tester Güncel Açıklama: " + mesaj + "\n Yeni bir açıklama girmek için Evet'e tıklayın.", "Güncelleme Onayı", MessageBoxButtons.YesNoCancel);
                    if (dailog == DialogResult.Yes)
                    {
                        YetkiBelirleme.mesaj = mesaj;
                        InputForm ınputForm = new InputForm();
                        ınputForm.IstekID = IstekID;
                        ınputForm.IsTester = 2;
                        ınputForm.ShowDialog();
                        GridDoldur(false);
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi");

                    }
                }
            }
        }



        private void yöneticiMesajToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (IstekIslemleriGrid.SelectedRows.Count > 0)
            {
                var row = IstekIslemleriGrid.SelectedRows[0];


                string mesaj = row.Cells["yoneticiAciklamaDataGridViewTextBoxColumn"].Value.ToString();
                DialogResult dailog = MessageBox.Show("Yönetici Güncel Açıklama: " + mesaj + "\n \nYeni bir açıklama girmek için Evet'e tıklayın.", "Güncelleme Onayı", MessageBoxButtons.YesNoCancel);
                if (dailog == DialogResult.Yes)
                {
                    YetkiBelirleme.mesaj = mesaj;
                    InputForm ınputForm = new InputForm();
                    ınputForm.IstekID = IstekID;
                    ınputForm.IsTester = 3;
                    ınputForm.ShowDialog();
                    GridDoldur(false);
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");

                }
            }
        }

        private void tamamlandıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Istek Tamamlandı Olarak Güncellenecek Onaylıyor musunuz?", "Istek Tamamlama Onayı", MessageBoxButtons.OKCancel);
            if (di == DialogResult.OK)
            {

                adapter1.UpdateTamamlandiMi(IstekID);
                MessageBox.Show("İstek Güncellendi");
                GridDoldur(false);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GridDoldur(true);

            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    int rowSelected = e.RowIndex;
                    if (e.RowIndex != -1)
                    {
                        this.IstekIslemleriGrid.ClearSelection();
                        this.IstekIslemleriGrid.Rows[rowSelected].Selected = true;
                        var cellValue = dataGridView2.Rows[rowSelected].Cells["dataGridViewTextBoxColumn14"].Value;

                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int istekId))
                        {
                            IstekID = istekId;
                            YetkiBelirleme.IslemID = IstekID;

                        }
                        else
                        {
                            // Handle the case where the value is null or not convertible to int
                            MessageBox.Show("Invalid IstekID value.");
                        }
                    }
                    contextMenuStrip1.Show(MousePosition);
                }
                //  int selectedIndex=e.RowIndex;
                //IstekID = Convert.ToInt32(IstekIslemleriGrid.Rows[selectedIndex].Cells["ıstekIDDataGridViewTextBoxColumn"].Value);
                //GridDoldur(IsTrue);
            }
            catch (Exception)
            {


            }
        }
    }
}
