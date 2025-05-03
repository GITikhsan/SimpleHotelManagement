using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Model.Repository
{
    public class TamuRepository
    {
        public List<Tamu> GetAll()
        {
            List<Tamu> tamuList = new List<Tamu>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT tamu_id, namaDepan, namaBelakang, nomorTelepon, alamat, nomor_KTP FROM tamu";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tamuList.Add(new Tamu
                        {
                            tamu_id = Convert.ToInt32(reader["tamu_id"]),
                            namaDepan = reader["namaDepan"].ToString(),
                            namaBelakang = reader["namaBelakang"].ToString(),
                            nomorTelepon = reader["nomorTelepon"].ToString(),
                            alamat = reader["alamat"].ToString(),
                            nomor_KTP = reader["nomor_KTP"].ToString()
                        });
                    }
                }
            }

            return tamuList;
        }
        public List<Tamu> SearchBynomorTelepon(string nomorTelepon)
        {
            List<Tamu> tamuList = new List<Tamu>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT * FROM tamu WHERE nomorTelepon LIKE @nomorTelepon";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomorTelepon", "%" + nomorTelepon + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tamuList.Add(new Tamu
                            {
                                tamu_id = Convert.ToInt32(reader["tamu_id"]),
                                namaDepan = reader["namaDepan"].ToString(),
                                namaBelakang = reader["namaBelakang"].ToString(),
                                nomorTelepon = reader["nomorTelepon"].ToString(),
                                alamat = reader["alamat"].ToString(),
                                nomor_KTP = reader["nomor_KTP"].ToString()
                            });
                        }
                    }
                }
            }

            return tamuList;
        }

      
        public int Create(Tamu tamu)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "INSERT INTO tamu (namaDepan, namaBelakang, nomorTelepon, alamat, nomor_KTP) " +  "VALUES (@namaDepan, @namaBelakang, @nomorTelepon, @alamat, @nomor_KTP)";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@namaDepan", tamu.namaDepan);
                    cmd.Parameters.AddWithValue("@namaBelakang", tamu.namaBelakang);
                    cmd.Parameters.AddWithValue("@nomorTelepon", tamu.nomorTelepon);
                    cmd.Parameters.AddWithValue("@alamat", tamu.alamat);
                    cmd.Parameters.AddWithValue("@nomor_KTP", tamu.nomor_KTP);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

    
        public int Update(Tamu tamu)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "UPDATE tamu SET namaDepan = @namaDepan, namaBelakang = @namaBelakang, nomorTelepon = @nomorTelepon, alamat = @alamat, nomor_KTP = @nomor_KTP WHERE tamu_id = @tamu_id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@tamu_id", tamu.tamu_id);
                    cmd.Parameters.AddWithValue("@namaDepan", tamu.namaDepan);
                    cmd.Parameters.AddWithValue("@namaBelakang", tamu.namaBelakang);
                    cmd.Parameters.AddWithValue("@nomorTelepon", tamu.nomorTelepon);
                    cmd.Parameters.AddWithValue("@alamat", tamu.alamat);
                    cmd.Parameters.AddWithValue("@nomor_KTP", tamu.nomor_KTP);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

   
        public int Delete(int tamu_id)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "DELETE FROM tamu WHERE tamu_id = @tamu_id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@tamu_id", tamu_id);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}


