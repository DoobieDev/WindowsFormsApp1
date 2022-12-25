
namespace WindowsFormsApp1
{
    partial class UC_Maaslar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maaslarigor = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iptal = new System.Windows.Forms.Button();
            this.onayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(25, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 612);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 55;
            // 
            // maaslarigor
            // 
            this.maaslarigor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.maaslarigor.FlatAppearance.BorderSize = 0;
            this.maaslarigor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maaslarigor.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maaslarigor.ForeColor = System.Drawing.Color.Transparent;
            this.maaslarigor.Location = new System.Drawing.Point(819, 24);
            this.maaslarigor.Margin = new System.Windows.Forms.Padding(4);
            this.maaslarigor.Name = "maaslarigor";
            this.maaslarigor.Size = new System.Drawing.Size(136, 52);
            this.maaslarigor.TabIndex = 60;
            this.maaslarigor.Text = "Maasları Görüntüle";
            this.maaslarigor.UseVisualStyleBackColor = false;
            this.maaslarigor.Click += new System.EventHandler(this.subeGor_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelle.Location = new System.Drawing.Point(819, 84);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(136, 52);
            this.guncelle.TabIndex = 56;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(376, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "ŞUBELER";
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Crimson;
            this.iptal.FlatAppearance.BorderSize = 0;
            this.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iptal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptal.Location = new System.Drawing.Point(819, 193);
            this.iptal.Margin = new System.Windows.Forms.Padding(4);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(120, 41);
            this.iptal.TabIndex = 62;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Visible = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.Teal;
            this.onayla.FlatAppearance.BorderSize = 0;
            this.onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onayla.Location = new System.Drawing.Point(819, 144);
            this.onayla.Margin = new System.Windows.Forms.Padding(4);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(120, 41);
            this.onayla.TabIndex = 61;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = false;
            this.onayla.Visible = false;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // UC_Maaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maaslarigor);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Maaslar";
            this.Size = new System.Drawing.Size(959, 676);
            this.Load += new System.EventHandler(this.UC_Maaslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button maaslarigor;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button onayla;
    }
}
