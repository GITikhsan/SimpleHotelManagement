using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AMRConnector;
using MySql.Data.MySqlClient;
using ProgramHotel.Controller;
using ProgramHotel.Model.Repository;
using ProgramHotel.Model.Entity;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace ProgramHotel.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        private string nomor_kamar = "", Free = "";
      
        private KamarController _controller;

        private void FormKamar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var kamarList = _controller.GetAllKamar();
            dataGridViewRoom.DataSource = _controller.GetAllKamar();
        }

        public UserControlRoom()
        {
            InitializeComponent();
            _controller = new KamarController();
        }

        public void clear()
        {
            comboBoxType.SelectedIndex = 0;
          
            RoomNumber.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            textBoxPrice.Clear();
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void clear1()
        {
            comboBoxType1.SelectedIndex = 0;
           
            textBoxRoomNumber1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            textBoxPrice1.Clear();
            nomor_kamar = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";

            Kamar kamar = new Kamar
            {
                nomor_kamar = RoomNumber.Text.ToString(),
                tipe_kamar = comboBoxType.SelectedItem.ToString(),
                kamar_kosong = Free,
                harga_kamar = textBoxPrice.Text
            };
            try
            {
                _controller.AddKamar(kamar);
                LoadData();
                MessageBox.Show("Kamar berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            clear();
            clear1();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            try
            {

                dataGridViewRoom.DataSource = _controller.GetAllKamar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            string nomor_kamar = textBoxSearchRoomNo.Text;

            try
            {
                if (!string.IsNullOrEmpty(nomor_kamar))
                {

                    dataGridViewRoom.DataSource = _controller.SearchBynomorKamar(nomor_kamar);
                }
                else
                {

                    dataGridViewRoom.DataSource = _controller.GetAllKamar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                nomor_kamar = row.Cells["nomor_kamar"].Value.ToString();
                textBoxRoomNumber1.Text = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPrice1.Text = row.Cells[3].Value.ToString ();
                Free = row .Cells[2].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";

            if (dataGridViewRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kamar kamar = new Kamar
            {

                nomor_kamar = textBoxRoomNumber1.Text,

                tipe_kamar = comboBoxType1.SelectedItem.ToString(),
                harga_kamar = textBoxPrice1.Text,
                kamar_kosong = Free
            };
            try
            {
                _controller.UpdateKamar(kamar);
                LoadData();
                MessageBox.Show("Kamar berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomor_kamaar = dataGridViewRoom.SelectedRows[0].Cells["nomor_kamar"].Value.ToString();

            try
            {
                _controller.DeleteKamar(nomor_kamar);
                LoadData();
                MessageBox.Show("Tamu berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void tabPageUpdateAndDeleteRoom_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonYes1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBoxRoomNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRoomNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageUpdateAndDeleteRoom_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
