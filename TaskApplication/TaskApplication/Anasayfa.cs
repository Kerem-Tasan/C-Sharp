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
    public partial class Anasayfa : Form
    {
        public Guid id;
        public Anasayfa()
        {
            InitializeComponent();
        }
        public void Formgetir(Form frm)
        {
            Mdi_Panel.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            Mdi_Panel.Controls.Add(frm);

            frm.Show();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void dURToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            GorevSayfası GorevPage = new GorevSayfası();
            //GorevPage.YetkiID = KullanıcıBilgileri.KullaniciYetki ; 
            //GorevPage.id = id; 
            Formgetir(GorevPage);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kIslem=new KullaniciIslemleri();
            Formgetir(kIslem);
        }

        private void görevDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevLog gorevLog = new GorevLog(); 
            Formgetir(gorevLog);

        }
    }
}
