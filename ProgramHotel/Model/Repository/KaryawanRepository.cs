using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProgramHotel.Model.Repository
{
    public class KaryawanRepository
    {
        
        public List<Karyawan> GetAll()
        {
            List<Karyawan> karyawanList = new List<Karyawan>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT id, username, password FROM karyawan";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        karyawanList.Add(new Karyawan
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString()
                        });
                    }
                }
            }

            return karyawanList;
        }
        public List<Karyawan> SearchByUsername(string username)
        {
            List<Karyawan> karyawanList = new List<Karyawan>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT id, username, password FROM karyawan WHERE username LIKE @username";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", "%" + username + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            karyawanList.Add(new Karyawan
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString()
                            });
                        }
                    }
                }
            }

            return karyawanList;
        }


        public int Create(Karyawan karyawan)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "INSERT INTO karyawan (username, password) VALUES (@username, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", karyawan.Username);
                    cmd.Parameters.AddWithValue("@password", karyawan.Password);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public int Update(Karyawan karyawan)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "UPDATE karyawan SET username = @username, password = @password WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", karyawan.ID);
                    cmd.Parameters.AddWithValue("@username", karyawan.Username);
                    cmd.Parameters.AddWithValue("@password", karyawan.Password);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public int Delete(int id)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "DELETE FROM karyawan WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}
