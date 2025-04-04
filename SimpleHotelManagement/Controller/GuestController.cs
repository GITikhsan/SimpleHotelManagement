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
        public List<Guest> SearchByphone_number(string phone_number)
        {
            GuestRepository repository = new GuestRepository();
            return repository.SearchByphone_number(phone_number);
        }
    }
}
