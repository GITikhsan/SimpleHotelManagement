using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramHotel.Model;
using ProgramHotel.Model.Entity;
using ProgramHotel.Model.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProgramHotel.Controller
{
    public class KaryawanController
    {
       
        private KaryawanRepository _repository;

        public KaryawanController()
        {
            _repository = new KaryawanRepository();
        }

        public List<Karyawan> GetAllKaryawan()
        {
            return _repository.GetAll();
        }
        public List<Karyawan> SearchByUsername(string username)
        {
            KaryawanRepository repository = new KaryawanRepository(); 
            return repository.SearchByUsername(username);
        }
        public void AddKaryawan(Karyawan karyawan)
        {
            if (string.IsNullOrEmpty(karyawan.Username) || string.IsNullOrEmpty(karyawan.Password))
            {
                throw new ArgumentException("Username dan password tidak boleh kosong.");
            }

            _repository.Create(karyawan);
        }

        public void UpdateKaryawan(Karyawan karyawan)
        {
            if (karyawan.ID <= 0)
            {
                throw new ArgumentException("Tamu_ID tidak valid.");
            }

            _repository.Update(karyawan);
        }

        public void DeleteKaryawan(int ID)
        {
            if (ID <= 0)
            {
                throw new ArgumentException("Tamu_ID tidak valid.");
            }

            _repository.Delete(ID);
        }

    }

}

