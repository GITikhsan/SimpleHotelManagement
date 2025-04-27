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
namespace ProgramHotel.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void User ()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=reservasi_hotel;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM karyawan";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelUserCount.Text = userCount.ToString();
                }
            }
        }

        public void Client ()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=reservasi_hotel;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tamu";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int clientCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelClientCount.Text = clientCount.ToString();
                }
            }
        }

        public void Room()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=reservasi_hotel;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM jenis_kamar";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int roomCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelRoomCount.Text = roomCount.ToString();
                }
            }
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
