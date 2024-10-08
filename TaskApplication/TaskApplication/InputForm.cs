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
    public partial class InputForm : Form
    {
        public int IsWhat;
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            if (IsWhat == 1)
            {
                gorevLogTblTableAdapter1.UpdateOnay(true,OnayVerileri.YoneticiOnay,txt_Input.Text,"",OnayVerileri.GorevID);
               this.DialogResult = DialogResult.OK;
            }
            if (IsWhat == 2)
            {
                gorevLogTblTableAdapter1.UpdateOnay(true,true,OnayVerileri.KullaniciAciklama, txt_Input.Text, OnayVerileri.GorevID);

                this.DialogResult = DialogResult.OK;


            }
            if (IsWhat == 3)
            {
                //gorevLogTblTableAdapter1.UpdateOnay(true, true, OnayVerileri.KullaniciAciklama, txt_Input.Text, OnayVerileri.GorevID);
                gorevTblTableAdapter1.UpdateDeletedGorev(true,txt_Input.Text,OnayVerileri.GorevID);


                this.DialogResult = DialogResult.OK;

            }
            if (IsWhat == 4) {

                kullaniciTblTableAdapter1.UpdateDeletedKullanici(txt_Input.Text,OnayVerileri.KullaniciGridID);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
