using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramHotel
{
    public partial class FormDashboard : Form
    {
        public string Username;
        string connectionString = "server=localhost;user id=root;password=;database=reservasi_hotel;";
        public FormDashboard()
        {
            InitializeComponent();
           
        }

        private void MovedPanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Apakah anda ingin keluar?", "Keluar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                FormLogIn login = new FormLogIn();

                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonDashboard);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.User();
            userControlDashboard1.Client();
            userControlDashboard1.Room();
            userControlDashboard1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonPengaturan);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MovedPanel(buttonTamu);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonPemesanan);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.clear();
            userControlReservation1.Show();
            userControlDashboard1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }

        private void buttonKamar_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonKamar);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.clear();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT COUNT(*) FROM karyawan WHERE username = @Username";

           
        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
