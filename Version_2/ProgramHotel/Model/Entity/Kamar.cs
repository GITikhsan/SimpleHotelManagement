using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Model.Entity
{
    public class Kamar
    {
        public string nomor_kamar { get; set; }
        public string tipe_kamar { get; set; }
        public string kamar_kosong { get; set; } 
        public string harga_kamar { get; set; }
    }
}
