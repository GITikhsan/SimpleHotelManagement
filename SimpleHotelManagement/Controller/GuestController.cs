using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProgramHotel.Model;
using ProgramHotel.Model.Entity;
using ProgramHotel.Model.Repository;

namespace SimpleHotelManagement.Controller
{
    public class GuestController
    {
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
