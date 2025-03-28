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
    public partial class UserControlReservation : UserControl
    {
        public UserControlReservation()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {

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
            //pesanan_id = "";


        }
    }
}
