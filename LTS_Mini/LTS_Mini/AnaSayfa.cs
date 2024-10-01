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
    public partial class AnaSayfa : Form
    {
        public int UserType;
        public AnaSayfa()
        {
            InitializeComponent();
            this.TopLevel = true;
         

            this.IsMdiContainer = true;
        }
        


        public void formGetir(Form frm)
        {
            MdiPanel.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            MdiPanel.Controls.Add(frm);

            frm.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void isteklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiBelirleme.IslemID = 0;
            menuStrip1.Visible = true;
            IstekIslemleri IstekIslemler=new IstekIslemleri();
            formGetir(IstekIslemler);
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false; 
            KullaniciIslemleri kullaniciIslemleri=new KullaniciIslemleri();
            formGetir(kullaniciIslemleri);
        }

        private void istekTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstekTanimlari ıstekTanimlari=new IstekTanimlari();
            formGetir(ıstekTanimlari);
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            IstekIslemleri ıstekIslemleri = new IstekIslemleri();
            ıstekIslemleri.UserTypeIslem = UserType;
        }

        private void yeniİstekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniIstek newReq = new YeniIstek();
            YetkiBelirleme.IslemID = 0;
            newReq.ShowDialog();
            if (newReq.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem TAMAMLANDI");
                
            }
            else
            {
                MessageBox.Show("İşlem Tamamlanamadı");
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniIstek newReq = new YeniIstek();
            newReq.ShowDialog();
            if (newReq.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("İşlem TAMAMLANDI");
            }
            else
            {
                MessageBox.Show("İşlem Tamamlanamadı");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (YetkiBelirleme.IslemID == 0)
            {

                MessageBox.Show("Silme İşlemi İçin Bir İstek Seçin (Mouse Right Click)");

            }
            else if (YetkiBelirleme.IslemID > 0)
            {

                InputForm ınputForm = new InputForm();
                ınputForm.IsTester = 6;
                ınputForm.IstekID = YetkiBelirleme.IslemID;
                ınputForm.ShowDialog();

                if (ınputForm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Silme işlemi başarıyla tamamlandı!");
                    
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Tamamlanmadı !");
                }

            }

        }

        private void istekTanımlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            IstekTanimlari tanimlar= new IstekTanimlari();
            formGetir(tanimlar);
        }
    }
}

