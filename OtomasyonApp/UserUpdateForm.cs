using OtomasyonApp.CardDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonApp
{
    public partial class UserUpdateForm : Form
    {
        public int UpdateID { get; set; }
        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            kullanıcıDbTable.İdyegöreKullanıcı(ds.KullanıcıDb,UpdateID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           bs.EndEdit();
            kullanıcıDbTable.Update(ds.KullanıcıDb);


         
        }
    }
}
