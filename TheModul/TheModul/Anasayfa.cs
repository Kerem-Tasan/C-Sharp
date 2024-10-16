using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheModul
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        void FormGetir(Form frm)
        {
            Mdi_Panel.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            Mdi_Panel.Controls.Add(frm);

            frm.Show();
        }
        private void modulIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulIslem MIslem = new ModulIslem();
            FormGetir(MIslem);

        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModulIcerik MIcerik = new ModulIcerik();
            FormGetir(MIcerik);

        }

        private void kılavuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kilavuz K=new Kilavuz();
            
            FormGetir(K);

        }

        private void kılavuzDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KilavuzLog Log=new KilavuzLog();
            Log.IsWhat = 1;
            Log.IsVisible = 0;
            FormGetir(Log);
        }

        private void şirketİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SirketSayfasi s_Page=new SirketSayfasi();   
            FormGetir(s_Page);
        }

        private void resimİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimSayfasi resimSayfasi = new ResimSayfasi();
            FormGetir(resimSayfasi);
        }
    }
}
