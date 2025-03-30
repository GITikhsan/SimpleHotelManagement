using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHotelManagement.View
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }
        public void User()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hotel_management;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM employees";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelUserCount.Text = userCount.ToString();
                }
            }
        }

        public void Client()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hotel_management;Uid=root;Pwd=;"))

            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM guests";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int clientCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelClientCount.Text = clientCount.ToString();
                }
            }
        }

        public void Room()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hotel_management;Uid=root;Pwd=;"))

            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM rooms";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int roomCount = Convert.ToInt32(cmd.ExecuteScalar());
                    labelRoomCount.Text = roomCount.ToString();
                }
            }
        }
    }
}
