using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Model.Entity
{
    public class Pesanan
    {
        public string pesanan_id { get; set; }
        public int tamu_id { get; set; }
        public DateTime pesanan_IN { get; set; }
        public DateTime pesanan_OUT { get; set; }
        public string nomor_kamar { get; set; }
        public string tipe_kamar_P { get; set; }
        public string kamar_kosong_P { get; set; }
        public string harga_kamar_P { get; set; }
        public string nomor_KTP_P { get; set; }



       
    }
}
