namespace OtubusBiletSatisOtomasyonu
{
    partial class AnaSayfa
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
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.gBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gBoxBiletBilgileri = new System.Windows.Forms.GroupBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblVarisSaati = new System.Windows.Forms.Label();
            this.mtbTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblVaris = new System.Windows.Forms.Label();
            this.lblBinisSaati = new System.Windows.Forms.Label();
            this.mkdVarisSaati = new System.Windows.Forms.MaskedTextBox();
            this.lblBinis = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mkdBinisSaati = new System.Windows.Forms.MaskedTextBox();
            this.cmbVarisYeri = new System.Windows.Forms.ComboBox();
            this.cmbKoltukNo = new System.Windows.Forms.ComboBox();
            this.cmbBinisYeri = new System.Windows.Forms.ComboBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnBiletGuncelle = new System.Windows.Forms.Button();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.btnRadyo = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.gBoxMusteriBilgileri.SuspendLayout();
            this.gBoxBiletBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSoyad.Location = new System.Drawing.Point(670, 141);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(0, 20);
            this.lblSoyad.TabIndex = 9;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAd.Location = new System.Drawing.Point(573, 141);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 20);
            this.lblAd.TabIndex = 8;
            // 
            // gBoxMusteriBilgileri
            // 
            this.gBoxMusteriBilgileri.Controls.Add(this.lblAdres);
            this.gBoxMusteriBilgileri.Controls.Add(this.lblPosta);
            this.gBoxMusteriBilgileri.Controls.Add(this.lblTel);
            this.gBoxMusteriBilgileri.Controls.Add(this.lblSoyisim);
            this.gBoxMusteriBilgileri.Controls.Add(this.lblAdi);
            this.gBoxMusteriBilgileri.Controls.Add(this.mtbTelefon);
            this.gBoxMusteriBilgileri.Controls.Add(this.txtAdres);
            this.gBoxMusteriBilgileri.Controls.Add(this.txtPosta);
            this.gBoxMusteriBilgileri.Controls.Add(this.txtSoyad);
            this.gBoxMusteriBilgileri.Controls.Add(this.txtAd);
            this.gBoxMusteriBilgileri.Location = new System.Drawing.Point(30, 57);
            this.gBoxMusteriBilgileri.Name = "gBoxMusteriBilgileri";
            this.gBoxMusteriBilgileri.Size = new System.Drawing.Size(298, 274);
            this.gBoxMusteriBilgileri.TabIndex = 10;
            this.gBoxMusteriBilgileri.TabStop = false;
            this.gBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(27, 221);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(60, 24);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres";
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(10, 180);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(77, 24);
            this.lblPosta.TabIndex = 3;
            this.lblPosta.Text = "E-Posta";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(10, 135);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(77, 24);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefon";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(23, 88);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(64, 24);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "Soyad";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(54, 44);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(33, 24);
            this.lblAdi.TabIndex = 2;
            this.lblAdi.Text = "Ad";
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(120, 135);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(138, 32);
            this.mtbTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(119, 218);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 45);
            this.txtAdres.TabIndex = 4;
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(120, 172);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(138, 32);
            this.txtPosta.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(138, 32);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(138, 32);
            this.txtAd.TabIndex = 0;
            // 
            // gBoxBiletBilgileri
            // 
            this.gBoxBiletBilgileri.Controls.Add(this.lblCinsiyet);
            this.gBoxBiletBilgileri.Controls.Add(this.lblFiyat);
            this.gBoxBiletBilgileri.Controls.Add(this.txtFiyat);
            this.gBoxBiletBilgileri.Controls.Add(this.lblKoltukNo);
            this.gBoxBiletBilgileri.Controls.Add(this.lblTarih);
            this.gBoxBiletBilgileri.Controls.Add(this.lblVarisSaati);
            this.gBoxBiletBilgileri.Controls.Add(this.mtbTarih);
            this.gBoxBiletBilgileri.Controls.Add(this.lblVaris);
            this.gBoxBiletBilgileri.Controls.Add(this.lblBinisSaati);
            this.gBoxBiletBilgileri.Controls.Add(this.mkdVarisSaati);
            this.gBoxBiletBilgileri.Controls.Add(this.lblBinis);
            this.gBoxBiletBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gBoxBiletBilgileri.Controls.Add(this.mkdBinisSaati);
            this.gBoxBiletBilgileri.Controls.Add(this.cmbVarisYeri);
            this.gBoxBiletBilgileri.Controls.Add(this.cmbKoltukNo);
            this.gBoxBiletBilgileri.Controls.Add(this.cmbBinisYeri);
            this.gBoxBiletBilgileri.Location = new System.Drawing.Point(362, 57);
            this.gBoxBiletBilgileri.Name = "gBoxBiletBilgileri";
            this.gBoxBiletBilgileri.Size = new System.Drawing.Size(745, 274);
            this.gBoxBiletBilgileri.TabIndex = 0;
            this.gBoxBiletBilgileri.TabStop = false;
            this.gBoxBiletBilgileri.Text = "Bilet Bilgileri";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(376, 223);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(80, 24);
            this.lblCinsiyet.TabIndex = 18;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(400, 166);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(53, 24);
            this.lblFiyat.TabIndex = 17;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(481, 163);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(140, 32);
            this.txtFiyat.TabIndex = 6;
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(360, 100);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(96, 24);
            this.lblKoltukNo.TabIndex = 16;
            this.lblKoltukNo.Text = "Koltuk No";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(400, 37);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(56, 24);
            this.lblTarih.TabIndex = 15;
            this.lblTarih.Text = "Tarih";
            // 
            // lblVarisSaati
            // 
            this.lblVarisSaati.AutoSize = true;
            this.lblVarisSaati.Location = new System.Drawing.Point(20, 224);
            this.lblVarisSaati.Name = "lblVarisSaati";
            this.lblVarisSaati.Size = new System.Drawing.Size(105, 24);
            this.lblVarisSaati.TabIndex = 14;
            this.lblVarisSaati.Text = "Varış Saati";
            // 
            // mtbTarih
            // 
            this.mtbTarih.Location = new System.Drawing.Point(481, 34);
            this.mtbTarih.Mask = "00/00/0000";
            this.mtbTarih.Name = "mtbTarih";
            this.mtbTarih.Size = new System.Drawing.Size(140, 32);
            this.mtbTarih.TabIndex = 4;
            this.mtbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblVaris
            // 
            this.lblVaris.AutoSize = true;
            this.lblVaris.Location = new System.Drawing.Point(30, 166);
            this.lblVaris.Name = "lblVaris";
            this.lblVaris.Size = new System.Drawing.Size(95, 24);
            this.lblVaris.TabIndex = 13;
            this.lblVaris.Text = "Varış Yeri";
            // 
            // lblBinisSaati
            // 
            this.lblBinisSaati.AutoSize = true;
            this.lblBinisSaati.Location = new System.Drawing.Point(22, 106);
            this.lblBinisSaati.Name = "lblBinisSaati";
            this.lblBinisSaati.Size = new System.Drawing.Size(103, 24);
            this.lblBinisSaati.TabIndex = 5;
            this.lblBinisSaati.Text = "Binis Saati";
            // 
            // mkdVarisSaati
            // 
            this.mkdVarisSaati.Location = new System.Drawing.Point(150, 221);
            this.mkdVarisSaati.Mask = "00:00";
            this.mkdVarisSaati.Name = "mkdVarisSaati";
            this.mkdVarisSaati.Size = new System.Drawing.Size(165, 32);
            this.mkdVarisSaati.TabIndex = 3;
            this.mkdVarisSaati.ValidatingType = typeof(System.DateTime);
            // 
            // lblBinis
            // 
            this.lblBinis.AutoSize = true;
            this.lblBinis.Location = new System.Drawing.Point(32, 42);
            this.lblBinis.Name = "lblBinis";
            this.lblBinis.Size = new System.Drawing.Size(93, 24);
            this.lblBinis.TabIndex = 4;
            this.lblBinis.Text = "Binis Yeri";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(481, 220);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(140, 32);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // mkdBinisSaati
            // 
            this.mkdBinisSaati.Location = new System.Drawing.Point(150, 103);
            this.mkdBinisSaati.Mask = "00:00";
            this.mkdBinisSaati.Name = "mkdBinisSaati";
            this.mkdBinisSaati.Size = new System.Drawing.Size(165, 32);
            this.mkdBinisSaati.TabIndex = 1;
            this.mkdBinisSaati.ValidatingType = typeof(System.DateTime);
            // 
            // cmbVarisYeri
            // 
            this.cmbVarisYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarisYeri.FormattingEnabled = true;
            this.cmbVarisYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbVarisYeri.Location = new System.Drawing.Point(150, 163);
            this.cmbVarisYeri.Name = "cmbVarisYeri";
            this.cmbVarisYeri.Size = new System.Drawing.Size(165, 32);
            this.cmbVarisYeri.TabIndex = 2;
            // 
            // cmbKoltukNo
            // 
            this.cmbKoltukNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoltukNo.FormattingEnabled = true;
            this.cmbKoltukNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbKoltukNo.Location = new System.Drawing.Point(481, 97);
            this.cmbKoltukNo.Name = "cmbKoltukNo";
            this.cmbKoltukNo.Size = new System.Drawing.Size(140, 32);
            this.cmbKoltukNo.TabIndex = 5;
            // 
            // cmbBinisYeri
            // 
            this.cmbBinisYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBinisYeri.FormattingEnabled = true;
            this.cmbBinisYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbBinisYeri.Location = new System.Drawing.Point(150, 39);
            this.cmbBinisYeri.Name = "cmbBinisYeri";
            this.cmbBinisYeri.Size = new System.Drawing.Size(165, 32);
            this.cmbBinisYeri.TabIndex = 1;
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Location = new System.Drawing.Point(1123, 178);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(172, 59);
            this.btnBiletSat.TabIndex = 12;
            this.btnBiletSat.Text = "Bilet Şatış";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // btnBiletGuncelle
            // 
            this.btnBiletGuncelle.Location = new System.Drawing.Point(1123, 261);
            this.btnBiletGuncelle.Name = "btnBiletGuncelle";
            this.btnBiletGuncelle.Size = new System.Drawing.Size(172, 59);
            this.btnBiletGuncelle.TabIndex = 0;
            this.btnBiletGuncelle.Text = "Bilet Güncelle";
            this.btnBiletGuncelle.UseVisualStyleBackColor = true;
            this.btnBiletGuncelle.Click += new System.EventHandler(this.btnBiletGuncelle_Click);
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.Location = new System.Drawing.Point(1345, 178);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(172, 59);
            this.btnBiletİptal.TabIndex = 12;
            this.btnBiletİptal.Text = "Bilet İptal";
            this.btnBiletİptal.UseVisualStyleBackColor = true;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // btnRadyo
            // 
            this.btnRadyo.Location = new System.Drawing.Point(1345, 261);
            this.btnRadyo.Name = "btnRadyo";
            this.btnRadyo.Size = new System.Drawing.Size(172, 59);
            this.btnRadyo.TabIndex = 12;
            this.btnRadyo.Text = "Radyo Dinle";
            this.btnRadyo.UseVisualStyleBackColor = true;
            this.btnRadyo.Click += new System.EventHandler(this.btnRadyo_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(1348, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(172, 59);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1532, 201);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(127, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 24);
            this.lblName.TabIndex = 14;
            this.lblName.Text = ".";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(206, 12);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(16, 24);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(1123, 12);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(172, 59);
            this.btnRapor.TabIndex = 16;
            this.btnRapor.Text = "Raporlama";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(1123, 94);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(172, 67);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1532, 561);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRadyo);
            this.Controls.Add(this.btnBiletGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBiletİptal);
            this.Controls.Add(this.btnBiletSat);
            this.Controls.Add(this.gBoxBiletBilgileri);
            this.Controls.Add(this.gBoxMusteriBilgileri);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.gBoxMusteriBilgileri.ResumeLayout(false);
            this.gBoxMusteriBilgileri.PerformLayout();
            this.gBoxBiletBilgileri.ResumeLayout(false);
            this.gBoxBiletBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox gBoxMusteriBilgileri;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.GroupBox gBoxBiletBilgileri;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblVarisSaati;
        private System.Windows.Forms.MaskedTextBox mtbTarih;
        private System.Windows.Forms.Label lblVaris;
        private System.Windows.Forms.Label lblBinisSaati;
        private System.Windows.Forms.MaskedTextBox mkdVarisSaati;
        private System.Windows.Forms.Label lblBinis;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mkdBinisSaati;
        private System.Windows.Forms.ComboBox cmbVarisYeri;
        private System.Windows.Forms.ComboBox cmbBinisYeri;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Button btnBiletGuncelle;
        private System.Windows.Forms.Button btnBiletİptal;
        private System.Windows.Forms.Button btnRadyo;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbKoltukNo;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnTemizle;
    }
}

