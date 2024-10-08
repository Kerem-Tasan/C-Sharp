using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApplication
{
    public partial class GorevSayfası : Form
    {
        public Guid id = KullanıcıBilgileri.KullaniciID;
        public Guid YetkiID = KullanıcıBilgileri.KullaniciYetki;
        public GorevSayfası()
        {
            InitializeComponent();
        }
        void GridDoldur(bool IsDone, bool Deleted)
        {
            if (YetkiID == Guid.Parse("28b02d63-6855-41b8-a750-11b4fe016e20") || YetkiID == Guid.Parse("383b04e6-9253-4ab1-9743-3165e56e4919") || YetkiID == Guid.Parse("0a2bd29a-8c4c-4b55-99d8-8274b0f8e422"))
            {

                this.gorevTblTableAdapter.FillByAd(this.gorevDS.GorevTbl, IsDone, Deleted, KullanıcıBilgileri.KullaniciAd);
            }

            else if (YetkiID == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
            {
                this.gorevTblTableAdapter.Fill(this.gorevDS.GorevTbl, Deleted, false);

            }
        }


        private void GorevSayfası_Load(object sender, EventArgs e)
        {

            // Müşteri  :28b02d63-6855-41b8-a750-11b4fe016e20
            // Yazılımcı : 383b04e6-9253-4ab1-9743-3165e56e4919
            // Tester : 0a2bd29a-8c4c-4b55-99d8-8274b0f8e422
            // Yönetici :43159117-4f30-4676-8e8d-fbd933885eb5


            // Kişiye göre grid doldurma
            if (YetkiID == Guid.Parse("28b02d63-6855-41b8-a750-11b4fe016e20"))
            {

                this.gorevTblTableAdapter.FillByAd(this.gorevDS.GorevTbl, IsDone, false, KullanıcıBilgileri.KullaniciAd);
                CtxStrip.Items["yöneticiOnayıToolStripMenuItem"].Visible = false;


            }
            else if (YetkiID == Guid.Parse("383b04e6-9253-4ab1-9743-3165e56e4919") || YetkiID == Guid.Parse("0a2bd29a-8c4c-4b55-99d8-8274b0f8e422"))
            {
                this.gorevTblTableAdapter.FillByAd(this.gorevDS.GorevTbl, IsDone, false, KullanıcıBilgileri.KullaniciAd);
                CtxStrip.Items["kullanıcıOnayıToolStripMenuItem"].Visible = false;

                CtxStrip.Items["yöneticiOnayıToolStripMenuItem"].Visible = false;

             
            }
            else if (YetkiID == Guid.Parse("43159117-4f30-4676-8e8d-fbd933885eb5"))
            {
                this.gorevTblTableAdapter.Fill(this.gorevDS.GorevTbl, IsDone, false);
                CtxStrip.Items["kullanıcıOnayıToolStripMenuItem"].Visible = false;


            }
            GridDoldur(false, false);
            {
               
               
            }

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GorevPopUp gorevPopUp = new GorevPopUp();
            gorevPopUp.id = id;


            gorevPopUp.GorevIDPopup = Guid.Empty;
            gorevPopUp.PopUpYetki = YetkiID;
            gorevPopUp.ShowDialog();
            if (gorevPopUp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Başarıyla Tamamlandı !");
                GridDoldur(Istrue, false);
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevPopUp gorevPopUp = new GorevPopUp();
            gorevPopUp.id = id;
            gorevPopUp.GorevIDPopup = IstekID;
            gorevPopUp.ShowDialog();
            //KullanıcıBilgileri.RowID=
            if (gorevPopUp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem Başarıyla Tamamlandı !");
                GridDoldur(Istrue, false);
            }
        }


        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {



            DialogResult dia = MessageBox.Show("Silme İşlemini Onaylıyor musunuz ? ", "Silme Onayı", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {

                InputForm inputForm = new InputForm();

                OnayVerileri.GorevID = IstekID;
                inputForm.IsWhat = 3;
                inputForm.ShowDialog();
                MessageBox.Show("İşlem Başarıyla Tamamlandı !");
                GridDoldur(Istrue, false);
            }
            else
            {
                MessageBox.Show("İşlem İptal edildi!");
            }


        }
        public bool Istrue;
        public bool IsDone;
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (IsDone == true)
            {
                IsDone = false;
            }
            else
            {
                IsDone = true;
            }
            if (Istrue == true)
            {
                Istrue = false;
            }
            else
            {
                Istrue = true;
            }
            GridDoldur(Istrue, false);

        }
        public int selectedRow;
        public int GorevID;


        private void kullanıcıOnayıToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var row = Convert.ToString(GorevGrid.Rows[selectedRow].Cells["KullaniciOnayli"].Value);
            if (Convert.ToBoolean(row))
            {
                MessageBox.Show("Görev Zaten Onaylı !");
            }
            else if (!Convert.ToBoolean(row))
            {
                DialogResult dia = MessageBox.Show("Görevi Onaylamak istiyor musunuz?", "Görev Onaylama ", MessageBoxButtons.OKCancel);
                if (dia != DialogResult.OK)
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
                else if (DialogResult.OK == dia)
                {
                    InputForm formInput = new InputForm();
                    formInput.IsWhat = 1;
                    OnayVerileri.GorevID = IstekID;
                    OnayVerileri.YoneticiOnay = false;
                    formInput.ShowDialog();

                    if (formInput.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Kullanıcı Görevi Başarıyla Onaylandı !");
                        GridDoldur(Istrue, false);
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi !");
                    }
                }

            }


        }
        public Guid IstekID;
        private void GorevGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                selectedRow = rowSelected;
                if (e.RowIndex != -1)
                {
                    this.GorevGrid.ClearSelection();
                    this.GorevGrid.Rows[rowSelected].Selected = true;
                    KullanıcıBilgileri.RowID = Guid.Parse(GorevGrid.Rows[rowSelected].Cells["IdData"].Value.ToString());
                    var cellValue = GorevGrid.Rows[rowSelected].Cells["IdData"].Value;

                    if (cellValue != null && Guid.TryParse(cellValue.ToString(), out Guid istekId))
                    {
                        IstekID = istekId;


                    }
                    else
                    {

                    }
                }
                CtxStrip.Show(MousePosition);
            }
            else if (e.Button == MouseButtons.Left)
            {
                int rowSelected = e.RowIndex;
                selectedRow = rowSelected;
                if (e.RowIndex != -1)
                {
                    this.GorevGrid.ClearSelection();
                    this.GorevGrid.Rows[rowSelected].Selected = true;
                    var cellValue = GorevGrid.Rows[rowSelected].Cells["IdData"].Value;

                    if (cellValue != null && Guid.TryParse(cellValue.ToString(), out Guid id))
                    {
                        IstekID = id;

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

        private void kullanıcıOnayAçıklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var cellKAciklamaValue = GorevGrid.Rows[selectedRow].Cells["dataGridViewTextBoxColumn15"].Value;
            if (cellKAciklamaValue != null)
            {
                OnayVerileri.KullaniciAciklama = cellKAciklamaValue.ToString();
                // Artık 'Aciklama' değişkenini kullanabilirsiniz                   }
            }
            MessageBox.Show(OnayVerileri.KullaniciAciklama, "Kullanıcı Onay Açıklaması ", MessageBoxButtons.OK);

        }

        private void yöneticiOnayAçıklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cellOnayliMi = Convert.ToBoolean(GorevGrid.Rows[selectedRow].Cells["KullaniciOnayli"].Value);
            if (!cellOnayliMi)
            {
                MessageBox.Show("Kullanıcı Onaylı Değil! Kullanıcı Onayını bekleyin ");

            }
            else if (cellOnayliMi)
            {

                var cellYAciklamaValue = GorevGrid.Rows[selectedRow].Cells["dataGridViewTextBoxColumn16"].Value;
                if (cellYAciklamaValue != null)
                {
                    OnayVerileri.YoneticiAciklama = cellYAciklamaValue.ToString();
                    // Artık 'Aciklama' değişkenini kullanabilirsiniz                   }
                }
                if (OnayVerileri.YoneticiAciklama.Equals(""))
                {
                    MessageBox.Show("Yönetici henüz bir açıklama yayımlamadı !");
                }
                else
                {
                MessageBox.Show(OnayVerileri.YoneticiAciklama, "Kullanıcı Onay Açıklaması ", MessageBoxButtons.OK);
                }
            }
        }

        private void yöneticiOnayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cellOnayliMi = Convert.ToBoolean(GorevGrid.Rows[selectedRow].Cells["KullaniciOnayli"].Value);
            if (!cellOnayliMi)
            {
                MessageBox.Show("Kullanıcı Onaylı Değil! Kullanıcı Onayını bekleyin ");

            }
            else if (cellOnayliMi)
            {
                if (Convert.ToBoolean(GorevGrid.Rows[selectedRow].Cells["YoneticiOnayli"].Value))
                {
                    MessageBox.Show("Görev Zaten Onaylı !");
                }
                else if (!Convert.ToBoolean(GorevGrid.Rows[selectedRow].Cells["YoneticiOnayli"].Value))
                {
                    DialogResult dia = MessageBox.Show("Görevi Onaylamak istiyor musunuz?", "Görev Onaylama", MessageBoxButtons.OKCancel);
                    if (dia != DialogResult.OK)
                    {
                        MessageBox.Show("İşlem iptal edildi");
                    }
                    else if (DialogResult.OK == dia)
                    {
                        InputForm formInput = new InputForm();
                        formInput.IsWhat = 2;
                        OnayVerileri.GorevID = IstekID;
                        OnayVerileri.KullaniciAciklama = Convert.ToString(GorevGrid.Rows[selectedRow].Cells["dataGridViewTextBoxColumn15"].Value);
                        OnayVerileri.YoneticiOnay = false;
                        formInput.ShowDialog();

                        if (formInput.DialogResult == DialogResult.OK)
                        {
                            MessageBox.Show("Kullanıcı Görevi Yönetici Tarafaında Başarıyla Onaylandı !");
                            gorevTblTableAdapter.UpdateTamamlandi(IstekID);
                            GridDoldur(Istrue, false);
                            


                        }
                        else
                        {
                            MessageBox.Show("İşlem iptal edildi !");
                        }
                    }

                }

            }
        }



      

        private void GorevGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < GorevGrid.RowCount-1; i++)
            {

                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToBoolean(GorevGrid.Rows[i].Cells[6].Value) == true)
                {
                    renk.ForeColor = Color.BlueViolet;
                    renk.BackColor = Color.Yellow;

                }
                else
                {
                    renk.BackColor = Color.LightGray;
                    renk.ForeColor = Color.DarkBlue;
                }

                GorevGrid.Rows[i].DefaultCellStyle = renk; // Satırın stilini ayarlama

            }
        }


    }


}
