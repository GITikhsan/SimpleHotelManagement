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
using AMRConnector;
using SimpleHotelManagement.Controller;
using SimpleHotelManagement.Model.Repository;
using SimpleHotelManagement.Model.Entity;

namespace SimpleHotelManagement.View
{
    public partial class UserControlGuest : UserControl
    {

        private GuestController _controller;
        private void FormGuest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var guestList = _controller.GetAllGuest();
            dataGridViewClient.DataSource = _controller.GetAllGuest();
        }
        public UserControlGuest()
        {
            InitializeComponent(); 
            _controller = new GuestController();
        }
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            textBoxClientID.Clear();
            tabControlClient.SelectedTab = tabPageAddGuest;
        }

        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            textBoxClientID1.Clear();
            

        }
        private void tabPageAddGuest_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchGuest_Enter(object sender, EventArgs e)
        {
            try
            {
                dataGridViewClient.DataSource = _controller.GetAllGuest();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageSearchGuest_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhoneNo.Clear();
        }

        private void tabPageUpdateAndDeleteGuest_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Guest guest = new Guest
            {
                first_name = textBoxFirstName.Text,
                last_name = textBoxLastName.Text,
                phone_number = textBoxPhoneNo.Text,
                address = textBoxAddress.Text,
                ID_card_number = textBoxClientID.Text
            };

            try
            {
                _controller.AddGuest(guest);
                LoadData();
                MessageBox.Show("Guest successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string phone_number = textBoxSearchPhoneNo.Text;
            try
            {
                var guestList = _controller.SearchByphone_number(phone_number);
                if (guestList.Count > 0)
                {
                    dataGridViewClient.DataSource = guestList;
                }
                else
                {
                    MessageBox.Show("Guest not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest
            {
                guest_id = Convert.ToInt32(textBoxClientID1.Text),
                first_name = textBoxFirstName1.Text,
                last_name = textBoxLastName1.Text,
                phone_number = textBoxPhoneNo1.Text,
                address = textBoxAddress1.Text,
                ID_card_number = textBoxClientID1.Text
            };

            try
            {
                _controller.UpdateGuest(guest);
                LoadData();
                MessageBox.Show("Guest successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int guest_id = Convert.ToInt32(textBoxClientID1.Text);
            try
            {
                _controller.DeleteGuest(guest_id);
                LoadData();
                MessageBox.Show("Guest successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageUpdateAndDeleteGuest_Click(object sender, EventArgs e)
        {

        }

        private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchGuest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClientID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void UserControlGuest_Load(object sender, EventArgs e)
        {

        }
    }
}
