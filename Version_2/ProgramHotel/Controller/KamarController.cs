using ProgramHotel.Model.Entity;
using ProgramHotel.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Controller
{
    public class KamarController
    {
        private KamarRepository _repository;

        public KamarController()
        {
            _repository = new KamarRepository();
        }

        public List<Kamar> GetAllKamar()
        {
            return _repository.GetAll();
        }
        public List<Kamar> SearchBynomorKamar(string nomor_kamar)
        {
            return _repository.SearchBynomorKamar(nomor_kamar);
        }
        public void AddKamar(Kamar kamar)
        {
            if (string.IsNullOrEmpty(kamar.nomor_kamar) || string.IsNullOrEmpty(kamar.tipe_kamar) || string.IsNullOrEmpty(kamar.kamar_kosong) || string.IsNullOrEmpty(kamar.harga_kamar))
            { 
                throw new ArgumentException("Data tidak boleh kosong.");
            }

            _repository.Create(kamar);
        }

        public void UpdateKamar(Kamar kamar)
        {
            if (string.IsNullOrEmpty(kamar.nomor_kamar) || string.IsNullOrEmpty(kamar.tipe_kamar) || string.IsNullOrEmpty(kamar.kamar_kosong) || string.IsNullOrEmpty(kamar.harga_kamar))
            {
                throw new ArgumentException("Data tidak boleh kosong.");
            }
            _repository.Update(kamar);
        }

        public void DeleteKamar(string nomor_kamar)
        {
            _repository.Delete(nomor_kamar);
        }

        
    }
    
}
