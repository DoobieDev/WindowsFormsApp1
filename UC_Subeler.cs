using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_Subeler : UserControl
    {

        public const string CONNSTRING = "Data Source = DESKTOP-JRI2B9M;Initial Catalog=projedb;Integrated Security=true";

        SqlConnection con;
        public UC_Subeler()
        {
            con = new SqlConnection(CONNSTRING);
            InitializeComponent();
            con.Open();
        }

        string sehirID;
        
        private void subeEkle_Click(object sender, EventArgs e)
        {

            

            if (subeAd.Text.Length >= 1 && subeAdres.Text.Length >= 1 && sehir.SelectedItem != null)
            {
                
                
                string query2 = "select sehir_id from Sehir where sehir_isim = " + "'" + sehir.SelectedItem + "'";
                SqlCommand cmd3 = new SqlCommand(query2, con);
                SqlDataReader reader1 = cmd3.ExecuteReader();

                while (reader1.Read())
                {
                    this.sehirID = reader1.GetValue(0).ToString();

                }
                reader1.Close();

                
                
                string query = "insert into Sube values(@p1,@p2,@p3)";
                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.Parameters.AddWithValue("@p1", sehirID);
                cmd1.Parameters.AddWithValue("@p2", subeAd.Text);
                cmd1.Parameters.AddWithValue("@p3", subeAdres.Text);
                cmd1.ExecuteNonQuery();
                
                OgrenciGoruntule();




            }
            else
            {
                MessageBox.Show("Öğrenci eklemek için boşlukları doldurmalısınız!");
            }
        }

        void OgrenciGoruntule()
        {
           
            string query = "Select * from Sube";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            


        }
        string sube_no = null;
        private void UC_Subeler_Load(object sender, EventArgs e)
        {
            

            string query5 = "SELECT * FROM Sehir";
            SqlCommand cmd2 = new SqlCommand(query5, con);

            
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                sehir.Items.Add(dr["sehir_isim"]);

            }
            dr.Close();

            

            string query = "SELECT * FROM Sube";
            SqlCommand cmd4 = new SqlCommand(query, con);

  
            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                sube.Items.Add(dr3["sube_ad"]);
                subesec1.Items.Add(dr3["sube_ad"]);

            }
            dr3.Close();

        }

        

        private void subeGor_Click(object sender, EventArgs e)
        {
            OgrenciGoruntule();
            filtrele.Text = "Filtrele";
            filtrele.BackColor = Color.FromArgb(24, 30, 54);
        }
        string sehir1ID;
        private void filtrele_Click(object sender, EventArgs e)
        {

            

            if ((subeAd.Text.Length >= 1 && sehir.SelectedItem != null && subeAdres.Text.Length < 1) || (subeAd.Text.Length < 1 && sehir.SelectedItem != null && subeAdres.Text.Length < 1) || (subeAd.Text.Length >= 1 && sehir.SelectedItem != null && subeAdres.Text.Length >= 1) || (subeAd.Text.Length < 1 && sehir.SelectedItem != null && subeAdres.Text.Length >= 1) || (subeAd.Text.Length < 1 && sehir.SelectedItem == null && subeAdres.Text.Length >= 1) || (subeAd.Text.Length >= 1 && sehir.SelectedItem == null && subeAdres.Text.Length < 1))
            {
                if (sehir.SelectedItem != null) { 
                    string query2 = "select sehir_id from Sehir where sehir_isim = " + "'" + sehir.SelectedItem + "'";
                SqlCommand cmd3 = new SqlCommand(query2, con);
                SqlDataReader reader1 = cmd3.ExecuteReader();

                while (reader1.Read())
                {
                    this.sehir1ID = reader1.GetValue(0).ToString();
                }
                reader1.Close();
            }
                else
                {
                    sehir1ID = null;
                }


                string query = "Select * from Sube where sube_ad like '%" + subeAd.Text + "%' and sehir_id = '"+sehir1ID+ "' and sube_adres like '%" + subeAdres.Text + "%'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter1.Fill(table);
                
                dataGridView1.DataSource = table;
                
            }
            
            filtrele.Text = "Yeniden Filtrele";
            filtrele.BackColor = Color.LightSlateGray;
            
        }
        
        private void departmanekle_Click(object sender, EventArgs e)
        {
            onaylabut.Visible = true;
            iptalbut.Visible = true;
            departmanadi.Visible = true;
            departmanaditext.Visible = true;
            sube.Visible = true;
            subesectext.Visible = true;
            subesec1.Visible = false;
            subesec1text.Visible = false;
            departmansec.Visible = false;
            departmansectext.Visible = false;
            pozisyonadi.Visible = false;
            pozisyonaditext.Visible = false;
            onaylapozbut.Visible = false;
            iptalpozbut.Visible = false;
            departmansec.Text = "";
            subesec1.Text = "";
            departmansec.Items.Clear();



        }

        private void onaylabut_Click(object sender, EventArgs e)
        {
            if (sube.SelectedItem != null && departmanadi.Text.Length > 1)
            {

                onaylabut.Visible = false;
                iptalbut.Visible = false;
                departmanadi.Visible = false;
                departmanaditext.Visible = false;
                sube.Visible = false;
                subesectext.Visible = false;

                string query1 = "insert into Departman values(@p1,@p2);";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@p1", subeid);
                cmd1.Parameters.AddWithValue("@p2", departmanadi.Text);

                cmd1.ExecuteNonQuery();

                OgrenciGoruntule();
                departmanadi.Text = "";
                sube.Text = "";
            }
            else
            {
                MessageBox.Show("Departman eklemek için boşlukları doldurmalısınız!");
            }
        }

        private void iptalbut_Click(object sender, EventArgs e)
        {
            onaylabut.Visible = false;
            iptalbut.Visible = false;
            departmanadi.Visible = false;
            departmanaditext.Visible = false;
            sube.Visible = false;
            subesectext.Visible = false;
            departmanadi.Text = "";
            sube.Text = "";
        }

        string subeid = "";
        private void sube_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "select sube_id from Sube where sube_ad = '" + sube.SelectedItem + "'";


            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataReader reader1 = cmd3.ExecuteReader();

            while (reader1.Read())
            {
                subeid = reader1.GetValue(0).ToString();
            }

            reader1.Close();
        }

        private void subesectext_Click(object sender, EventArgs e)
        {

        }

        private void pozisyonekle_Click(object sender, EventArgs e)
        {
            subesec1.Visible = true;
            subesec1text.Visible = true;
            departmansec.Visible = true;
            departmansectext.Visible = true;
            pozisyonadi.Visible = true;
            pozisyonaditext.Visible = true;
            onaylapozbut.Visible = true;
            iptalpozbut.Visible = true;
            onaylabut.Visible = false;
            iptalbut.Visible = false;
            departmanadi.Visible = false;
            departmanaditext.Visible = false;
            sube.Visible = false;
            subesectext.Visible = false;

        }

        private void onaylapozbut_Click(object sender, EventArgs e)
        {

            if (departmansec.SelectedItem != null && pozisyonadi.Text.Length > 1)
            {
                subesec1.Visible = false;
                subesec1text.Visible = false;
                departmansec.Visible = false;
                departmansectext.Visible = false;
                pozisyonadi.Visible = false;
                pozisyonaditext.Visible = false;
                onaylapozbut.Visible = false;
                iptalpozbut.Visible = false;

                string query3 = "select departman_id from Departman where departman_adi = '" + departmansec.SelectedItem + "'";
                SqlCommand cmd4 = new SqlCommand(query3, con);
                string depid = null;

                SqlDataReader dr3 = cmd4.ExecuteReader();
                while (dr3.Read())
                {
                    depid = dr3.GetInt32(0).ToString();


                }
                dr3.Close();

                string query4 = "insert into Pozisyon values(@p1,@p2)";

                SqlCommand cmd = new SqlCommand(query4, con);

                cmd.Parameters.AddWithValue("@p1", depid);
                cmd.Parameters.AddWithValue("@p2", pozisyonadi.Text);

                cmd.ExecuteNonQuery();

                subesec1.Text = "";
                departmansec.Text = "";
                departmansec.Items.Clear();
            }
            else
            {
                MessageBox.Show("Pozisyon eklemek için boşlukları doldurmalısınız!");
            }
        }

        private void iptalpozbut_Click(object sender, EventArgs e)
        {
            subesec1.Visible = false;
            subesec1text.Visible = false;
            departmansec.Visible = false;
            departmansectext.Visible = false;
            pozisyonadi.Visible = false;
            pozisyonaditext.Visible = false;
            onaylapozbut.Visible = false;
            iptalpozbut.Visible = false;
            departmansec.Text = "";
            subesec1.Text = "";
            departmansec.Items.Clear();
        }

        private void subesec1_SelectedIndexChanged(object sender, EventArgs e)
        {

            departmansec.Text = "";
            departmansec.Items.Clear();
            string query2 = "select sube_id from Sube where sube_ad = '" + subesec1.SelectedItem + "'";


            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataReader reader1 = cmd3.ExecuteReader();

            while (reader1.Read())
            {
                sube_no = reader1.GetValue(0).ToString();
            }

            reader1.Close();
            string query3 = "select * from Departman where departman_sube = '" + sube_no + "'";
            SqlCommand cmd4 = new SqlCommand(query3, con);


            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                departmansec.Items.Add(dr3["departman_adi"]);
                

            }
            dr3.Close();
        }

        private void departgor_Click(object sender, EventArgs e)
        {
            string query = "Select * from Departman";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void pozisgor_Click(object sender, EventArgs e)
        {
            string query = "Select * from Pozisyon";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
