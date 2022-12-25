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
    public partial class Student : Form
    {

        SqlConnection con;

        public Student()
        {

             
        InitializeComponent();

          
        }

        



        public static string connstring = "Data Source = DESKTOP-JRI2B9M;Initial Catalog=projedb;Integrated Security=true";
        



        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text.Length >=1 && textBox2.Text.Length >= 1 && textBox3.Text.Length >= 1)
            {
                con = new SqlConnection(connstring);
                con.Open();
                string query1 = "select ogrenci_no from Ogrenciler";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (textBox1.Text == reader.Read().ToString())
                    {
                        Console.WriteLine("id aynı");
                    }
                    else
                    {
                        string query = "insert into Ogrenciler(ogrenci_no,ogrenci_isim,ogrenci_sinif) values(@ogrenci_no,@ogrenci_isim,@ogrenci_sinif)";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        cmd1.Parameters.AddWithValue("@ogrenci_no", textBox1.Text);
                        cmd1.Parameters.AddWithValue("@ogrenci_isim", textBox2.Text);
                        cmd1.Parameters.AddWithValue("@ogrenci_sinif", textBox3.Text);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        OgrenciGoruntule();
                    }
                }
                
                    
            }
            else
            {
                MessageBox.Show("Öğrenci eklemek için boşlukları doldurmalısınız!");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OgrenciGoruntule();

            
            /*while (reader.Read())
            {
                
                label4.Text = output;
                output = $"{ Environment.NewLine}Output = " + reader.GetValue(0) + "-" + reader.GetValue(1) + "-" + reader.GetValue(2) ;
                
                label4.Text = label4.Text+output;
            }*/
        }
        void OgrenciGoruntule()
        {
            con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from Personel";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connstring);

            string query = "SELECT sehir_isim FROM Sehir";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sehir_isim"]);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            


        }
    }
}



/* string query = "Select * from Ogrenciler";
SqlCommand cmd = new SqlCommand(query, con);
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    string output = "Output = " + reader.GetValue(0) + "-" + reader.GetValue(1) + "-" + reader.GetValue(2);
    label1.Text = output;
} */