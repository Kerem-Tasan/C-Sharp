namespace TheModul
{
    partial class ModelIcerikPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_IcerikAdi = new System.Windows.Forms.TextBox();
            this.modulIcerikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.lbl_IcerikAdi = new System.Windows.Forms.Label();
            this.mipp_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.lbl_ModulAdi = new System.Windows.Forms.Label();
            this.cmb_Modul = new System.Windows.Forms.ComboBox();
            this.bs_modul = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Modul = new TheModul.ModulDBDataSetTableAdapters.ModulTblTableAdapter();
            this.tbl_ModulIcerik = new TheModul.ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter();
            this.tbl_Kilavuz = new TheModul.ModulDBDataSetTableAdapters.KilavuzTblTableAdapter();
            this.lbl_ResimAdi = new System.Windows.Forms.Label();
            this.resimTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resimTblTableAdapter = new TheModul.ModulDBDataSetTableAdapters.ResimTblTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbl_resim = new TheModul.ModulDBDataSetTableAdapters.ResimTblTableAdapter();
            this.btn_ResimSec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modulIcerikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IcerikAdi
            // 
            this.txt_IcerikAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulIcerikBindingSource, "IcerikAdi", true));
            this.txt_IcerikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_IcerikAdi.Location = new System.Drawing.Point(190, 15);
            this.txt_IcerikAdi.Name = "txt_IcerikAdi";
            this.txt_IcerikAdi.Size = new System.Drawing.Size(164, 28);
            this.txt_IcerikAdi.TabIndex = 0;
            // 
            // modulIcerikBindingSource
            // 
            this.modulIcerikBindingSource.DataMember = "Modul_Icerik";
            this.modulIcerikBindingSource.DataSource = this.ds_modul;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_IcerikAdi
            // 
            this.lbl_IcerikAdi.AutoSize = true;
            this.lbl_IcerikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_IcerikAdi.Location = new System.Drawing.Point(74, 14);
            this.lbl_IcerikAdi.Name = "lbl_IcerikAdi";
            this.lbl_IcerikAdi.Size = new System.Drawing.Size(97, 24);
            this.lbl_IcerikAdi.TabIndex = 1;
            this.lbl_IcerikAdi.Text = "İçerik Adı :";
            // 
            // mipp_btn
            // 
            this.mipp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mipp_btn.Location = new System.Drawing.Point(210, 383);
            this.mipp_btn.Name = "mipp_btn";
            this.mipp_btn.Size = new System.Drawing.Size(74, 32);
            this.mipp_btn.TabIndex = 2;
            this.mipp_btn.Text = "Kaydet";
            this.mipp_btn.UseVisualStyleBackColor = true;
            this.mipp_btn.Click += new System.EventHandler(this.mipp_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "İçerik Açıklaması :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modulIcerikBindingSource, "IcerikAciklamasi", true));
            this.txt_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Aciklama.Location = new System.Drawing.Point(190, 76);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(164, 28);
            this.txt_Aciklama.TabIndex = 3;
            // 
            // lbl_ModulAdi
            // 
            this.lbl_ModulAdi.AutoSize = true;
            this.lbl_ModulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ModulAdi.Location = new System.Drawing.Point(60, 136);
            this.lbl_ModulAdi.Name = "lbl_ModulAdi";
            this.lbl_ModulAdi.Size = new System.Drawing.Size(111, 24);
            this.lbl_ModulAdi.TabIndex = 5;
            this.lbl_ModulAdi.Text = "Modül Adı  :";
            // 
            // cmb_Modul
            // 
            this.cmb_Modul.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modulIcerikBindingSource, "ModulID", true));
            this.cmb_Modul.DataSource = this.bs_modul;
            this.cmb_Modul.DisplayMember = "Adi";
            this.cmb_Modul.FormattingEnabled = true;
            this.cmb_Modul.Location = new System.Drawing.Point(190, 136);
            this.cmb_Modul.Name = "cmb_Modul";
            this.cmb_Modul.Size = new System.Drawing.Size(164, 24);
            this.cmb_Modul.TabIndex = 6;
            this.cmb_Modul.ValueMember = "ID";
            // 
            // bs_modul
            // 
            this.bs_modul.DataMember = "ModulTbl";
            this.bs_modul.DataSource = this.ds_modul;
            // 
            // tbl_Modul
            // 
            this.tbl_Modul.ClearBeforeFill = true;
            // 
            // tbl_ModulIcerik
            // 
            this.tbl_ModulIcerik.ClearBeforeFill = true;
            // 
            // tbl_Kilavuz
            // 
            this.tbl_Kilavuz.ClearBeforeFill = true;
            // 
            // lbl_ResimAdi
            // 
            this.lbl_ResimAdi.AutoSize = true;
            this.lbl_ResimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ResimAdi.Location = new System.Drawing.Point(8, 160);
            this.lbl_ResimAdi.Name = "lbl_ResimAdi";
            this.lbl_ResimAdi.Size = new System.Drawing.Size(73, 24);
            this.lbl_ResimAdi.TabIndex = 8;
            this.lbl_ResimAdi.Text = "Resim :";
            // 
            // resimTblBindingSource
            // 
            this.resimTblBindingSource.DataMember = "ResimTbl";
            this.resimTblBindingSource.DataSource = this.ds_modul;
            // 
            // resimTblTableAdapter
            // 
            this.resimTblTableAdapter.ClearBeforeFill = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(36, 36);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(517, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 403);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // tbl_resim
            // 
            this.tbl_resim.ClearBeforeFill = true;
            // 
            // btn_ResimSec
            // 
            this.btn_ResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ResimSec.Location = new System.Drawing.Point(12, 379);
            this.btn_ResimSec.Name = "btn_ResimSec";
            this.btn_ResimSec.Size = new System.Drawing.Size(98, 40);
            this.btn_ResimSec.TabIndex = 14;
            this.btn_ResimSec.Text = "Resim Seç";
            this.btn_ResimSec.UseVisualStyleBackColor = true;
            this.btn_ResimSec.Click += new System.EventHandler(this.btn_ResimSec_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 148);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(290, 383);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(63, 32);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // ModelIcerikPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 445);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ResimSec);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_ResimAdi);
            this.Controls.Add(this.cmb_Modul);
            this.Controls.Add(this.lbl_ModulAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.mipp_btn);
            this.Controls.Add(this.lbl_IcerikAdi);
            this.Controls.Add(this.txt_IcerikAdi);
            this.Name = "ModelIcerikPopUp";
            this.Text = "ModelIcerikPopUp";
            this.Load += new System.EventHandler(this.ModelIcerikPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modulIcerikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IcerikAdi;
        private System.Windows.Forms.Label lbl_IcerikAdi;
        private System.Windows.Forms.Button mipp_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label lbl_ModulAdi;
        private System.Windows.Forms.ComboBox cmb_Modul;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_modul;
        private ModulDBDataSetTableAdapters.ModulTblTableAdapter tbl_Modul;
        private ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter tbl_ModulIcerik;
        private System.Windows.Forms.BindingSource modulIcerikBindingSource;
        private ModulDBDataSetTableAdapters.KilavuzTblTableAdapter tbl_Kilavuz;
        private System.Windows.Forms.Label lbl_ResimAdi;
        private System.Windows.Forms.BindingSource resimTblBindingSource;
        private ModulDBDataSetTableAdapters.ResimTblTableAdapter resimTblTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listView1;
        private ModulDBDataSetTableAdapters.ResimTblTableAdapter tbl_resim;
        private System.Windows.Forms.Button btn_ResimSec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Sil;
    }
}