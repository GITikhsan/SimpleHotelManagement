using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramHotel.Model.Repository
{
    public class PesananRepository
    {
       
       public List<Pesanan>GetAll()
        {
            List<Pesanan> pesananList = new List<Pesanan>();
           

            using (DbContext context = new DbContext())
            {
                string query = @"SELECT pesanan_id, tamu_id, pesanan_IN, pesanan_OUT, nomor_kamar, tipe_kamar_P,  kamar_kosong_P, harga_kamar_P, nomor_KTP_P FROM pesanan";

                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pesananList.Add(new Pesanan
                        {
                            pesanan_id = reader["pesanan_id"].ToString(),
                            tamu_id = Convert.ToInt32(reader["tamu_id"]),
                            pesanan_IN = Convert.ToDateTime(reader["pesanan_IN"]),
                            pesanan_OUT = Convert.ToDateTime(reader["pesanan_OUT"]),
                            nomor_kamar = reader["nomor_kamar"].ToString(),
                            tipe_kamar_P = reader["tipe_kamar_P"].ToString(),
                            kamar_kosong_P = reader["kamar_kosong_P"].ToString(),
                            harga_kamar_P = reader["harga_kamar_P"].ToString(),
                            nomor_KTP_P = reader["nomor_KTP_P"].ToString()

                        });

               
                    }
                }
                return pesananList;
                
            }
        }
        public int Create(Pesanan pesanan, Kamar kamar)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                string query1 = @"INSERT INTO pesanan (pesanan_IN, pesanan_OUT, nomor_kamar, tipe_kamar_P, kamar_kosong_P, harga_kamar_P, nomor_KTP_P) VALUES (@pesanan_IN, @pesanan_OUT, @nomor_kamar, @tipe_kamar_P, @kamar_kosong_P, @harga_kamar_P, @nomor_KTP_P)";

                string query2 = @"UPDATE jenis_kamar SET tipe_kamar = @tipe_kamar, kamar_kosong = @kamar_kosong, harga_kamar = @harga_kamar WHERE nomor_kamar = @nomor_kamar";


                using (MySqlCommand cmd1 = new MySqlCommand(query1, context.Connection))
                {
                    cmd1.Parameters.AddWithValue("@nomor_KTP_P", pesanan.nomor_KTP_P);
                    cmd1.Parameters.AddWithValue("@pesanan_IN", pesanan.pesanan_IN);
                    cmd1.Parameters.AddWithValue("@pesanan_OUT", pesanan.pesanan_OUT);
                    cmd1.Parameters.AddWithValue("@nomor_kamar", pesanan.nomor_kamar);
                    cmd1.Parameters.AddWithValue("@tipe_kamar_P", pesanan.tipe_kamar_P);
                    cmd1.Parameters.AddWithValue("@kamar_kosong_P", pesanan.kamar_kosong_P);
                    cmd1.Parameters.AddWithValue("@harga_kamar_P", pesanan.harga_kamar_P);
                    cmd1.ExecuteNonQuery();
                }

                using (MySqlCommand cmd2 = new MySqlCommand(query2, context.Connection))
                {
                    cmd2.Parameters.AddWithValue("@tipe_kamar", kamar.tipe_kamar);
                    cmd2.Parameters.AddWithValue("@kamar_kosong", kamar.kamar_kosong);
                    cmd2.Parameters.AddWithValue("@harga_kamar", kamar.harga_kamar);
                    cmd2.Parameters.AddWithValue("@nomor_kamar", kamar.nomor_kamar);
                    cmd2.ExecuteNonQuery();
                }


            }
            return result;
        }


        public int Delete(string pesanan_id, string nomor_kamar)
        {
            int result = 0;


            using (DbContext context = new DbContext())
            {
                string deleteQuery = "DELETE FROM pesanan WHERE pesanan_id = @pesanan_id";
                string updateQuery = "UPDATE jenis_kamar SET kamar_kosong = 'Yes' WHERE nomor_kamar = @nomor_kamar";


                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, context.Connection))
                {
                    deleteCmd.Parameters.AddWithValue("@pesanan_id", pesanan_id);
                    result = deleteCmd.ExecuteNonQuery();
                }




                // Perbarui status kamar
                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, context.Connection))
                {

                    updateCmd.Parameters.AddWithValue("@nomor_kamar", nomor_kamar);
                    updateCmd.ExecuteNonQuery();

                }
                return result;


            }
        }
    }

}





