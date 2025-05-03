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
using ProgramHotel.Controller;
using ProgramHotel.Model.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProgramHotel.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        private KaryawanController _controller;

        private string ID = "";

        private void FormKarywan_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            var karyawanList = _controller.GetAllKaryawan();
            dataGridViewUser.DataSource = _controller.GetAllKaryawan();
        }
        public UserControlSetting()
        {
            
            InitializeComponent();
            _controller = new KaryawanController();

        }


        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
           
        }

        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
            
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }
        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            string username = textBoxSearchUsername.Text;

            try
            {
                if (!string.IsNullOrEmpty(username))
                {

                    dataGridViewUser.DataSource = _controller.SearchByUsername(username);
                }
                else
                {

                    dataGridViewUser.DataSource = _controller.GetAllKaryawan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            try
            {

                dataGridViewUser.DataSource = _controller.GetAllKaryawan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateAndDeleteUsername_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Karyawan karyawan= new Karyawan
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };



            if (string.IsNullOrEmpty(karyawan.Username) || string.IsNullOrEmpty(karyawan.Password))
            {
                MessageBox.Show("Nama dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _controller.AddKaryawan(karyawan);
                LoadData();
                MessageBox.Show("Karyawan berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Karyawan karyawan = new Karyawan
            {

                ID = Convert.ToInt32(dataGridViewUser.SelectedRows[0].Cells[0].Value),

                Username = textBoxUsername1.Text,
                Password = textBoxPassword1.Text
            };
            try
            {
                _controller.UpdateKaryawan(karyawan);
                LoadData();
                MessageBox.Show("Data karyawan berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ID = Convert.ToInt32(dataGridViewUser.SelectedRows[0].Cells[0].Value);

            try
            {
                _controller.DeleteKaryawan(ID);
                LoadData();
                MessageBox.Show("Karyawan berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
            }
        }

        

        private void tabPageSearchUser_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }
        
    }
}
