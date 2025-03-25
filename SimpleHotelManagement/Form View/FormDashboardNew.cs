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
using SimpleHotelManagement.View;

namespace SimpleHotelManagement
{
    public partial class FormDashboardNew : Form
    {
        public string Username;
        string connectionString = "server=localhost;user id=root;password=;database=hotel_management;";
        public FormDashboardNew()
        {
            InitializeComponent();
        }

        private void FormDashboardNew_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss tt");
        }
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go out?", "Go out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                FormLogin login = new FormLogin();

                login.Show();
                this.Hide();
            }
        }
        private void MovedPanel(Control btn)
        {
            PanelSlide.Top = btn.Top;
            PanelSlide.Height = btn.Height;

        }
  
        private void labelUsername_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM employees WHERE username = @Username";
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonDashboard);
            userControlSetting1.Hide();
            userControlGuest1.Hide();
            userControlRoom1.Hide();
        }
        private void buttonGuests_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonGuests);
            userControlSetting1.Hide();
            userControlGuest1.Clear();
            userControlGuest1.Show();
            userControlRoom1.Hide();


        }
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonRoom);
            userControlSetting1.Hide();
            userControlGuest1.Hide();
            userControlRoom1.clear();
            userControlRoom1.Show();

        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonBooking);
            userControlSetting1.Hide();
            userControlGuest1.Hide();
            userControlRoom1.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovedPanel(buttonSettings);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlGuest1.Hide();
            userControlRoom1.Hide();
        }
        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlSetting1_Load(object sender, EventArgs e)
        {

        }
    }
}
