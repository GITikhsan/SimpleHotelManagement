using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SimpleHotelManagement.Model;
using SimpleHotelManagement.Model.Entity;
using SimpleHotelManagement.Model.Repository;

namespace SimpleHotelManagement.Controller
{
    public class GuestController
    {
        private GuestRepository _repository;
        public GuestController()
        {
            _repository = new GuestRepository();
        }

        public List<Guest> GetAllGuest()
        {
            return _repository.GetAll();
        }
    }
}
