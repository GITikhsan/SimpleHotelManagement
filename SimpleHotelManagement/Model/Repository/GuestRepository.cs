using MySql.Data.MySqlClient;
using SimpleHotelManagement.Context;
using SimpleHotelManagement.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleHotelManagement.Model.Repository
{
    public class GuestRepository
    {
        public List<Guest> GetAll()
        {
            List<Guest> guestList = new List<Guest>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT ";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guestList.Add(new Guest
                        {
                            guest_id = Convert.ToInt32(reader["guest_id"]),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name "].ToString(),
                            phone_number = reader["phone_number"].ToString(),
                            address = reader["address"].ToString(),
                            ID_card_number = reader["ID_card_number"].ToString()
                        });
                    }
                         
                }
            }

            return guestList;
        }
        public List<Guest> SearchByphone_number(string phone_number)
        {
            List<Guest> guestList = new List<Guest>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT * FROM guests WHERE phone_number LIKE @phone_number";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@phone_number", "%" + phone_number + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guestList.Add(new Guest
                            {
                                guest_id = Convert.ToInt32(reader["guest_id"]),
                                first_name = reader["first_name"].ToString(),
                                last_name = reader["last_name"].ToString(),
                                phone_number = reader["phone_number"].ToString(),
                                address = reader["address"].ToString(),
                                ID_card_number = reader["ID_card_number"].ToString()



                            });
                        }
                    }
                }
            }

            return guestList;
        }
        public int Create(Guest guest)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "INSERT INTO guests (first_name, last_name, phone_number, address, ID_card_number) " + "VALUES (@first_name, @last_name, @phone_number, @address, @ID_card_number)";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@first_name", guest.first_name);
                    cmd.Parameters.AddWithValue("@last_name", guest.last_name);
                    cmd.Parameters.AddWithValue("@phone_number", guest.phone_number);
                    cmd.Parameters.AddWithValue("@address", guest.address);
                    cmd.Parameters.AddWithValue("@ID_card_number", guest.ID_card_number);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
        public int Update(Guest guest)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "UPDATE guests SET first_name = @first_name, last_name = @last_name, phone_number = @phone_number, address = @address, ID_card_number = @ID_card_number WHERE guest_id = @guest_id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@guest_id", guest.guest_id);
                    cmd.Parameters.AddWithValue("@first_name", guest.first_name);
                    cmd.Parameters.AddWithValue("@last_name", guest.last_name);
                    cmd.Parameters.AddWithValue("@phone_number", guest.phone_number);
                    cmd.Parameters.AddWithValue("@address", guest.address);
                    cmd.Parameters.AddWithValue("@ID_card_number", guest.ID_card_number);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
        public int Delete(int guest_id) {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "DELETE FROM guests WHERE guest_id = @guest_id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@guest_id", guest_id);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}
