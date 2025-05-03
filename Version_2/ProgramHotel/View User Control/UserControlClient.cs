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
using ProgramHotel.Controller;
using ProgramHotel.Model.Repository;
using ProgramHotel.Model.Entity;


namespace ProgramHotel.User_Control
{
    public partial class UserControlClient : UserControl
    {
        private TamuController _controller;
        

        private string tamu_id = "";
        
     

        private void FormTamu_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData()
        {
            var tamuList = _controller.GetAllTamu();
            dataGridViewClient.DataSource = _controller.GetAllTamu();
        }

        public UserControlClient()
        {
            InitializeComponent();
            _controller = new TamuController();
        }

        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            textBoxClientID.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            textBoxClientID1.Clear();
            tamu_id = "";

        }
     
        private void buttonAdd_Click(object sender, EventArgs e)
        {
        
            Tamu tamu = new Tamu
            {
                namaDepan = textBoxFirstName.Text,
                namaBelakang = textBoxLastName.Text,
                nomorTelepon = textBoxPhoneNo.Text,
                alamat = textBoxAddress.Text,
                nomor_KTP = textBoxClientID.Text
            };
     
            try
            {
                _controller.AddTamu(tamu);
                LoadData();
                MessageBox.Show("Tamu berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            try
            {
                
                dataGridViewClient.DataSource = _controller.GetAllTamu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhoneNo.Clear();
        }

        private void textBoxSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            string nomorTelepon = textBoxSearchPhoneNo.Text;

            try
            {
                if (!string.IsNullOrEmpty(nomorTelepon))
                {
              
                    dataGridViewClient.DataSource = _controller.SearchBynomorTelepon(nomorTelepon);
                }
                else
                {
                 
                    dataGridViewClient.DataSource = _controller.GetAllTamu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridViewClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tamu tamu = new Tamu
            {
               
                tamu_id = Convert.ToInt32(dataGridViewClient.SelectedRows[0].Cells[0].Value),
             
                namaDepan = textBoxFirstName1.Text,
                namaBelakang = textBoxLastName1.Text,
                nomorTelepon = textBoxPhoneNo1.Text,
                alamat = textBoxAddress1.Text,
                nomor_KTP = textBoxClientID1.Text
            };
            try
            {
                _controller.UpdateTamu(tamu);
                LoadData(); 
                MessageBox.Show("Tamu berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tabPageUpdateAndDeleteClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tamu_id = Convert.ToInt32(dataGridViewClient.SelectedRows[0].Cells[0].Value);

            try
            {
                _controller.DeleteTamu(tamu_id);
                LoadData(); 
                MessageBox.Show("Tamu berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tabPageUpdateAndDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                tamu_id = row.Cells[0].Value.ToString();
                textBoxClientID1.Text = row.Cells[5].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
