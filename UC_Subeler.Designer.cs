
namespace WindowsFormsApp1
{
    partial class UC_Subeler
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
            this.label1 = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.sehirsec = new System.Windows.Forms.Label();
            this.subeGor = new System.Windows.Forms.Button();
            this.subeAdres = new System.Windows.Forms.TextBox();
            this.subeadresitext = new System.Windows.Forms.Label();
            this.subeEkle = new System.Windows.Forms.Button();
            this.subeAd = new System.Windows.Forms.TextBox();
            this.subeaditext = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtrele = new System.Windows.Forms.Button();
            this.departmanekle = new System.Windows.Forms.Button();
            this.iptalbut = new System.Windows.Forms.Button();
            this.onaylabut = new System.Windows.Forms.Button();
            this.sube = new System.Windows.Forms.ComboBox();
            this.subesectext = new System.Windows.Forms.Label();
            this.departmanaditext = new System.Windows.Forms.Label();
            this.departmanadi = new System.Windows.Forms.TextBox();
            this.pozisyonaditext = new System.Windows.Forms.Label();
            this.pozisyonadi = new System.Windows.Forms.TextBox();
            this.departmansec = new System.Windows.Forms.ComboBox();
            this.departmansectext = new System.Windows.Forms.Label();
            this.iptalpozbut = new System.Windows.Forms.Button();
            this.onaylapozbut = new System.Windows.Forms.Button();
            this.pozisyonekle = new System.Windows.Forms.Button();
            this.subesec1 = new System.Windows.Forms.ComboBox();
            this.subesec1text = new System.Windows.Forms.Label();
            this.departgor = new System.Windows.Forms.Button();
            this.pozisgor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(385, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞUBELER";
            // 
            // sehir
            // 
            this.sehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sehir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sehir.FormattingEnabled = true;
            this.sehir.Location = new System.Drawing.Point(146, 83);
            this.sehir.Margin = new System.Windows.Forms.Padding(4);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(243, 24);
            this.sehir.TabIndex = 49;
            // 
            // sehirsec
            // 
            this.sehirsec.AutoSize = true;
            this.sehirsec.BackColor = System.Drawing.Color.Transparent;
            this.sehirsec.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehirsec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sehirsec.Location = new System.Drawing.Point(6, 85);
            this.sehirsec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sehirsec.Name = "sehirsec";
            this.sehirsec.Size = new System.Drawing.Size(49, 18);
            this.sehirsec.TabIndex = 45;
            this.sehirsec.Text = "Şehir";
            // 
            // subeGor
            // 
            this.subeGor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.subeGor.FlatAppearance.BorderSize = 0;
            this.subeGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subeGor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeGor.ForeColor = System.Drawing.Color.Transparent;
            this.subeGor.Location = new System.Drawing.Point(409, 71);
            this.subeGor.Margin = new System.Windows.Forms.Padding(4);
            this.subeGor.Name = "subeGor";
            this.subeGor.Size = new System.Drawing.Size(139, 52);
            this.subeGor.TabIndex = 44;
            this.subeGor.Text = "Şubeleri Görüntüle";
            this.subeGor.UseVisualStyleBackColor = false;
            this.subeGor.Click += new System.EventHandler(this.subeGor_Click);
            // 
            // subeAdres
            // 
            this.subeAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.subeAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeAdres.ForeColor = System.Drawing.Color.Transparent;
            this.subeAdres.Location = new System.Drawing.Point(146, 59);
            this.subeAdres.Margin = new System.Windows.Forms.Padding(4);
            this.subeAdres.Name = "subeAdres";
            this.subeAdres.Size = new System.Drawing.Size(243, 16);
            this.subeAdres.TabIndex = 41;
            // 
            // subeadresitext
            // 
            this.subeadresitext.AutoSize = true;
            this.subeadresitext.BackColor = System.Drawing.Color.Transparent;
            this.subeadresitext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeadresitext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subeadresitext.Location = new System.Drawing.Point(6, 59);
            this.subeadresitext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subeadresitext.Name = "subeadresitext";
            this.subeadresitext.Size = new System.Drawing.Size(104, 18);
            this.subeadresitext.TabIndex = 40;
            this.subeadresitext.Text = "Şube Adresi";
            // 
            // subeEkle
            // 
            this.subeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.subeEkle.FlatAppearance.BorderSize = 0;
            this.subeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subeEkle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subeEkle.Location = new System.Drawing.Point(409, 21);
            this.subeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.subeEkle.Name = "subeEkle";
            this.subeEkle.Size = new System.Drawing.Size(139, 47);
            this.subeEkle.TabIndex = 37;
            this.subeEkle.Text = "Şube Ekle";
            this.subeEkle.UseVisualStyleBackColor = false;
            this.subeEkle.Click += new System.EventHandler(this.subeEkle_Click);
            // 
            // subeAd
            // 
            this.subeAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.subeAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subeAd.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.subeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeAd.ForeColor = System.Drawing.Color.Transparent;
            this.subeAd.Location = new System.Drawing.Point(146, 35);
            this.subeAd.Margin = new System.Windows.Forms.Padding(4);
            this.subeAd.Name = "subeAd";
            this.subeAd.Size = new System.Drawing.Size(243, 16);
            this.subeAd.TabIndex = 39;
            // 
            // subeaditext
            // 
            this.subeaditext.AutoSize = true;
            this.subeaditext.BackColor = System.Drawing.Color.Transparent;
            this.subeaditext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeaditext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subeaditext.Location = new System.Drawing.Point(6, 35);
            this.subeaditext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subeaditext.Name = "subeaditext";
            this.subeaditext.Size = new System.Drawing.Size(79, 18);
            this.subeaditext.TabIndex = 50;
            this.subeaditext.Text = "Şube Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(89, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 377);
            this.dataGridView1.TabIndex = 30;
            // 
            // filtrele
            // 
            this.filtrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.filtrele.FlatAppearance.BorderSize = 0;
            this.filtrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrele.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrele.ForeColor = System.Drawing.Color.Transparent;
            this.filtrele.Location = new System.Drawing.Point(813, 322);
            this.filtrele.Margin = new System.Windows.Forms.Padding(4);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(136, 44);
            this.filtrele.TabIndex = 53;
            this.filtrele.Text = "Filtrele";
            this.filtrele.UseVisualStyleBackColor = false;
            this.filtrele.Click += new System.EventHandler(this.filtrele_Click);
            // 
            // departmanekle
            // 
            this.departmanekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.departmanekle.FlatAppearance.BorderSize = 0;
            this.departmanekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmanekle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmanekle.Location = new System.Drawing.Point(552, 21);
            this.departmanekle.Margin = new System.Windows.Forms.Padding(4);
            this.departmanekle.Name = "departmanekle";
            this.departmanekle.Size = new System.Drawing.Size(131, 47);
            this.departmanekle.TabIndex = 54;
            this.departmanekle.Text = "Departman Ekle";
            this.departmanekle.UseVisualStyleBackColor = false;
            this.departmanekle.Click += new System.EventHandler(this.departmanekle_Click);
            // 
            // iptalbut
            // 
            this.iptalbut.BackColor = System.Drawing.Color.Crimson;
            this.iptalbut.FlatAppearance.BorderSize = 0;
            this.iptalbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalbut.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalbut.ForeColor = System.Drawing.Color.Transparent;
            this.iptalbut.Location = new System.Drawing.Point(498, 146);
            this.iptalbut.Margin = new System.Windows.Forms.Padding(4);
            this.iptalbut.Name = "iptalbut";
            this.iptalbut.Size = new System.Drawing.Size(61, 27);
            this.iptalbut.TabIndex = 56;
            this.iptalbut.Text = "İptal";
            this.iptalbut.UseVisualStyleBackColor = false;
            this.iptalbut.Visible = false;
            this.iptalbut.Click += new System.EventHandler(this.iptalbut_Click);
            // 
            // onaylabut
            // 
            this.onaylabut.BackColor = System.Drawing.Color.Teal;
            this.onaylabut.FlatAppearance.BorderSize = 0;
            this.onaylabut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onaylabut.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylabut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onaylabut.Location = new System.Drawing.Point(409, 146);
            this.onaylabut.Margin = new System.Windows.Forms.Padding(4);
            this.onaylabut.Name = "onaylabut";
            this.onaylabut.Size = new System.Drawing.Size(81, 27);
            this.onaylabut.TabIndex = 55;
            this.onaylabut.Text = "Onayla";
            this.onaylabut.UseVisualStyleBackColor = false;
            this.onaylabut.Visible = false;
            this.onaylabut.Click += new System.EventHandler(this.onaylabut_Click);
            // 
            // sube
            // 
            this.sube.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sube.FormattingEnabled = true;
            this.sube.Location = new System.Drawing.Point(146, 144);
            this.sube.Margin = new System.Windows.Forms.Padding(4);
            this.sube.Name = "sube";
            this.sube.Size = new System.Drawing.Size(243, 24);
            this.sube.TabIndex = 58;
            this.sube.Visible = false;
            this.sube.SelectedIndexChanged += new System.EventHandler(this.sube_SelectedIndexChanged);
            // 
            // subesectext
            // 
            this.subesectext.AutoSize = true;
            this.subesectext.BackColor = System.Drawing.Color.Transparent;
            this.subesectext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subesectext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subesectext.Location = new System.Drawing.Point(7, 146);
            this.subesectext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subesectext.Name = "subesectext";
            this.subesectext.Size = new System.Drawing.Size(48, 18);
            this.subesectext.TabIndex = 57;
            this.subesectext.Text = "Şube";
            this.subesectext.Visible = false;
            this.subesectext.Click += new System.EventHandler(this.subesectext_Click);
            // 
            // departmanaditext
            // 
            this.departmanaditext.AutoSize = true;
            this.departmanaditext.BackColor = System.Drawing.Color.Transparent;
            this.departmanaditext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanaditext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmanaditext.Location = new System.Drawing.Point(7, 169);
            this.departmanaditext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmanaditext.Name = "departmanaditext";
            this.departmanaditext.Size = new System.Drawing.Size(126, 18);
            this.departmanaditext.TabIndex = 60;
            this.departmanaditext.Text = "Departman Adı";
            this.departmanaditext.Visible = false;
            // 
            // departmanadi
            // 
            this.departmanadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.departmanadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departmanadi.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.departmanadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmanadi.ForeColor = System.Drawing.Color.Transparent;
            this.departmanadi.Location = new System.Drawing.Point(146, 176);
            this.departmanadi.Margin = new System.Windows.Forms.Padding(4);
            this.departmanadi.Name = "departmanadi";
            this.departmanadi.Size = new System.Drawing.Size(243, 16);
            this.departmanadi.TabIndex = 59;
            this.departmanadi.Visible = false;
            // 
            // pozisyonaditext
            // 
            this.pozisyonaditext.AutoSize = true;
            this.pozisyonaditext.BackColor = System.Drawing.Color.Transparent;
            this.pozisyonaditext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozisyonaditext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pozisyonaditext.Location = new System.Drawing.Point(7, 193);
            this.pozisyonaditext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pozisyonaditext.Name = "pozisyonaditext";
            this.pozisyonaditext.Size = new System.Drawing.Size(109, 18);
            this.pozisyonaditext.TabIndex = 66;
            this.pozisyonaditext.Text = "Pozisyon Adı";
            this.pozisyonaditext.Visible = false;
            // 
            // pozisyonadi
            // 
            this.pozisyonadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pozisyonadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pozisyonadi.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pozisyonadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozisyonadi.ForeColor = System.Drawing.Color.Transparent;
            this.pozisyonadi.Location = new System.Drawing.Point(146, 195);
            this.pozisyonadi.Margin = new System.Windows.Forms.Padding(4);
            this.pozisyonadi.Name = "pozisyonadi";
            this.pozisyonadi.Size = new System.Drawing.Size(243, 16);
            this.pozisyonadi.TabIndex = 65;
            this.pozisyonadi.Visible = false;
            // 
            // departmansec
            // 
            this.departmansec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmansec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.departmansec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmansec.FormattingEnabled = true;
            this.departmansec.Location = new System.Drawing.Point(146, 167);
            this.departmansec.Margin = new System.Windows.Forms.Padding(4);
            this.departmansec.Name = "departmansec";
            this.departmansec.Size = new System.Drawing.Size(243, 24);
            this.departmansec.TabIndex = 64;
            this.departmansec.Visible = false;
            // 
            // departmansectext
            // 
            this.departmansectext.AutoSize = true;
            this.departmansectext.BackColor = System.Drawing.Color.Transparent;
            this.departmansectext.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmansectext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmansectext.Location = new System.Drawing.Point(7, 169);
            this.departmansectext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmansectext.Name = "departmansectext";
            this.departmansectext.Size = new System.Drawing.Size(95, 18);
            this.departmansectext.TabIndex = 63;
            this.departmansectext.Text = "Departman";
            this.departmansectext.Visible = false;
            // 
            // iptalpozbut
            // 
            this.iptalpozbut.BackColor = System.Drawing.Color.Crimson;
            this.iptalpozbut.FlatAppearance.BorderSize = 0;
            this.iptalpozbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptalpozbut.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptalpozbut.ForeColor = System.Drawing.Color.Transparent;
            this.iptalpozbut.Location = new System.Drawing.Point(498, 146);
            this.iptalpozbut.Margin = new System.Windows.Forms.Padding(4);
            this.iptalpozbut.Name = "iptalpozbut";
            this.iptalpozbut.Size = new System.Drawing.Size(61, 27);
            this.iptalpozbut.TabIndex = 62;
            this.iptalpozbut.Text = "İptal";
            this.iptalpozbut.UseVisualStyleBackColor = false;
            this.iptalpozbut.Visible = false;
            this.iptalpozbut.Click += new System.EventHandler(this.iptalpozbut_Click);
            // 
            // onaylapozbut
            // 
            this.onaylapozbut.BackColor = System.Drawing.Color.Teal;
            this.onaylapozbut.FlatAppearance.BorderSize = 0;
            this.onaylapozbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onaylapozbut.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylapozbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onaylapozbut.Location = new System.Drawing.Point(409, 146);
            this.onaylapozbut.Margin = new System.Windows.Forms.Padding(4);
            this.onaylapozbut.Name = "onaylapozbut";
            this.onaylapozbut.Size = new System.Drawing.Size(81, 27);
            this.onaylapozbut.TabIndex = 61;
            this.onaylapozbut.Text = "Onayla";
            this.onaylapozbut.UseVisualStyleBackColor = false;
            this.onaylapozbut.Visible = false;
            this.onaylapozbut.Click += new System.EventHandler(this.onaylapozbut_Click);
            // 
            // pozisyonekle
            // 
            this.pozisyonekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pozisyonekle.FlatAppearance.BorderSize = 0;
            this.pozisyonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pozisyonekle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozisyonekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pozisyonekle.Location = new System.Drawing.Point(688, 21);
            this.pozisyonekle.Margin = new System.Windows.Forms.Padding(4);
            this.pozisyonekle.Name = "pozisyonekle";
            this.pozisyonekle.Size = new System.Drawing.Size(131, 47);
            this.pozisyonekle.TabIndex = 67;
            this.pozisyonekle.Text = "Pozisyon Ekle";
            this.pozisyonekle.UseVisualStyleBackColor = false;
            this.pozisyonekle.Click += new System.EventHandler(this.pozisyonekle_Click);
            // 
            // subesec1
            // 
            this.subesec1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.subesec1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.subesec1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subesec1.FormattingEnabled = true;
            this.subesec1.Location = new System.Drawing.Point(146, 144);
            this.subesec1.Margin = new System.Windows.Forms.Padding(4);
            this.subesec1.Name = "subesec1";
            this.subesec1.Size = new System.Drawing.Size(243, 24);
            this.subesec1.TabIndex = 69;
            this.subesec1.Visible = false;
            this.subesec1.SelectedIndexChanged += new System.EventHandler(this.subesec1_SelectedIndexChanged);
            // 
            // subesec1text
            // 
            this.subesec1text.AutoSize = true;
            this.subesec1text.BackColor = System.Drawing.Color.Transparent;
            this.subesec1text.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subesec1text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subesec1text.Location = new System.Drawing.Point(7, 146);
            this.subesec1text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subesec1text.Name = "subesec1text";
            this.subesec1text.Size = new System.Drawing.Size(48, 18);
            this.subesec1text.TabIndex = 68;
            this.subesec1text.Text = "Şube";
            this.subesec1text.Visible = false;
            // 
            // departgor
            // 
            this.departgor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.departgor.FlatAppearance.BorderSize = 0;
            this.departgor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departgor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departgor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departgor.Location = new System.Drawing.Point(552, 71);
            this.departgor.Margin = new System.Windows.Forms.Padding(4);
            this.departgor.Name = "departgor";
            this.departgor.Size = new System.Drawing.Size(131, 52);
            this.departgor.TabIndex = 70;
            this.departgor.Text = "Departmanları Görüntüle";
            this.departgor.UseVisualStyleBackColor = false;
            this.departgor.Click += new System.EventHandler(this.departgor_Click);
            // 
            // pozisgor
            // 
            this.pozisgor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pozisgor.FlatAppearance.BorderSize = 0;
            this.pozisgor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pozisgor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozisgor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pozisgor.Location = new System.Drawing.Point(688, 71);
            this.pozisgor.Margin = new System.Windows.Forms.Padding(4);
            this.pozisgor.Name = "pozisgor";
            this.pozisgor.Size = new System.Drawing.Size(131, 52);
            this.pozisgor.TabIndex = 71;
            this.pozisgor.Text = "Pozisyonları Görüntüle";
            this.pozisgor.UseVisualStyleBackColor = false;
            this.pozisgor.Click += new System.EventHandler(this.pozisgor_Click);
            // 
            // UC_Subeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pozisgor);
            this.Controls.Add(this.departgor);
            this.Controls.Add(this.subesec1);
            this.Controls.Add(this.subesec1text);
            this.Controls.Add(this.pozisyonekle);
            this.Controls.Add(this.pozisyonaditext);
            this.Controls.Add(this.pozisyonadi);
            this.Controls.Add(this.departmansec);
            this.Controls.Add(this.departmansectext);
            this.Controls.Add(this.iptalpozbut);
            this.Controls.Add(this.onaylapozbut);
            this.Controls.Add(this.departmanaditext);
            this.Controls.Add(this.departmanadi);
            this.Controls.Add(this.sube);
            this.Controls.Add(this.subesectext);
            this.Controls.Add(this.iptalbut);
            this.Controls.Add(this.onaylabut);
            this.Controls.Add(this.departmanekle);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.subeaditext);
            this.Controls.Add(this.sehir);
            this.Controls.Add(this.sehirsec);
            this.Controls.Add(this.subeGor);
            this.Controls.Add(this.subeAdres);
            this.Controls.Add(this.subeadresitext);
            this.Controls.Add(this.subeAd);
            this.Controls.Add(this.subeEkle);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Subeler";
            this.Size = new System.Drawing.Size(959, 676);
            this.Load += new System.EventHandler(this.UC_Subeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.Label sehirsec;
        private System.Windows.Forms.Button subeGor;
        private System.Windows.Forms.TextBox subeAdres;
        private System.Windows.Forms.Label subeadresitext;
        private System.Windows.Forms.Button subeEkle;
        private System.Windows.Forms.TextBox subeAd;
        private System.Windows.Forms.Label subeaditext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button filtrele;
        private System.Windows.Forms.Button departmanekle;
        private System.Windows.Forms.Button iptalbut;
        private System.Windows.Forms.Button onaylabut;
        private System.Windows.Forms.ComboBox sube;
        private System.Windows.Forms.Label subesectext;
        private System.Windows.Forms.Label departmanaditext;
        private System.Windows.Forms.TextBox departmanadi;
        private System.Windows.Forms.Label pozisyonaditext;
        private System.Windows.Forms.TextBox pozisyonadi;
        private System.Windows.Forms.ComboBox departmansec;
        private System.Windows.Forms.Label departmansectext;
        private System.Windows.Forms.Button iptalpozbut;
        private System.Windows.Forms.Button onaylapozbut;
        private System.Windows.Forms.Button pozisyonekle;
        private System.Windows.Forms.ComboBox subesec1;
        private System.Windows.Forms.Label subesec1text;
        private System.Windows.Forms.Button departgor;
        private System.Windows.Forms.Button pozisgor;
    }
}