/*using MySql.Data.MySqlClient;
using ProgramHotel.Context;
using ProgramHotel.Model.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramHotel.Model.Repository
{
    public class PesananRepository
    {
        public List<Pesanan> GetAll()
        {
            List<Pesanan> pesananList = new List<Pesanan>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT pesanan_id, tamu_id, nomor_kamar, pesanan_IN, pesanan_OUT, kamar_kosong_P, tipe_kamar_P, nomor_KTP_P, harga_kamar_P FROM pesanan";

                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pesananList.Add(new Pesanan
                        {
                            pesanan_id = Convert.ToInt32(reader["pesanan_id"]),
                            tamu_id = Convert.ToInt32(reader["tamu_id"]),
                            nomor_kamar = reader["nomor_kamar"].ToString(),
                            pesanan_IN = Convert.ToDateTime(reader["pesanan_IN"]),
                            pesanan_OUT = Convert.ToDateTime(reader["pesanan_OUT"]),
                            kamar_kosong_P = reader["kamar_kosong_P"].ToString(),
                            tipe_kamar_P = reader["tipe_kamar"].ToString(),
                            nomor_KTP_P = reader["nomor_KTP_P"].ToString(),
                            harga_kamar_P = reader["harga_kamar_P"].ToString(),

                        });
                    }
                }
            }

            return pesananList;
        }

        public List<Pesanan> SearchByKTP(string nomor_KTP_P)
        {
            List<Pesanan> pesananList = new List<Pesanan>();

            using (DbContext context = new DbContext())
            {
                string query = "SELECT pesanan_id, nomor_kamar, pesanan_IN, pesanan_OUT, nomor_KTP_P FROM pesanan";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@nomor_KTP_P", "%" + nomor_KTP_P + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pesananList.Add(new Pesanan
                            {
                                pesanan_id = Convert.ToInt32(reader["pesanan_id"]),
                                //tamu_id = Convert.ToInt32(reader["tamu_id"]),
                                nomor_kamar = reader["nomor_kamar"].ToString(),
                                pesanan_IN = Convert.ToDateTime(reader["pesanan_IN"]),
                                pesanan_OUT = Convert.ToDateTime(reader["pesanan_OUT"]),
                                //kamar_kosong_P = reader["kamar_kosong_P"].ToString(),
                                //tipe_kamar_P = reader["tipe_kamar"].ToString(),
                                nomor_KTP_P = reader["nomor_KTP_P"].ToString(),
                                //harga_kamar_P = reader["harga_kamar_P"].ToString(),


                            });
                        }
                    }
                }
            }

            return pesananList;
        }
        /////////public List<Pesanan> SearchBynomorKamar(string nomor_kamar)
        {
            List<Pesanan> pesananList = new List<Pesanan>();

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
                            pesananList.Add(new Pesanan
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

            return pesananList;
        }///////////

        public int Create(Pesanan pesanan)
        {
             using (DbContext context = new DbContext())
            {
                string query1 = @"
                    INSERT INTO pesanan (pesanan_IN, pesanan_OUT, nomor_kamar, tipe_kamar_P, kamar_kosong_P, harga_kamar_P, nomor_KTP_P) 
                    VALUES (@pesanan_IN, @pesanan_OUT, @nomor_kamar, @tipe_kamar_P, @kamar_kosong_P, @harga_kamar_P, @nomor_KTP_P)";

                string query2 = @"
                    UPDATE jenis_kamar 
                    SET tipe_kamar = @tipe_kamar, kamar_kosong = @kamar_kosong, harga_kamar = @harga_kamar 
                    WHERE nomor_kamar = @nomor_kamar";

                try
                {
                    context.Connection.Open();

                    using (MySqlTransaction transaction = context.Connection.BeginTransaction())
                    {
                        try
                        {
                            // Menambahkan data pesanan
                            using (MySqlCommand cmd1 = new MySqlCommand(query1, context.Connection, transaction))
                            {
                                cmd1.Parameters.AddWithValue("@nomor_KTP_P", pesanan.NomorKTP);
                                cmd1.Parameters.AddWithValue("@pesanan_IN", pesanan.PesananIN);
                                cmd1.Parameters.AddWithValue("@pesanan_OUT", pesanan.PesananOUT);
                                cmd1.Parameters.AddWithValue("@nomor_kamar", pesanan.NomorKamar);
                                cmd1.Parameters.AddWithValue("@tipe_kamar_P", pesanan.TipeKamar);
                                cmd1.Parameters.AddWithValue("@kamar_kosong_P", pesanan.KamarKosong);
                                cmd1.Parameters.AddWithValue("@harga_kamar_P", pesanan.HargaKamar);
                                cmd1.ExecuteNonQuery();
                            }

                            // Memperbarui data kamar
                            using (MySqlCommand cmd2 = new MySqlCommand(query2, context.Connection, transaction))
                            {
                                cmd2.Parameters.AddWithValue("@tipe_kamar", kamar.TipeKamar);
                                cmd2.Parameters.AddWithValue("@kamar_kosong", kamar.KamarKosong);
                                cmd2.Parameters.AddWithValue("@harga_kamar", kamar.HargaKamar);
                                cmd2.Parameters.AddWithValue("@nomor_kamar", kamar.NomorKamar);
                                cmd2.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true; // Indikasi sukses
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    context.Connection.Close();
                }
        }

        public void Update(Pesanan pesanan)
        {
            using (DbContext context = new DbContext())
            {
                using (MySqlTransaction transaction = context.Connection.BeginTransaction())
                {
                    try
                    {
                        // Query untuk memperbarui tabel pesanan
                        string updatePesananQuery = @"
                    UPDATE pesanan 
                    SET 
                        pesanan_IN = @pesanan_IN, 
                        pesanan_OUT = @pesanan_OUT, 
                        nomor_kamar = @nomor_kamar, 
                        tipe_kamar_P = @tipe_kamar_P, 
                        kamar_kosong_P = @kamar_kosong_P, 
                        nomor_KTP_P = @nomor_KTP_P 
                    WHERE pesanan_id = @pesanan_id";

                        using (MySqlCommand cmd = new MySqlCommand(updatePesananQuery, context.Connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@pesanan_IN", pesanan.pesanan_IN);
                            cmd.Parameters.AddWithValue("@pesanan_OUT", pesanan.pesanan_OUT);
                            cmd.Parameters.AddWithValue("@nomor_kamar", pesanan.nomor_kamar);
                            cmd.Parameters.AddWithValue("@tipe_kamar_P", pesanan.tipe_kamar_P);
                            cmd.Parameters.AddWithValue("@kamar_kosong_P", pesanan.kamar_kosong_P);
                            cmd.Parameters.AddWithValue("@nomor_KTP_P", pesanan.nomor_KTP_P);
                            cmd.Parameters.AddWithValue("@pesanan_id", pesanan.pesanan_id);
                            cmd.ExecuteNonQuery();
                        }

                        // Query untuk memperbarui status kamar di tabel jenis_kamar
                       string updateJenisKamarQuery = @"
                    UPDATE jenis_kamar 
                    SET 
                        tipe_kamar = @tipe_kamar, 
                        kamar_kosong = @kamar_kosong 
                    WHERE nomor_kamar = @nomor_kamar";

                        using (MySqlCommand cmd2 = new MySqlCommand(updateJenisKamarQuery, context.Connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@tipe_kamar", pesanan.tipe_kamar);
                            cmd2.Parameters.AddWithValue("@kamar_kosong", pesanan.kamar_kosong);
                            cmd2.Parameters.AddWithValue("@nomor_kamar", pesanan.nomor_kamar);
                            cmd2.ExecuteNonQuery();
                        }//

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw; // Lempar ulang kesalahan untuk ditangani di Controller
                    }

                }

             }

         }
        public bool Delete(int pesanan_id)
        {
            using (DbContext context = new DbContext())
            {
                string query = "DELETE FROM pesanan WHERE pesanan_id = @pesanan_id";
                using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
                {
                    cmd.Parameters.AddWithValue("@pesanan_id", pesanan_id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


}
    */




