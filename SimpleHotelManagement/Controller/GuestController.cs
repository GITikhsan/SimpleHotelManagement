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
        public void AddGuest(Guest guest)
        {
            if (string.IsNullOrEmpty(guest.first_name) || string.IsNullOrEmpty(guest.last_name) || string.IsNullOrEmpty(guest.phone_number) || string.IsNullOrEmpty(guest.phone_number) || string.IsNullOrEmpty(guest.address) || string.IsNullOrEmpty(guest.ID_card_number))
            {
                throw new ArgumentException("Data cannot be empty!");
            }
            _repository.Create(guest);
        }
        public void UpdateGuest(Guest guest)
        {
            if (string.IsNullOrEmpty(guest.first_name) || string.IsNullOrEmpty(guest.last_name) || string.IsNullOrEmpty(guest.phone_number) || string.IsNullOrEmpty(guest.phone_number) || string.IsNullOrEmpty(guest.address) || string.IsNullOrEmpty(guest.ID_card_number))
            {
                throw new ArgumentException("Data cannot be empty!");
            }
            _repository.Update(guest);
        }
        public void DeleteGuest(int guest_id)
        {
            if (guest_id <= 0)
            {
                throw new ArgumentException("Invalid guest ID!");
            }
            _repository.Delete(guest_id);
        }
    }
}
