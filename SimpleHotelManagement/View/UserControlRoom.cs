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
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
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
            //nomor_kamar = "";
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

                //dataGridViewRoom.DataSource = _controller.GetAllKamar();
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
        private void tabPageUpdateAndDeleteRoom_Leave(object sender, EventArgs e)
        {
            clear1();
        }
        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {

        }

        private void tabPageAddRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