/*public int Update(Pesanan pesanan, Kamar kamar)
{
    int result = 0;

    using (DbContext context = new DbContext())
    {
        string query1 = @"UPDATE pesanan SET pesanan_IN = @pesanan_IN, pesanan_OUT = @pesanan_OUT, nomor_kamar = @nomor_kamar, tipe_kamar_P = @tipe_kamar_P, kamar_kosong_P = @kamar_kosong_P, nomor_KTP_P = @nomor_KTP_P WHERE pesanan_id = @pesanan_id";

        string query2 = @"UPDATE jenis_kamar SET tipe_kamar = @tipe_kamar, kamar_kosong = @kamar_kosong WHERE nomor_kamar = @nomor_kamar";


        using (MySqlCommand cmd1 = new MySqlCommand(query1, context.Connection))
        {
            cmd1.Parameters.AddWithValue("@pesanan_id", pesanan.pesanan_id);
            cmd1.Parameters.AddWithValue("@nomor_KTP_P", pesanan.nomor_KTP_P);
            cmd1.Parameters.AddWithValue("@pesanan_IN", pesanan.pesanan_IN);
            cmd1.Parameters.AddWithValue("@pesanan_OUT", pesanan.pesanan_OUT);
            cmd1.Parameters.AddWithValue("@nomor_kamar", pesanan.nomor_kamar);
            cmd1.Parameters.AddWithValue("@tipe_kamar_P", pesanan.tipe_kamar_P);
            cmd1.Parameters.AddWithValue("@kamar_kosong_P", pesanan.kamar_kosong_P);
            cmd1.ExecuteNonQuery();
        }


        using (MySqlCommand cmd2 = new MySqlCommand(query2, context.Connection))
        {
            cmd2.Parameters.AddWithValue("@nomor_kamar", kamar.nomor_kamar);
            cmd2.Parameters.AddWithValue("@tipe_kamar", kamar.tipe_kamar);
            cmd2.Parameters.AddWithValue("@kamar_kosong", kamar.kamar_kosong);
            cmd2.ExecuteNonQuery();
        }
    }
    return result;
}*/

/*public List<Pesanan> SearchBynomorKTP(string nomor_KTP_P)
       {
           List<Pesanan> pesananList = new List<Pesanan>();

           using (DbContext context = new DbContext())
           {
               string query = @"SELECT p.pesanan_id, p.nomor_KTP_P, p.nomor_kamar, p.pesanan_IN, p.pesanan_OUT, k.tipe_kamar, k.kamar_kosong FROM pesanan p JOIN jenis_kamar k ON p.nomor_kamar = k.nomor_kamar WHERE p.nomor_KTP_P LIKE @nomor_KTP_P";

               using (MySqlCommand cmd = new MySqlCommand(query, context.Connection))
               {
                   cmd.Parameters.AddWithValue("@nomor_KTP_P", "%" + nomor_KTP_P + "%");

                   using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                   {
                       DataTable dt = new DataTable();
                       adapter.Fill(dt);

                   }
               }
           }

           return pesananList;
       }*/