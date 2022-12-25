using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UC_Maaslar : UserControl
    {

        SqlConnection con;
        public const string CONNSTRING = "Data Source = DESKTOP-JRI2B9M;Initial Catalog=projedb;Integrated Security=true";
        public UC_Maaslar()
        {
            con = new SqlConnection(CONNSTRING);
            InitializeComponent();
            con.Open();
        }

        void MaasGor()
        {

            string query1 = "SELECT PersonelBilgileri.personel_id, PersonelBilgileri.personel_ad, PersonelBilgileri.personel_soyad" +
                ", Personel.pozisyon_id, Personel.maas FROM PersonelBilgileri LEFT JOIN Personel ON PersonelBilgileri.personel_id = Personel.personel_id;";
            //Burayı düzenle posizyon ismi yazacak
            string query2 = "SELECT * FROM Pozisyon";

            SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void UC_Maaslar_Load(object sender, EventArgs e)
        {

        }

        private void subeGor_Click(object sender, EventArgs e)
        {
            MaasGor();
        }

        private void subeEkle_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Personel düzenlemek için önce personel seçmelisiniz!");
            }

            else
            {
                onayla.Visible = true;
                iptal.Visible = true;
                guncelle.Enabled = false;

                DialogResult dialogResult = MessageBox.Show("Bu personeli  istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];
                    String id = (rowIndex.Cells[0].Value.ToString());
                    string query = "SELECT PersonelBilgileri.personel_id, PersonelBilgileri.personel_ad, PersonelBilgileri.personel_soyad" +
                ", Personel.pozisyon_id, Personel.maas FROM PersonelBilgileri LEFT JOIN Personel ON PersonelBilgileri.personel_id = Personel.personel_id WHERE Personel.personel_id = '" +
                id+"';";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;


                }
            }
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            onayla.Visible = false;
            iptal.Visible = false;
            guncelle.Enabled = true;
            DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];
            String id = (rowIndex.Cells[0].Value.ToString());
            
           

           


            




            string query = "UPDATE Personel SET maas = '" + rowIndex.Cells[4].Value.ToString() + "'  WHERE personel_id = '" + id + "';";

            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MaasGor();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            onayla.Visible = false;
            iptal.Visible = false;
            guncelle.Enabled = true;
            MaasGor();
        }
    }
}

