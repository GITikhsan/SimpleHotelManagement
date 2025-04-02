using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
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
            List<Guest> tamuList = new List<Guest>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT ";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tamuList.Add(new Guest
                        {
                            /*tamu_id = Convert.ToInt32(reader["tamu_id"]),
                            namaDepan = reader["namaDepan"].ToString(),
                            namaBelakang = reader["namaBelakang"].ToString(),
                            nomorTelepon = reader["nomorTelepon"].ToString(),
                            alamat = reader["alamat"].ToString(),
                            nomor_KTP = reader["nomor_KTP"].ToString()*/
                        });
                    }
                }
            }

            return tamuList;
        }
    }
}
