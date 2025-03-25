using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;
using MySql.Data.MySqlClient;
//using ProgramHotel.Controller;
//using ProgramHotel.Model.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleHotelManagement.View
{
    public partial class UserControlSetting : UserControl
    {
        public UserControlSetting()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;

        }

        private void Clear1()
        {
            textBoxUpdateUser.Clear();
            textBoxDeleteUser.Clear();
            //ID = "";

        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            try
            {

               // dataGridViewUser.DataSource = _controller.GetAllKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUser.Clear();
        }

        private void tabPageUpdateDelete_Leave(object sender, EventArgs e)
        {
            try
            {

                // dataGridViewUser.DataSource = _controller.GetAllKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {

        }
        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
