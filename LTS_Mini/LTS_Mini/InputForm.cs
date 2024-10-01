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
    public partial class InputForm : Form
    {
        public int IstekID;

        public int IsTester;
        //true Tester False yazılımcı güncelleme
        public InputForm()
        {
            InitializeComponent();
        }
        _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter adapter1=new _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter();
        
        private void InpuT_btn_Click(object sender, EventArgs e)
        {
            if (IsTester == 1)
            {

                if (string.IsNullOrEmpty(Input_txt.Text) == true)
                {
                    MessageBox.Show("Lütfen Açıklamayı Boş Bırakmayın!!");
                }
                else
                {
                    adapter1.UpdateYazilimciAciklama(Input_txt.Text, IstekID);
                    IstekID = 0;
                    MessageBox.Show("Yazılımcı açıklaması değişti");
                }
            }
            else if (IsTester == 2)
            {

                if (string.IsNullOrEmpty(Input_txt.Text) == true)
                {
                    MessageBox.Show("Lütfen Açıklamayı Boş Bırakmayın!!");
                }
                else
                {
                    adapter1.UpdateTesterAciklama(Input_txt.Text, IstekID);
                    IstekID = 0;
                    MessageBox.Show("Tester açıklaması değişti");
                }
                this.Close();

            }
            else if (IsTester == 3)
            {
                //     Input_txt.Text
                if (string.IsNullOrEmpty(Input_txt.Text))
                {
                    MessageBox.Show("Lütfen Açıklamayı Boş Bırakmayın!!");
                }
                else
                {
                    adapter1.UpdateYoneticiAciklama(Input_txt.Text, IstekID);
                    IstekID = 0;
                    MessageBox.Show("Yönetici açıklaması değişti");
                }
                this.Close();

            }
            else if (IsTester == 4)
            {
                Input_lbl.Text = "Silinme Nedeni : ";
                InpuT_btn.Text = "Kaydet";

                kullaniciTableAdapter.UpdateDeletedQuery(Input_txt.Text, IstekID);
                this.DialogResult = DialogResult.OK;
                IstekID = 0;
                this.Close();
            }
            else if (IsTester == 5)
            {
                istekKategoriTableAdapter.UpdateWithD(true, Input_txt.Text, IstekID);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (IsTester == 6)
            {
               istekTbl1TableAdapter.UpdateWithD(true, Input_txt.Text, IstekID);
                this.DialogResult = DialogResult.OK;
                IstekID = 0;
                this.Close();
            }



        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(IsTester.ToString());
            if (IsTester == 4)
            {
                Input_lbl.Text = "Silinme Nedeni : ";
                InpuT_btn.Text = "Kaydet";

            }
            else if (IsTester == 5)
            {
                Input_lbl.Text = "Silinme Nedeni : ";
                InpuT_btn.Text = "Kaydet";
            }

            //Input_txt.Text = YetkiBelirleme.mesaj;
        }
    }
}
