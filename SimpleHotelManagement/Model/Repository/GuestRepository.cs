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
    }
}
