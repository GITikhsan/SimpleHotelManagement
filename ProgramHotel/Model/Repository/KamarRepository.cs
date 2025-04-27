using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramHotel.Model.Repository
{
    public class KamarRepository
    {
        

        public List<Kamar> GetAll()
        {
            List<Kamar> kamarList = new List<Kamar>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT nomor_kamar, tipe_kamar, kamar_kosong, harga_kamar FROM jenis_kamar";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kamarList.Add(new Kamar
                        {
                            nomor_kamar = reader["nomor_kamar"].ToString(),
                            tipe_kamar = reader["tipe_kamar"].ToString(),
                            kamar_kosong = reader["kamar_kosong"].ToString(),
                            harga_kamar = reader["harga_kamar"].ToString()
                        });

                    }
                }

                return kamarList;
            }
        }
        public List<Kamar> SearchBynomorKamar(string nomor_kamar)
        {
            List<Kamar> kamarList = new List<Kamar>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT * FROM jenis_kamar WHERE nomor_kamar LIKE @nomor_kamar";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomor_kamar", "%" + nomor_kamar + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kamarList.Add(new Kamar
                            {
                                nomor_kamar = reader["nomor_kamar"].ToString(),
                                tipe_kamar = reader["tipe_kamar"].ToString(),
                                kamar_kosong = reader["kamar_kosong"].ToString(),
                                harga_kamar = reader["harga_kamar"].ToString()
                            });
                        }
                    }
                }
            }

            return kamarList;
        }
        public int Create(Kamar kamar)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "INSERT INTO jenis_kamar (nomor_kamar, tipe_kamar, kamar_kosong, harga_kamar) VALUES (@nomor_kamar, @tipe_kamar, @kamar_kosong, @harga_kamar)";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomor_kamar", kamar.nomor_kamar);
                    cmd.Parameters.AddWithValue("@tipe_kamar", kamar.tipe_kamar);
                    cmd.Parameters.AddWithValue("@kamar_kosong", kamar.kamar_kosong);
                    cmd.Parameters.AddWithValue("@harga_kamar", kamar.harga_kamar);
                   

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
        public int Update(Kamar kamar)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "UPDATE jenis_kamar SET nomor_kamar = @nomor_kamar, tipe_kamar = @tipe_kamar, kamar_kosong= @kamar_kosong, harga_kamar = @harga_kamar WHERE nomor_kamar = @nomor_kamar";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomor_kamar", kamar.nomor_kamar);
                    cmd.Parameters.AddWithValue("@tipe_kamar", kamar.tipe_kamar);
                    cmd.Parameters.AddWithValue("@kamar_kosong", kamar.kamar_kosong);
                    cmd.Parameters.AddWithValue("@harga_kamar", kamar.harga_kamar);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
  

        public int Delete(string nomor_kamar)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query = "DELETE FROM jenis_kamar WHERE nomor_kamar = @nomor_kamar";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomor_kamar", nomor_kamar);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }


    }
   
}
