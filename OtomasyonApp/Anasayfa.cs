using OtomasyonApp.CardDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonApp
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        // DataSet ile sorgu çalıştırmak için table nesneleri üretiyoruz.
        datasetTableAdapters.KullanıcıDbTableAdapter dt = new datasetTableAdapters.KullanıcıDbTableAdapter();
        CardDBDataSetTableAdapters.HesapKartTipiTableAdapter Tipdt = new CardDBDataSetTableAdapters.HesapKartTipiTableAdapter();
        CardDBDataSetTableAdapters.HesapKartTuruTableAdapter Turdt = new HesapKartTuruTableAdapter();
        CardDBDataSetTableAdapters.HesapKartıDBTableAdapter HesapDt = new HesapKartıDBTableAdapter();
        CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter AltGrupdDT = new HesapAltGrupDbTableAdapter();
        CardDBDataSetTableAdapters.HesapGrupDBTableAdapter GrupDt = new HesapGrupDBTableAdapter();
        datasetTableAdapters.KullanıcıDbTableAdapter UserDT = new datasetTableAdapters.KullanıcıDbTableAdapter();
        CardDBDataSetTableAdapters.SehirlerTableAdapter sehirlerdt=new SehirlerTableAdapter();


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NU0IEU7\KEREMT;Initial Catalog=CardDB;Integrated Security=True");

        HesapKartUpdate update = new HesapKartUpdate();
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartıDB1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartıDBTableAdapter.Fill(this.cardDBDataSet.HesapKartıDB,false);
            // TODO: Bu kod satırı 'cardDBDataSet.ILCEDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.iLCEDBTableAdapter.Fill(this.cardDBDataSet.ILCEDB, false);
            // TODO: Bu kod satırı 'cardDBDataSet1.ilceDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'cardDBDataSet.ilceDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'cardDBDataSet.Sehirler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'dataset.KullanıcıDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıDbTableAdapter1.FillSelectPersonel(this.dataset.KullanıcıDb);
            // TODO: Bu kod satırı 'cardDBDataSet.KullanıcıDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
       //     this.kullanıcıDbTableAdapter.Fill(this.cardDBDataSet.KullanıcıDb);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapAltGrupDb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapAltGrupDbTableAdapter.FillBy(this.cardDBDataSet.HesapAltGrupDb,false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapGrupDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapGrupDBTableAdapter.FillBy2(this.cardDBDataSet.HesapGrupDB,false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTuruTableAdapter.Fill(this.cardDBDataSet.HesapKartTuru,false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartTipi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesapKartTipiTableAdapter.Fill(this.cardDBDataSet.HesapKartTipi, false);
            // TODO: Bu kod satırı 'cardDBDataSet.HesapKartıDB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.hesapKartıDBTableAdapter.Fill(this.cardDBDataSet.HesapKartıDB,false);
            this.sehirlerTableAdapter.Fill(this.cardDBDataSet.Sehirler);
        }
        
        void ilceLoad(bool IsDeleted)
        {
            iLCEDBTableAdapter.Fill(cardDBDataSet.ILCEDB, IsDeleted);
        }
        void sehirlerLoad(bool IsDeleted)
        {
            sehirlerTableAdapter.Fill(cardDBDataSet.Sehirler);
        }
        void CardLoad(bool IsDeleted)
        {
       hesapKartıDBTableAdapter.Fill(cardDBDataSet.HesapKartıDB,IsDeleted);
        }
        void KullaniciLoad(bool IsDeleted)
        {
            kullanıcıDbTableAdapter1.FillByLoadGrid(dataset.KullanıcıDb,false);
        }


        void AltGrupLoad(bool IsDeleted)
        {
            hesapAltGrupDbTableAdapter.FillBy(cardDBDataSet.HesapAltGrupDb,IsDeleted);
        }
       
        void TurLoad(bool IsDeleted)
        {
            hesapKartTuruTableAdapter.Fill(cardDBDataSet.HesapKartTuru,IsDeleted);
        }
        void TipLoad(bool IsDeleted)
        {
            hesapKartTipiTableAdapter.Fill(cardDBDataSet.HesapKartTipi,IsDeleted);
        }
        void Grupload(bool IsDeleted)
        {
            hesapGrupDBTableAdapter.FillBy2(cardDBDataSet.HesapGrupDB,IsDeleted);
        }
      
        private void TipEkle_btn_Click(object sender, EventArgs e)
        {
            TipekleGuncellePopUp tipeklePopUp = new TipekleGuncellePopUp();
            tipeklePopUp.TipekleGuncelleID = 0;
            if (tipeklePopUp.ShowDialog() == DialogResult.OK)
            {

                TipLoad(false);
                MessageBox.Show("kaydedildi!");
            }
            else
            {
                MessageBox.Show("Hata");

            }


        }
        public int TipSilGuncelleId { get; set; }

        // TİP SİLME KODU AYNI ZAMANDA HESAP KARTINDA Kİ TİPIDYİ 0 
        private void TipSil_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(TipSilGuncelleId + "'ye sahib Kart Tipini Silmek İstediğinize Emin Misiniz?","Silme Onayı" , MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                HesapDt.DeletedKartTypeUpdateForHesapKart(TipSilGuncelleId);
                Tipdt.UpdateDeletedType(TipSilGuncelleId);

                MessageBox.Show("Kart Tipi Başarıyla Silindi!");
                TipLoad(false);
            }
            else if (dialog==DialogResult.No)
            {
                MessageBox.Show("Kayıt Silinmedi!");
            }

        }


        public int kullaniciId;
        private void Tiptanim_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedindex = e.RowIndex;

            if (selectedindex >= 0)
            {
                kullaniciId = Convert.ToInt32(Tiptanim_grid.Rows[selectedindex].Cells["tipIdDataGridViewTextBoxColumn"].Value);
                TipSilGuncelleId = kullaniciId;

            }
        }

        private void TipGüncelle_btn_Click(object sender, EventArgs e)
        {



            DialogResult dialog = MessageBox.Show(TipSilGuncelleId + "'ye sahib Kart Tipini Güncellemek İstediğinize Emin Misiniz?","Silme Onayı" , MessageBoxButtons.YesNo);
            if (dialog == DialogResult.OK)
            {
                TipekleGuncellePopUp tipekleGuncellePopUp = new TipekleGuncellePopUp();
                tipekleGuncellePopUp.TipekleGuncelleID = kullaniciId;
                if (tipekleGuncellePopUp.ShowDialog() == DialogResult.Yes)
                {
                    MessageBox.Show("Güncellendi!");
                    TipLoad(false);
                }
                else if(tipekleGuncellePopUp.ShowDialog() == DialogResult.No) 
                {
                    MessageBox.Show("Kaydedilmedi!");
                }

                //MessageBox.Show("Kart Tipi Başarıyla Güncellendi!");
                //Tiptanim_grid.Refresh();
            }
            
        }
        public int TurKullaniciId;
        private void TurSil_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(TurKullaniciId + "'ID'ye sahip Kart Türünü Silmek İstediğinize Emin Misiniz?" , "Silme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                HesapDt.UpdateHesapKartForDeletedCardKind(TurKullaniciId);
                Turdt.DeleteByID(TurKullaniciId);

                MessageBox.Show("Kart Türü Başarıyla Silindi!");
                TurLoad(false);
            }
            else if(dialog==DialogResult.No)
            {
                MessageBox.Show("Kayıt Silinmedi!");
            }
        }

        private void TurGuncelle_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show(TurKullaniciId + "'ye sahib Kart Tipini Güncellemek İstediğinize Emin Misiniz?","Silme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                TurEkleGuncellePopUp turEkleGuncellePopUp = new TurEkleGuncellePopUp();
                turEkleGuncellePopUp.TurEkleGuncelleID = TurKullaniciId;
                if (turEkleGuncellePopUp.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Güncellendi!");
                    TurLoad(false);
                }
                else
                {
                
                    MessageBox.Show("Kaydedilmedi!");
                }

                //MessageBox.Show("Kart Tipi Başarıyla Güncellendi!");
                //Tiptanim_grid.Refresh();
            }
          
        }



        private void Tur_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int SelectedIndexOfTurId = e.RowIndex;

            if (SelectedIndexOfTurId >= 0)
            {


                TurKullaniciId = Convert.ToInt32(Tur_Grid.Rows[SelectedIndexOfTurId].Cells["TurGrid_ID"].Value);

            }
            

        }

        private void TurEkle_btn_Click(object sender, EventArgs e)
        {
            TurEkleGuncellePopUp turEkleGuncellePopUp = new TurEkleGuncellePopUp();

            turEkleGuncellePopUp.TurEkleGuncelleID = 0;
            if (turEkleGuncellePopUp.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("kaydedildi!");
                TurLoad(false);

            }
            else
            {
                MessageBox.Show("Hata");

            }

        }

        public int GrupTanimId;

      
        private void Grupsil_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogresult = MessageBox.Show(GrupTanimId + " ID'li Kayıtı silmek istediğinden emin misin?", "Silme Onayı", MessageBoxButtons.YesNo);
            HesapDt.UpdateHesapKartForDeletedGroup(GrupTanimId);
            AltGrupdDT.UpdateByDeletedGrupId(GrupTanimId);
            GrupDt.UpdateDeletedGrup(GrupTanimId);

            //HesapDt.UpdateHesapKartForDeletedCardKind(TurKullaniciId);
            //Turdt.DeleteByID(TurKullaniciId);

            MessageBox.Show("Kart Grubu Başarıyla Silindi!");
            Grupload(false);
        }

        private void GrupTanim_Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            GrupTanimId = Convert.ToInt32(GrupTanim_Grid.Rows[selectedRow].Cells["Grup_Tanim_Id"].Value);

        }

        private void Grupguncelle_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(GrupTanimId + "'ye sahib Kart Tipini Güncellemek İstediğinize Emin Misiniz?" + MessageBoxButtons.YesNo);
            if (dialog == DialogResult.OK)
            {
                GrupEkleGuncelle grupEkleGuncelle = new GrupEkleGuncelle();
                grupEkleGuncelle.GrupEkleGuncelleId = GrupTanimId;
                if (grupEkleGuncelle.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Güncellendi!");
                    Grupload(false);
                }
                else
                {
                    MessageBox.Show("Kaydedilmedi!");
                }

                //MessageBox.Show("Kart Tipi Başarıyla Güncellendi!");
                //Tiptanim_grid.Refresh();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi!");
                Grupload(false);
            }
        }

        private void GrupEkle_btn_Click(object sender, EventArgs e)
        {
            GrupEkleGuncelle grupEkleGuncelle = new GrupEkleGuncelle();
            grupEkleGuncelle.GrupEkleGuncelleId = 0;
            if (grupEkleGuncelle.ShowDialog() == DialogResult.OK)
            {


                MessageBox.Show("Kaydedildi!");
                Grupload(false);
            }
            else
            {
                MessageBox.Show("Kaydedilmedi!");
                Grupload(false);

            }
        }
        public int AltgrupId;
        private void AltGrup_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            AltgrupId = Convert.ToInt32(AltGrup_Grid.Rows[selectedIndex].Cells["AltGrupGrid_Name"].Value);

        }

        private void altgrupsil_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(AltgrupId + " ID'li Alt Grubu Silmek istiyor musunuz?","Silme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    HesapDt.UpdateHesapKartAltGrupId(AltgrupId);
                    AltGrupdDT.UpdateDeletedAltGrup(AltgrupId);
                    MessageBox.Show("Alt Grup Başarıyla Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AltGrupLoad(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Alt Grup Silinemedi!Hata:");
                    throw;
                }


            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }

        }

        private void AltGrup_Grid_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void AltGrup_Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            AltgrupId = Convert.ToInt32(AltGrup_Grid.Rows[selectedIndex].Cells["AltGrupGrid_Name"].Value);


        }

        private void altgrupgüncelle_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(AltgrupId + " ID'li kullanıcıyı güncellemek istiyor musunuz?","Silme Onayı",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                AltGroupEkleGuncelle altgrupGrud = new AltGroupEkleGuncelle();
                altgrupGrud.AltgrupID = AltgrupId;
                altgrupGrud.ShowDialog();
                altgrupGrud.DialogResult = DialogResult.OK;
                if (altgrupGrud.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Kullanıcı Başarıyla Güncellendi!");

                    AltGrupLoad(false);
                    //  AltgrupId = 0;
                }




            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Güncelleme iptal edildi!");
            }
        }

        private void Altgrupekle_btn_Click(object sender, EventArgs e)
        {
            AltGroupEkleGuncelle altgrupGrud = new AltGroupEkleGuncelle();
           
            altgrupGrud.ShowDialog();
            if (altgrupGrud.DialogResult == DialogResult.OK)
            {
                AltGrupLoad(false);
                //AltgrupId = 0;
            }
        }

        private void AltGrupTanimi_Tab_Click(object sender, EventArgs e)
        {

        }

        public int KullaniciGridId;
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            
            KullaniciGridId = Convert.ToInt32(Kullanici_Grid.Rows[selectedIndex].Cells["UserID"].Value);

        }

        private void Kullanici_Ekle_btn_Click(object sender, EventArgs e)
        {

            KullaniciEkleGuncellePopUp AddUser = new KullaniciEkleGuncellePopUp();
            AddUser.KullaniciRowID = KullaniciGridId;
            AddUser.ShowDialog();
            if (AddUser.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Kullanıcı Güncellendi!");
                KullaniciLoad(false);

            }




        }

        //Kullanıcı Kodları 


        private void Kullanici_Sil_btn_Click(object sender, EventArgs e)
        {
            DialogResult resılt = MessageBox.Show("Silme işlemini onaylıyor musunuz?","Silme Onayı", MessageBoxButtons.YesNo);

            if (resılt == DialogResult.OK)
            {
                UserDT.IsDeletedOneUserID(KullaniciGridId);
                MessageBox.Show("Kullanıcı Silindi!");
                KullaniciLoad(false);
            }
            else
            {
                MessageBox.Show("Silme İŞlemi Tamamlanamadı!");
            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_Guncelle_btn_Click(object sender, EventArgs e)
        {
            KullaniciEkleGuncellePopUp AddUser = new KullaniciEkleGuncellePopUp();
            AddUser.KullaniciRowID = KullaniciGridId;

            AddUser.ShowDialog();

            if (AddUser.DialogResult == DialogResult.OK)
            {
                KullaniciLoad(false);
                MessageBox.Show("Kullanıcı Güncellendi!");



            }
        }

        private void Anasayfa_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hesapAltGrupDbTableAdapter.FillBy(this.cardDBDataSet.HesapAltGrupDb, false);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.hesapGrupDBTableAdapter.Fill(this.cardDBDataSet.HesapGrupDB);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hesapGrupDBTableAdapter.FillBy2(this.cardDBDataSet.HesapGrupDB, false);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Gruptanimi_Tab_Click(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.hesapGrupDBTableAdapter.FillBy2(this.cardDBDataSet.HesapGrupDB,false);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TurtTanımı_Tab_Click(object sender, EventArgs e)
        {

        }

      
        public int cardID;
        private void CardAdd_btn_Click(object sender, EventArgs e)
        {
            CardAddUpdate cardAddUpdate = new CardAddUpdate();
            cardAddUpdate.cardID = 0;
            cardAddUpdate.ShowDialog();
            if (cardAddUpdate.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Ekleme İşlemi Tamamlandı!");
                CardLoad(false);
            }
        }

        private void CardGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            cardID = Convert.ToInt32(Card_Grid.Rows[selectedIndex].Cells["CardGrid_ID"].Value);
          
        }

        private void CardUpdate_btn_Click(object sender, EventArgs e)
        {
            CardAddUpdate cardAddUpdate = new CardAddUpdate();
            cardAddUpdate.cardID = cardID;
            cardAddUpdate.ShowDialog();
            if (cardAddUpdate.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Güncelleme İşlemi Tamamlandı!");
                CardLoad(false);

            }
        }

        private void CardDelete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show( cardID+ " ID'li kayıtı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNoCancel);
            if (dialog == DialogResult.Yes)
            {
                HesapDt.UpdateDeletedCard(cardID);
                MessageBox.Show("Kart Başarıyla silindi!");
                CardLoad(false);

            }
            else if (dialog == DialogResult.No || dialog == DialogResult.Cancel)
            {
                MessageBox.Show("Silme İşlemi Tamamlanmadı !");
                CardLoad(false);
            }


        }


        private void SilinenListesiAG__btn_Click(object sender, EventArgs e)
        {
  AltGrupLoad(true);
        }

        private void AktifListesiAG_btn_Click_1(object sender, EventArgs e)
        {
 AltGrupLoad(false);
        }

        private void KartPaneli_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grupload(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grupload(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurLoad(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurLoad(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TipLoad(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TipLoad(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KullaniciLoad(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KullaniciLoad(true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CardLoad(false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CardLoad(true);
        }
      

        // Şehir Anasayfa işlemleri
        public int sehirID;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex=e.RowIndex;
            sehirID = Convert.ToInt32(sehir_grid.Rows[selectedIndex].Cells["Sehir_ID"].Value);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            SehirEkleGuncelle sehirpopup=new SehirEkleGuncelle();
            sehirpopup.SehirID=0;
            sehirpopup.ShowDialog();
            sehirlerLoad(false);
        }

        private void sehirguncelle_btn_Click(object sender, EventArgs e)
        {
            SehirEkleGuncelle sehirguncelle = new SehirEkleGuncelle();
            sehirguncelle.SehirID=sehirID;
            sehirguncelle.ShowDialog();
            sehirlerLoad(false);
        }

        private void Sehirler_Click(object sender, EventArgs e)
        {

        }

        private void sehir_listele_Click(object sender, EventArgs e)
        {
            sehirlerLoad(false);
        }

        private void sehirsilinen_listele_Click(object sender, EventArgs e)
        {
            sehirlerLoad(true);
        }

        private void sehir_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(sehirID+" ID'li kullanıcıyı silmek istediğinize emin misiniz?","Silme Onayı",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sehirlerTableAdapter.UpdateDeletedSehir(sehirID);
                sehirlerLoad(false);
                MessageBox.Show("Kullanıcı Silindi !");
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi !");
            }
        }

       

        // ilçe kodları 
        public int IlceID;
        public int selectedRow;
        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow=e.RowIndex;
            IlceID =Convert.ToInt32(Ilce_grid.Rows[selectedRow].Cells["ılceIDDataGridViewTextBoxColumn"].Value);

        } private void button13_Click(object sender, EventArgs e)
        {
            //Silme İşlemi
            DialogResult dia = MessageBox.Show(IlceID+" ID'ye sahiP veriyi silmek istiyor musunuz?","Silme Onayı",MessageBoxButtons.OKCancel);

            if (dia == DialogResult.OK)
            {
                iLCEDBTableAdapter.UpdateDeletedIlce(IlceID);
                MessageBox.Show("Kayıt Başarıyla Silindi");
                ilceLoad(false);

            }
            else if(dia == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem İptal Edildi!");
            }
                
        }

        private void ilceliste_btn_Click(object sender, EventArgs e)
        {
            ilceLoad(false);
        }

        private void ilcesilinenliste_btn_Click(object sender, EventArgs e)
        {
            ilceLoad(true);
        }

        private void guncelleilce_btn_Click(object sender, EventArgs e)
        {
        DialogResult dia=MessageBox.Show(IlceID+" ıd'ye sahib ilçeyi güncellemek istiyor musunuz?","Güncelleme Onayı",MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
               ılcePopUp ılcepopup=new ılcePopUp();
                ılcepopup.IlceID=IlceID;
                ılcepopup.ShowDialog();
                if (ılcepopup.DialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("İşlem Başarıyla tamamlandı");
                    ilceLoad(false);
                }
            }
           
        }

        private void ilceEkle_btn_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Ekleme işlemini devam ettirmek istiyor musunuz?", "Ekleme Onayı", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                ılcePopUp ılcepopup = new ılcePopUp();
                ılcepopup.IlceID = 0;
                ılcepopup.ShowDialog();
                if (ılcepopup.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("İşlem Başarıyla tamamlandı");
                    ilceLoad(false);
                }
            }

        }

        private void CardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Card_Grid.Columns["reason"].Index && e.RowIndex >= 0)
            {
                string reas = Card_Grid.Rows[e.RowIndex].Cells["reason"].Value.ToString();
                MessageBox.Show("Silinme Sebebi :" + reas, "Silinme Sebebi",MessageBoxButtons.OK);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.hesapKartıDBTableAdapter.FillBy2(this.cardDBDataSet.HesapKartıDB, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(isDeletedToolStripTextBox.Text, typeof(bool))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
