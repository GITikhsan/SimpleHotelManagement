using Mysqlx.Crud;
using Org.BouncyCastle.Cms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using ProgramHotel.Controller;
using ProgramHotel.Model.Entity;

namespace ProgramHotel.User_Control
{

    public partial class UserControlReservation : UserControl
    {
        public string pesanan_id = "", No, nomor_kamar = "", nomor_KTP_P = "", kamar_kosong = "", harga_kamar = "", reader, Free = "";
        private string connectionString = "Server=localhost;Database=reservasi_hotel;Uid=root;Pwd=;";



        private KamarController _KamarController;
        private PesananController _PesananController;

        public UserControlReservation()
        {
            InitializeComponent();
            dataGridViewRoom.CellClick += dataGridViewRoom_CellClick;
            _KamarController = new KamarController();
            _PesananController = new PesananController();
        }

        private void FormPesanan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FormKamar_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var pesananList = _PesananController.GetAllPesanan();
           //dataGridViewReservation.DataSource = _PesananController.GetAllPesanan();

            var kamarList = _KamarController.GetAllKamar();
            dataGridViewReservation.DataSource = _KamarController.GetAllKamar();
        }
     
        public void clear()
        {
            comboBoxType.SelectedIndex = 0;
            textBoxRoomNo.Clear();
            textBoxClientID.Clear();
            textBoxPrice2.Clear();

            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;

            tabControlReservation.SelectedTab = tabPageAddReservation;

        }
        private void clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            textBoxRoomNo1.Clear();
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            pesanan_id = "";


        }
        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            textBoxRoomNo.Clear();
            comboBoxType1.SelectedIndex = 0;
            textBoxRoomNo1.Clear();
        }
        private void tabPageUpdateAndCancelReservation_Click(object sender, EventArgs e)
        {

        }
        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            clear();
            clear1();
        }
        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }
        private void tabPageUpdateAndCancelReservation_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
            textBoxPesananID.Text = row.Cells[0].Value.ToString();
            comboBoxType1.SelectedItem = row.Cells[5].Value.ToString();
            textBoxRoomNo1.Text = row.Cells[2].Value.ToString();
            textBoxClientID1.Text = row.Cells[1].Value.ToString();
            dateTimePickerIn1.Value = Convert.ToDateTime(row.Cells[3].Value);
            dateTimePickerOut1.Value = Convert.ToDateTime(row.Cells[4].Value);
            Free = row.Cells[6].Value.ToString();
            if (Free == "Yes")
                radioButtonYes1.Checked = true;
            if (Free == "No")
                radioButtonNo1.Checked = true;
        }
        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];

                textBoxRoomNo.Text = row.Cells[0].Value.ToString();
                comboBoxType.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPrice2.Text = row.Cells[3].Value.ToString();
                Free = row.Cells[2].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes.Checked = true;
                if (Free == "No")
                    radioButtonNo.Checked = true;


            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Free == "No")
            {
                MessageBox.Show("Kamar ini tidak tersedia untuk dipesan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButtonYes.Checked)
                Free = "Yes";
            else if (radioButtonNo.Checked)
                Free = "No";
            else
                Free = string.Empty;

            if (comboBoxType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxRoomNo.Text) || string.IsNullOrWhiteSpace(textBoxClientID.Text) || string.IsNullOrWhiteSpace(Free))
            {
                MessageBox.Show("Harap isi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pesanan pesanan = new Pesanan
            {
                nomor_KTP_P = textBoxClientID.Text,
                pesanan_IN = dateTimePickerIn.Value,
                pesanan_OUT = dateTimePickerOut.Value,
                nomor_kamar = textBoxRoomNo.Text,
                tipe_kamar_P = comboBoxType.Text,
                kamar_kosong_P = Free,
                harga_kamar_P = textBoxPrice2.Text
            };
            Kamar kamar = new Kamar
            {
                nomor_kamar = textBoxRoomNo.Text,
                tipe_kamar = comboBoxType.Text,
                kamar_kosong = Free,
                harga_kamar = textBoxPrice2.Text
            };

            try
            {
                _PesananController.AddPesanan(pesanan, kamar);
                LoadData();
                MessageBox.Show("Pesanan berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        





        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            string query = "SELECT pesanan_id, pesanan.nomor_KTP_P, pesanan.nomor_kamar, pesanan.pesanan_IN, pesanan.pesanan_OUT, jenis_kamar.tipe_kamar, jenis_kamar.kamar_kosong " +
                             "FROM pesanan JOIN jenis_kamar ON pesanan.nomor_kamar = jenis_kamar.nomor_kamar";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewReservation.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            try
            {

                dataGridViewRoom.DataSource = _KamarController.GetAllKamar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            string nomor_KTP_P = textBoxSearch.Text;
            string query = @"SELECT pesanan.pesanan_id, pesanan.nomor_KTP_P, pesanan.nomor_kamar, pesanan.pesanan_IN, pesanan.pesanan_OUT, jenis_kamar.tipe_kamar, jenis_kamar.kamar_kosong FROM pesanan JOIN jenis_kamar ON pesanan.nomor_kamar = jenis_kamar.nomor_kamar WHERE pesanan.nomor_KTP_P LIKE @nomor_KTP_P";


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomor_KTP_P", "%" + nomor_KTP_P + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dataGridViewReservation.DataSource = dt;
                            }
                            else
                            {
                                dataGridViewReservation.DataSource = null;
                                MessageBox.Show("Tidak ada data yang cocok dengan pencarian.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            string nomor_kamar = textBoxSearchRoomNo.Text;

            try
            {
                if (!string.IsNullOrEmpty(nomor_kamar))
                {

                    dataGridViewRoom.DataSource = _KamarController.SearchBynomorKamar(nomor_kamar);
                }
                else
                {

                    dataGridViewRoom.DataSource = _KamarController.GetAllKamar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            else if (radioButtonNo1.Checked)
                Free = "No";
            else
                Free = string.Empty;

            int pesanan_id = Convert.ToInt32(textBoxPesananID.Text);


            if (string.IsNullOrWhiteSpace(textBoxClientID1.Text) ||
                comboBoxType1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBoxRoomNo1.Text))

            {
                MessageBox.Show("Harap isi semua kolom yang diperlukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query1 = "UPDATE pesanan SET pesanan_IN = @pesanan_IN, pesanan_OUT = @pesanan_OUT, nomor_kamar = @nomor_kamar, tipe_kamar_P = @tipe_kamar_P, kamar_kosong_P = @kamar_kosong_P, nomor_KTP_P = @nomor_KTP_P WHERE pesanan_id = @pesanan_id";
            string query2 = "UPDATE jenis_kamar SET nomor_kamar = @nomor_kamar, tipe_kamar = @tipe_kamar, kamar_kosong= @kamar_kosong WHERE nomor_kamar = @nomor_kamar";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {

                        using (MySqlCommand cmd = new MySqlCommand(query1, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@nomor_KTP_P", textBoxClientID1.Text);
                            cmd.Parameters.AddWithValue("@pesanan_IN", dateTimePickerIn1.Value);
                            cmd.Parameters.AddWithValue("@pesanan_OUT", dateTimePickerOut1.Value);
                            cmd.Parameters.AddWithValue("@tipe_kamar_P", comboBoxType1.Text);
                            cmd.Parameters.AddWithValue("@kamar_kosong_P", Free);
                            cmd.Parameters.AddWithValue("@nomor_kamar", textBoxRoomNo1.Text);
                            cmd.Parameters.AddWithValue("@pesanan_id", pesanan_id);
                            cmd.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(query2, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@tipe_kamar", comboBoxType1.SelectedItem.ToString());
                            cmd2.Parameters.AddWithValue("@kamar_kosong", Free);
                            cmd2.Parameters.AddWithValue("@nomor_kamar", textBoxRoomNo1.Text);

                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Pesanan berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
               
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih baris dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string pesanan_id = dataGridViewReservation.SelectedRows[0].Cells[0].Value.ToString();
            string nomor_kamar = dataGridViewReservation.SelectedRows[0].Cells[2].Value.ToString();

            try
            {
                _PesananController.DeletePesanan(pesanan_id, nomor_kamar);
                LoadData();
                MessageBox.Show("Tamu berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRoomNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchReservation_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRoomNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonYes1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}