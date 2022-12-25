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
    public partial class UC_Personel : UserControl
    {

        SqlConnection con;
        public const string CONNSTRING = "Data Source = DESKTOP-JRI2B9M;Initial Catalog=projedb;Integrated Security=true";
        public UC_Personel()
        {
            con = new SqlConnection(CONNSTRING);
            InitializeComponent();
            con.Open();

        }

        

        private void PersongorButton_Click(object sender, EventArgs e)
        {
            PersonelGoruntule();
        }







        void PersonelGoruntule()
        {
           

            string query1 = "SELECT PersonelBilgileri.personel_id, PersonelBilgileri.personel_ad, PersonelBilgileri.personel_soyad, PersonelBilgileri.personel_cinsiyet, PersonelBilgileri.personel_dt" +
                ", PersonelTelefonlari.telefon_no, PersonelAdresi.adres" +
                " FROM PersonelBilgileri LEFT JOIN PersonelTelefonlari ON PersonelTelefonlari.personel_id = PersonelBilgileri.personel_id LEFT JOIN PersonelAdresi" +
                " ON PersonelAdresi.personel_id = PersonelBilgileri.personel_id;";
            

            SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
            
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            onayla.Visible = false;
            iptal.Visible = false;
            düzenle.Enabled = true;
            personeladi.Text = "";
            personelsoyad.Text = "";
            cins.Text = "";
            sube.Text = "";
            depart.Text = "";
            poz.Text = "";
            maas.Text = "";
            telNO.Text = "";
            telNO2.Text = "";
            adres1.Text = "";
            adres2.Text = "";








        }

        string subeid;

        private void button2_Click(object sender, EventArgs e)
        {

            if (personeladi.Text.Length >= 1 && personelsoyad.Text.Length >= 1 && cins.SelectedItem != null)
            {
                
                string query2 = "select personel_ad from PersonelBilgileri where personel_ad = " + "'" + personeladi.Text + "' AND personel_soyad = '" + personelsoyad.Text + "'";


                SqlCommand cmd3 = new SqlCommand(query2, con);
                SqlDataReader reader1 = cmd3.ExecuteReader();

                while (reader1.Read())
                {
                    if (reader1.GetString(0) == personeladi.Text)
                    {

                        MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                        break;


                    }
                }
                reader1.Close();

                        dogumtarihi.CustomFormat = "dd-mm-yyyy";
                        string query = "insert into PersonelBilgileri(personel_ad,personel_soyad,personel_cinsiyet,personel_dt) values(@p1,@p2,@p3,@p4)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@p1", personeladi.Text);
                        cmd1.Parameters.AddWithValue("@p2", personelsoyad.Text);
                        cmd1.Parameters.AddWithValue("@p3", cins.SelectedItem);
                        cmd1.Parameters.AddWithValue("@p4", dogumtarihi.Value);
                        cmd1.ExecuteNonQuery();



                        string query7 = "select sube_id from Sube where sube_ad = '" + sube.SelectedItem + "'";
                        SqlCommand cmd7 = new SqlCommand(query7, con);
                        SqlDataReader reader6 = cmd7.ExecuteReader();
                        string subid = "";
                        while (reader6.Read())
                        {
                            subid = reader6.GetInt32(0).ToString();

                        }
                        reader6.Close();
                        string query6 = "select departman_id from Departman where departman_adi = '" + depart.SelectedItem + "' and departman_sube = '" + subid + "'";
                        SqlCommand cmd6 = new SqlCommand(query6, con);
                        SqlDataReader reader5 = cmd6.ExecuteReader();
                        string depid = "";
                        while (reader5.Read())
                        {
                            depid = reader5.GetInt32(0).ToString();

                        }
                        reader5.Close();
                        string query4 = "select personel_id from PersonelBilgileri where personel_ad = " + "'" + personeladi.Text + "' AND personel_soyad = '" + personelsoyad.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(query4, con);
                        SqlDataReader reader3 = cmd4.ExecuteReader();
                        string personid = "";
                        while (reader3.Read())
                        {
                            personid = reader3.GetInt32(0).ToString();

                        }
                        reader3.Close();

                        string query5 = "select pozisyon_id from Pozisyon where pozisyon_isim = '" + poz.SelectedItem + "' and departman_id = '" + depid + "'";
                        SqlCommand cmd5 = new SqlCommand(query5, con);
                        SqlDataReader reader4 = cmd5.ExecuteReader();
                        string pozid = "";
                        while (reader4.Read())
                        {
                            pozid = reader4.GetInt32(0).ToString();

                        }
                        reader4.Close();
                        if (poz != null)
                        {


                            string query1 = "insert into Personel values(@p5,@p6,@p7)";
                            SqlCommand cmd2 = new SqlCommand(query1, con);
                            cmd2.Parameters.AddWithValue("@p5", personid);
                            cmd2.Parameters.AddWithValue("@p6", pozid);
                            cmd2.Parameters.AddWithValue("@p7", maas.Text);

                            cmd2.ExecuteNonQuery();

                        }
                        if (telNO.Text.Length > 1)
                {
                    string query11 = "insert into PersonelTelefonlari values(@p1,@p2)";
                    SqlCommand cmd2 = new SqlCommand(query11, con);
                    cmd2.Parameters.AddWithValue("@p1", personid);
                    cmd2.Parameters.AddWithValue("@p2", telNO.Text);
                    cmd2.ExecuteNonQuery();
                    if (telNO2.Text.Length > 1)
                    {
                        string query12 = "insert into PersonelTelefonlari values(@p3,@p4)";
                        SqlCommand cmd22 = new SqlCommand(query12, con);
                        cmd2.Parameters.AddWithValue("@p3", personid);
                        cmd2.Parameters.AddWithValue("@p4", telNO2.Text);
                        cmd2.ExecuteNonQuery();
                    }
                }
                if (adres1.Text.Length > 1)
                {
                    string query11 = "insert into PersonelAdresi values(@p1,@p2)";
                    SqlCommand cmd2 = new SqlCommand(query11, con);
                    cmd2.Parameters.AddWithValue("@p1", personid);
                    cmd2.Parameters.AddWithValue("@p2", adres1.Text);
                    cmd2.ExecuteNonQuery();
                    if (adres2.Text.Length > 1)
                    {
                        string query12 = "insert into PersonelAdresi values(@p3,@p4)";
                        SqlCommand cmd44 = new SqlCommand(query12, con);
                        cmd44.Parameters.AddWithValue("@p3", personid);
                        cmd44.Parameters.AddWithValue("@p4", adres2.Text);
                        cmd44.ExecuteNonQuery();
                    }
                }





                PersonelGoruntule();



                        
                    
                }


                
            



            else
            {
                MessageBox.Show("Öğrenci eklemek için boşlukları doldurmalısınız!");
            }
        }








        private void UC_Personel_Load(object sender, EventArgs e)
        {


            cins.Items.Add("Erkek");
            cins.Items.Add("Kadın");
            
            

            string query2 = "select sube_id from Sube where sube_ad = '" + sube.SelectedItem + "'";


            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataReader reader1 = cmd3.ExecuteReader();
            string sube_no = null;
            while (reader1.Read())
            {
                sube_no = reader1.GetString(0);
            }

            reader1.Close();

            string query = "SELECT * FROM Sube";
            SqlCommand cmd2 = new SqlCommand(query, con);

            string query1 = "SELECT departman_adi from where departman_sube = " + sube_no;

            SqlDataReader dr2 = cmd3.ExecuteReader();
            while (dr2.Read())
            {
                sube.Items.Add(dr2["departman_adi"]);

            }
            dr2.Close();

            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                sube.Items.Add(dr["sube_ad"]);

            }
            dr.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void sube_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            poz.Items.Clear();
            poz.Text = "";
            depart.Items.Clear();
            depart.Text = "";
            string query2 = "select sube_id from Sube where sube_ad = '" + sube.SelectedItem + "'";


            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataReader reader15 = cmd3.ExecuteReader();
            int sube_no = 0;
            while (reader15.Read())
            {
                sube_no = reader15.GetInt32(0);
            }

            reader15.Close();

            string query1 = "SELECT departman_adi from Departman where departman_sube = " + sube_no;
            SqlCommand cmd4 = new SqlCommand(query1, con);
            SqlDataReader dr2 = cmd4.ExecuteReader();
            while (dr2.Read())
            {
                depart.Items.Add(dr2["departman_adi"]);

            }
            dr2.Close();
        }



        private void depart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            poz.Items.Clear();
            poz.Text = "";
            string query2 = "select departman_id from Departman where departman_adi = '" + depart.SelectedItem + "'";


            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataReader reader1 = cmd3.ExecuteReader();
            int departman_no = 0;
            while (reader1.Read())
            {
                departman_no = reader1.GetInt32(0);
            }

            reader1.Close();

            string query1 = "SELECT pozisyon_isim from Pozisyon where departman_id = '" + departman_no + "'";
            SqlCommand cmd4 = new SqlCommand(query1, con);
            SqlDataReader dr2 = cmd4.ExecuteReader();
            while (dr2.Read())
            {
                poz.Items.Add(dr2["pozisyon_isim"]);

            }
            dr2.Close();
            
        }

        private void cikar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Personel çıkarmak için önce personel seçmelisiniz!");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Bu personeli çıkarmak istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];
                    String id = (rowIndex.Cells[0].Value.ToString());

                    string query5 = "delete from PersonelAdresi where personel_id = '" + id + "'";
                    string query4 = "delete from PersonelTelefonlari where personel_id = '" + id + "'";
                    string query3 = "delete from Personel where personel_id = '" + id + "'";
                    SqlCommand command3 = new SqlCommand(query4, con);
                    SqlCommand command2 = new SqlCommand(query5, con);
                    SqlCommand command1 = new SqlCommand(query3, con);
                    string query2 = "delete from PersonelBilgileri where personel_id = '" + id + "'";
                    SqlCommand command = new SqlCommand(query2, con);
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    PersonelGoruntule();


                }
            }
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            onayla.Visible = false;
            iptal.Visible = false;
            düzenle.Enabled = true;
            DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];
            String id = (rowIndex.Cells[0].Value.ToString());
            string[] separator = rowIndex.Cells[4].Value.ToString().Split('.',' ');
            int day = Int32.Parse(separator[0]);
            int month = Int32.Parse(separator[1]);
            int year = Int32.Parse(separator[2]);
                 DateTime dt = new DateTime(year,month,day);
            
            string sqlFormattedDate = dt.ToString("yyyy-MM-dd");


           label11.Text = sqlFormattedDate;




            string query = "UPDATE PersonelBilgileri SET personel_ad = '" + rowIndex.Cells[1].Value.ToString() +"', personel_soyad = '" + rowIndex.Cells[2].Value.ToString() + "', personel_cinsiyet = '" + rowIndex.Cells[3].Value.ToString() +
              "', personel_dt = '" + sqlFormattedDate + "'  WHERE personel_id = '" + id + "';";
                
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            PersonelGoruntule();

        }

        private void düzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Personel düzenlemek için önce personel seçmelisiniz!");
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Bu personeli  istediğine emin misin?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow rowIndex = dataGridView1.SelectedRows[0];
                    String id = (rowIndex.Cells[0].Value.ToString());
                    string query = "SELECT * FROM PersonelBilgileri WHERE PersonelBilgileri.personel_id = '"+id+"' ; ";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query,con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                       
                    label11.Text = id;
                    onayla.Visible = true;
                    iptal.Visible = true;
                    düzenle.Enabled = false;
                    

                    

                }
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            onayla.Visible = false;
            iptal.Visible = false;
            düzenle.Enabled = true;
            PersonelGoruntule();
        }
    }
}

    

