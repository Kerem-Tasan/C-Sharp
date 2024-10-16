namespace TheModul
{
    partial class ResimPopUp
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
            this.lbl_resimAdi = new System.Windows.Forms.Label();
            this.txt_resim = new System.Windows.Forms.TextBox();
            this.bs_resim = new System.Windows.Forms.BindingSource(this.components);
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.rpp_btn = new System.Windows.Forms.Button();
            this.btn_Resimsec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ResimYolu = new System.Windows.Forms.TextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbl_resim = new TheModul.ModulDBDataSetTableAdapters.ResimTblTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modulIcerikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modul_IcerikTableAdapter = new TheModul.ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulIcerikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_resimAdi
            // 
            this.lbl_resimAdi.AutoSize = true;
            this.lbl_resimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_resimAdi.Location = new System.Drawing.Point(12, 71);
            this.lbl_resimAdi.Name = "lbl_resimAdi";
            this.lbl_resimAdi.Size = new System.Drawing.Size(106, 24);
            this.lbl_resimAdi.TabIndex = 24;
            this.lbl_resimAdi.Text = "Resim Adı :";
            // 
            // txt_resim
            // 
            this.txt_resim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_resim, "Adi", true));
            this.txt_resim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_resim.Location = new System.Drawing.Point(146, 68);
            this.txt_resim.Name = "txt_resim";
            this.txt_resim.Size = new System.Drawing.Size(164, 28);
            this.txt_resim.TabIndex = 23;
            // 
            // bs_resim
            // 
            this.bs_resim.DataMember = "ResimTbl";
            this.bs_resim.DataSource = this.ds_modul;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpp_btn
            // 
            this.rpp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rpp_btn.Location = new System.Drawing.Point(164, 245);
            this.rpp_btn.Name = "rpp_btn";
            this.rpp_btn.Size = new System.Drawing.Size(103, 32);
            this.rpp_btn.TabIndex = 22;
            this.rpp_btn.Text = "Kaydet";
            this.rpp_btn.UseVisualStyleBackColor = true;
            this.rpp_btn.Click += new System.EventHandler(this.rpp_btn_Click);
            // 
            // btn_Resimsec
            // 
            this.btn_Resimsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Resimsec.Location = new System.Drawing.Point(316, 127);
            this.btn_Resimsec.Name = "btn_Resimsec";
            this.btn_Resimsec.Size = new System.Drawing.Size(37, 28);
            this.btn_Resimsec.TabIndex = 21;
            this.btn_Resimsec.Text = "...";
            this.btn_Resimsec.UseVisualStyleBackColor = true;
            this.btn_Resimsec.Click += new System.EventHandler(this.btn_Resimsec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Resim Seç :";
            // 
            // txt_ResimYolu
            // 
            this.txt_ResimYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ResimYolu.Location = new System.Drawing.Point(146, 126);
            this.txt_ResimYolu.Name = "txt_ResimYolu";
            this.txt_ResimYolu.Size = new System.Drawing.Size(164, 28);
            this.txt_ResimYolu.TabIndex = 18;
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // tbl_resim
            // 
            this.tbl_resim.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "İçerik Adı :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_resim, "IcerikID", true));
            this.comboBox1.DataSource = this.modulIcerikBindingSource;
            this.comboBox1.DisplayMember = "IcerikAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ID";
            // 
            // modulIcerikBindingSource
            // 
            this.modulIcerikBindingSource.DataMember = "Modul_Icerik";
            this.modulIcerikBindingSource.DataSource = this.ds_modul;
            // 
            // modul_IcerikTableAdapter
            // 
            this.modul_IcerikTableAdapter.ClearBeforeFill = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(359, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 485);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 283);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 164);
            this.listBox1.TabIndex = 29;
            // 
            // ResimPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 508);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resimAdi);
            this.Controls.Add(this.txt_resim);
            this.Controls.Add(this.rpp_btn);
            this.Controls.Add(this.btn_Resimsec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ResimYolu);
            this.Name = "ResimPopUp";
            this.Text = "ResimPopUp";
            this.Load += new System.EventHandler(this.ResimPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulIcerikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resimAdi;
        private System.Windows.Forms.TextBox txt_resim;
        private System.Windows.Forms.Button rpp_btn;
        private System.Windows.Forms.Button btn_Resimsec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ResimYolu;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_resim;
        private ModulDBDataSetTableAdapters.ResimTblTableAdapter tbl_resim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modulIcerikBindingSource;
        private ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter modul_IcerikTableAdapter;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}