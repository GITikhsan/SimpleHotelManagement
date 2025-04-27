using ProgramHotel.Model;
using ProgramHotel.Model.Entity;
using ProgramHotel.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Controller
{
    public class TamuController
    {
        private TamuRepository _repository;

        public TamuController()
        {
            _repository = new TamuRepository();
        }

        public List<Tamu> GetAllTamu()
        {
            return _repository.GetAll();
        }
        public List<Tamu> SearchBynomorTelepon(string nomorTelepon)
        {
            TamuRepository repository = new TamuRepository();
            return repository.SearchBynomorTelepon(nomorTelepon);
        }

        public void AddTamu(Tamu tamu)
        {
            if (string.IsNullOrEmpty(tamu.namaDepan) || string.IsNullOrEmpty(tamu.namaBelakang)|| string.IsNullOrEmpty(tamu.nomorTelepon) || string.IsNullOrEmpty(tamu.nomorTelepon) || string.IsNullOrEmpty(tamu.alamat) || string.IsNullOrEmpty(tamu.nomor_KTP)) 
            {
                throw new ArgumentException("Data tidak boleh kosong.");
            }


            _repository.Create(tamu);
        }

        public void UpdateTamu(Tamu tamu)
        {
            if (string.IsNullOrEmpty(tamu.namaDepan) || string.IsNullOrEmpty(tamu.namaBelakang) || string.IsNullOrEmpty(tamu.nomorTelepon) || string.IsNullOrEmpty(tamu.nomorTelepon) || string.IsNullOrEmpty(tamu.alamat) || string.IsNullOrEmpty(tamu.nomor_KTP))
            {
                throw new ArgumentException("Data tidak boleh kosong.");
            }

            if (tamu.tamu_id <= 0)
            {
                throw new ArgumentException("Tamu tidak valid.");
            }

            _repository.Update(tamu);
        }

        public void DeleteTamu(int tamu_id)
        {

            if (tamu_id <= 0)
            {
                throw new ArgumentException("Tamu tidak valid.");
            }

            _repository.Delete(tamu_id);
        }
    }
}