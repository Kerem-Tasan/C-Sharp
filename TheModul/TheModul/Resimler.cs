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
    public partial class Resimler : Form
    {
        public Guid ID;
        public Resimler()
        {
            InitializeComponent();
        }

        private void Resimler_Load(object sender, EventArgs e)
        {
            var row = tbl_resim.GetDataByIcerikID(ID);

            if (row.Rows.Count > 0)
            {
                ımageList1.Images.Clear();
                listView1.Items.Clear();

                ımageList1.ColorDepth = ColorDepth.Depth32Bit;
                ımageList1.ImageSize = new Size(120, 125); 
                listView1.View = View.LargeIcon; 
                listView1.LargeImageList = ımageList1; 

                int i = 0;
                foreach (DataRow dr in row.Rows)
                {
                    byte[] imageData = (byte[])row.Rows[i]["Resim"]; 

                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image img = Image.FromStream(ms, true, true); 
                        ımageList1.Images.Add(img); 
                    }

                    i++;
                }
                for (int j = 0; j < ımageList1.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem
                    {
                        ImageIndex = j 
                    };

                    listView1.Items.Add(item); 
                }
            }


        }
    }
}
