
namespace WindowsFormsApp1
{
    partial class UC_Personel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sube = new System.Windows.Forms.ComboBox();
            this.telNO2 = new System.Windows.Forms.TextBox();
            this.telNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.persongorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.personelsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personeladi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.adres2 = new System.Windows.Forms.TextBox();
            this.adres1 = new System.Windows.Forms.TextBox();
            this.filtrele = new System.Windows.Forms.Button();
            this.cins = new System.Windows.Forms.ComboBox();
            this.cikar = new System.Windows.Forms.Button();
            this.depart = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poz = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.TextBox();
            this.maastext = new System.Windows.Forms.Label();
            this.düzenle = new System.Windows.Forms.Button();
            this.onayla = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sube
            // 
            this.sube.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sube.FormattingEnabled = true;
            this.sube.Location = new System.Drawing.Point(240, 162);
            this.sube.Margin = new System.Windows.Forms.Padding(4);
            this.sube.Name = "sube";
            this.sube.Size = new System.Drawing.Size(243, 24);
            this.sube.TabIndex = 36;
            this.sube.SelectedIndexChanged += new System.EventHandler(this.sube_SelectedIndexChanged);
            // 
            // telNO2
            // 
            this.telNO2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.telNO2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telNO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNO2.ForeColor = System.Drawing.Color.Transparent;
            this.telNO2.Location = new System.Drawing.Point(693, 188);
            this.telNO2.Margin = new System.Windows.Forms.Padding(4);
            this.telNO2.Name = "telNO2";
            this.telNO2.Size = new System.Drawing.Size(243, 16);
            this.telNO2.TabIndex = 35;
            // 
            // telNO
            // 
            this.telNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.telNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNO.ForeColor = System.Drawing.Color.Transparent;
            this.telNO.Location = new System.Drawing.Point(693, 165);
            this.telNO.Margin = new System.Windows.Forms.Padding(4);
            this.telNO.Name = "telNO";
            this.telNO.Size = new System.Drawing.Size(243, 16);
            this.telNO.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(510, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telefon Numarası*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(61, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Şube";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(89, 346);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 308);
            this.dataGridView1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(93, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Personeller";
            // 
            // persongorButton
            // 
            this.persongorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.persongorButton.FlatAppearance.BorderSize = 0;
            this.persongorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persongorButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.persongorButton.ForeColor = System.Drawing.Color.Transparent;
            this.persongorButton.Location = new System.Drawing.Point(528, 85);
            this.persongorButton.Margin = new System.Windows.Forms.Padding(4);
            this.persongorButton.Name = "persongorButton";
            this.persongorButton.Size = new System.Drawing.Size(239, 44);
            this.persongorButton.TabIndex = 28;
            this.persongorButton.Text = "Personelleri Görüntüle";
            this.persongorButton.UseVisualStyleBackColor = false;
            this.persongorButton.Click += new System.EventHandler(this.PersongorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Personel Cinsiyeti";
            // 
            // personelsoyad
            // 
            this.personelsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.personelsoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personelsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelsoyad.ForeColor = System.Drawing.Color.Transparent;
            this.personelsoyad.Location = new System.Drawing.Point(241, 63);
            this.personelsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.personelsoyad.Name = "personelsoyad";
            this.personelsoyad.Size = new System.Drawing.Size(243, 16);
            this.personelsoyad.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personel Soyadı";
            // 
            // personeladi
            // 
            this.personeladi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.personeladi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personeladi.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.personeladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personeladi.ForeColor = System.Drawing.Color.Transparent;
            this.personeladi.Location = new System.Drawing.Point(241, 27);
            this.personeladi.Margin = new System.Windows.Forms.Padding(4);
            this.personeladi.Name = "personeladi";
            this.personeladi.Size = new System.Drawing.Size(243, 16);
            this.personeladi.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Personel Adı";
            // 
            // personelekle
            // 
            this.personelekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.personelekle.FlatAppearance.BorderSize = 0;
            this.personelekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelekle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personelekle.Location = new System.Drawing.Point(528, 26);
            this.personelekle.Margin = new System.Windows.Forms.Padding(4);
            this.personelekle.Name = "personelekle";
            this.personelekle.Size = new System.Drawing.Size(239, 44);
            this.personelekle.TabIndex = 21;
            this.personelekle.Text = "Personel Ekle";
            this.personelekle.UseVisualStyleBackColor = false;
            this.personelekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(513, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Personel Adresi";
            // 
            // adres2
            // 
            this.adres2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.adres2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres2.ForeColor = System.Drawing.Color.Transparent;
            this.adres2.Location = new System.Drawing.Point(693, 258);
            this.adres2.Margin = new System.Windows.Forms.Padding(4);
            this.adres2.Name = "adres2";
            this.adres2.Size = new System.Drawing.Size(243, 16);
            this.adres2.TabIndex = 39;
            // 
            // adres1
            // 
            this.adres1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.adres1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres1.ForeColor = System.Drawing.Color.Transparent;
            this.adres1.Location = new System.Drawing.Point(693, 235);
            this.adres1.Margin = new System.Windows.Forms.Padding(4);
            this.adres1.Name = "adres1";
            this.adres1.Size = new System.Drawing.Size(243, 16);
            this.adres1.TabIndex = 38;
            // 
            // filtrele
            // 
            this.filtrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.filtrele.FlatAppearance.BorderSize = 0;
            this.filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrele.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtrele.Location = new System.Drawing.Point(775, 85);
            this.filtrele.Margin = new System.Windows.Forms.Padding(4);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(132, 44);
            this.filtrele.TabIndex = 40;
            this.filtrele.Text = "Filtrele";
            this.filtrele.UseVisualStyleBackColor = false;
            // 
            // cins
            // 
            this.cins.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cins.FormattingEnabled = true;
            this.cins.Location = new System.Drawing.Point(241, 91);
            this.cins.Margin = new System.Windows.Forms.Padding(4);
            this.cins.Name = "cins";
            this.cins.Size = new System.Drawing.Size(115, 24);
            this.cins.TabIndex = 41;
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.Color.Brown;
            this.cikar.FlatAppearance.BorderSize = 0;
            this.cikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikar.Location = new System.Drawing.Point(775, 27);
            this.cikar.Margin = new System.Windows.Forms.Padding(4);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(132, 44);
            this.cikar.TabIndex = 42;
            this.cikar.Text = "Çıkar";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // depart
            // 
            this.depart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.depart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.depart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depart.FormattingEnabled = true;
            this.depart.Location = new System.Drawing.Point(240, 196);
            this.depart.Margin = new System.Windows.Forms.Padding(4);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(243, 24);
            this.depart.TabIndex = 44;
            this.depart.SelectedIndexChanged += new System.EventHandler(this.depart_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(60, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Departman";
            // 
            // poz
            // 
            this.poz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.poz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.poz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.poz.FormattingEnabled = true;
            this.poz.Location = new System.Drawing.Point(240, 229);
            this.poz.Margin = new System.Windows.Forms.Padding(4);
            this.poz.Name = "poz";
            this.poz.Size = new System.Drawing.Size(243, 24);
            this.poz.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(60, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Pozisyon";
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dogumtarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dogumtarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dogumtarihi.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dogumtarihi.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dogumtarihi.CustomFormat = "dd - MM - yyyy";
            this.dogumtarihi.Location = new System.Drawing.Point(240, 130);
            this.dogumtarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(243, 22);
            this.dogumtarihi.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(60, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 48;
            this.label10.Text = "Doğum Tarihi";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // maas
            // 
            this.maas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.maas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maas.ForeColor = System.Drawing.Color.Transparent;
            this.maas.Location = new System.Drawing.Point(241, 268);
            this.maas.Margin = new System.Windows.Forms.Padding(4);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(243, 16);
            this.maas.TabIndex = 52;
            // 
            // maastext
            // 
            this.maastext.AutoSize = true;
            this.maastext.BackColor = System.Drawing.Color.Transparent;
            this.maastext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maastext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maastext.Location = new System.Drawing.Point(60, 265);
            this.maastext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maastext.Name = "maastext";
            this.maastext.Size = new System.Drawing.Size(47, 18);
            this.maastext.TabIndex = 51;
            this.maastext.Text = "Maaş";
            // 
            // düzenle
            // 
            this.düzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.düzenle.FlatAppearance.BorderSize = 0;
            this.düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.düzenle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.düzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.düzenle.Location = new System.Drawing.Point(816, 346);
            this.düzenle.Margin = new System.Windows.Forms.Padding(4);
            this.düzenle.Name = "düzenle";
            this.düzenle.Size = new System.Drawing.Size(120, 41);
            this.düzenle.TabIndex = 53;
            this.düzenle.Text = "Düzenle";
            this.düzenle.UseVisualStyleBackColor = false;
            this.düzenle.Click += new System.EventHandler(this.düzenle_Click);
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.Teal;
            this.onayla.FlatAppearance.BorderSize = 0;
            this.onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onayla.Location = new System.Drawing.Point(816, 404);
            this.onayla.Margin = new System.Windows.Forms.Padding(4);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(120, 41);
            this.onayla.TabIndex = 54;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = false;
            this.onayla.Visible = false;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Crimson;
            this.iptal.FlatAppearance.BorderSize = 0;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptal.Location = new System.Drawing.Point(816, 453);
            this.iptal.Margin = new System.Windows.Forms.Padding(4);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(120, 41);
            this.iptal.TabIndex = 55;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Visible = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(805, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 56;
            this.label11.Text = "deneme";
            // 
            // UC_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.düzenle);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.maastext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dogumtarihi);
            this.Controls.Add(this.poz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.cins);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.adres2);
            this.Controls.Add(this.adres1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sube);
            this.Controls.Add(this.telNO2);
            this.Controls.Add(this.telNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.persongorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personelsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personeladi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelekle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Personel";
            this.Size = new System.Drawing.Size(959, 676);
            this.Load += new System.EventHandler(this.UC_Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sube;
        private System.Windows.Forms.TextBox telNO2;
        private System.Windows.Forms.TextBox telNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button persongorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personelsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personeladi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personelekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adres2;
        private System.Windows.Forms.TextBox adres1;
        private System.Windows.Forms.Button filtrele;
        private System.Windows.Forms.ComboBox cins;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.ComboBox depart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox poz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dogumtarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.Label maastext;
        private System.Windows.Forms.Button düzenle;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Label label11;
    }
}
