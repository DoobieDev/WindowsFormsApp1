using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            UC_Mainmenu uc = new UC_Mainmenu();
            AddUserControl(uc);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }



        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void Mainpage_Click(object sender, EventArgs e)
        {
            UC_Mainmenu uc = new UC_Mainmenu();
            subebut.BackColor = Color.FromArgb(46, 51, 73);
            personelbut.BackColor = Color.FromArgb(46, 51, 73);
            
            maasbut.BackColor = Color.FromArgb(46, 51, 73);
            Mainpage.BackColor = Color.FromArgb(46, 51, 90);
            anasayfapanel.Visible = true;
            personelpanel.Visible = false;
            maaslarpanel.Visible = false;
            subelerpanel.Visible = false;

            AddUserControl(uc);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            UC_Personel uc = new UC_Personel();

            AddUserControl(uc);
            subebut.BackColor = Color.FromArgb(46, 51, 73);
            Mainpage.BackColor = Color.FromArgb(46, 51, 73);
           
            maasbut.BackColor = Color.FromArgb(46, 51, 73);
            personelbut.BackColor = Color.FromArgb(46, 51, 90);
            anasayfapanel.Visible = false;
            personelpanel.Visible = true;
            maaslarpanel.Visible = false;
            subelerpanel.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UC_Subeler uc = new UC_Subeler();

            AddUserControl(uc);
            maasbut.BackColor = Color.FromArgb(46, 51, 73);
            Mainpage.BackColor = Color.FromArgb(46, 51, 73);
           
            personelbut.BackColor = Color.FromArgb(46, 51, 73);
            subebut.BackColor = Color.FromArgb(46, 51, 90);
            anasayfapanel.Visible = false;
            personelpanel.Visible = false;
            maaslarpanel.Visible = false;
            subelerpanel.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            UC_Maaslar uc = new UC_Maaslar();

            AddUserControl(uc);
            subebut.BackColor = Color.FromArgb(46, 51, 73);
            Mainpage.BackColor = Color.FromArgb(46, 51, 73);
            
            personelbut.BackColor = Color.FromArgb(46, 51, 73);
            maasbut.BackColor = Color.FromArgb(46, 51, 90);
            anasayfapanel.Visible = false;
            personelpanel.Visible = false;
            maaslarpanel.Visible = true;
            subelerpanel.Visible = false;
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            
                DialogResult dialogResult = MessageBox.Show("Çıkmak istediğine emin misin?","Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
                
            
            
            
        }

        

        private void personelbut_MouseHover(object sender, EventArgs e)
        {
            personelpanel.Visible = true;
        }

        private void personelbut_MouseLeave(object sender, EventArgs e)
        {
            
           
            if(personelbut.BackColor != Color.FromArgb(46, 51, 90))
            {
                personelpanel.Visible = false;
            }
            
        }

        private void Mainpage_MouseHover(object sender, EventArgs e)
        {
            anasayfapanel.Visible = true;
        }

        private void Mainpage_MouseLeave(object sender, EventArgs e)
        {
            if (Mainpage.BackColor != Color.FromArgb(46, 51, 90))
            {
                anasayfapanel.Visible = false;
            }
        }

        private void subebut_MouseHover(object sender, EventArgs e)
        {
            subelerpanel.Visible = true;
        }

        private void subebut_MouseLeave(object sender, EventArgs e)
        {
            if (subebut.BackColor != Color.FromArgb(46, 51, 90))
            {
                subelerpanel.Visible = false;
            }
        }

        private void maasbut_MouseHover(object sender, EventArgs e)
        {
            maaslarpanel.Visible = true;
        }

        private void maasbut_MouseLeave(object sender, EventArgs e)
        {
            if (maasbut.BackColor != Color.FromArgb(46, 51, 90))
            {
                maaslarpanel.Visible = false;
            }
        }
    }
}
