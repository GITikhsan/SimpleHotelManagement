using ProgramHotel.Model.Entity;
using ProgramHotel.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Controller
{
    public class PesananController
    {

        private PesananRepository _repository;
       

        public PesananController()
        {
            _repository = new PesananRepository();
            
        }
     
        public List<Pesanan> GetAllPesanan()
        {
            return _repository.GetAll();
        }
        public void AddPesanan(Pesanan pesanan, Kamar kamar)
        {
            if (string.IsNullOrEmpty(kamar.nomor_kamar) || string.IsNullOrEmpty(kamar.tipe_kamar) || string.IsNullOrEmpty(kamar.kamar_kosong) || string.IsNullOrEmpty(kamar.harga_kamar))
            {
                throw new ArgumentException("Data tidak boleh kosong.");
            }
            if (string.IsNullOrEmpty(pesanan.nomor_KTP_P) || string.IsNullOrEmpty(pesanan.tipe_kamar_P) || string.IsNullOrEmpty(pesanan.kamar_kosong_P) || string.IsNullOrEmpty(pesanan.harga_kamar_P))
            {
                throw new ArgumentException("Data tidak boleh kosong.");
            }
            _repository.Create(pesanan, kamar);
        }
        public void DeletePesanan(string pesanan_id, string nomor_kamar)
        {
            _repository.Delete(pesanan_id, nomor_kamar);
        }


    }

}
