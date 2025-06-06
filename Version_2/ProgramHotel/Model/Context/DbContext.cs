﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProgramHotel.Context
{
    public class DbContext : IDisposable
    {
        private readonly string _connectionString;
        private MySqlConnection _connection;

        public DbContext()
        {
            
            _connectionString = "Server=localhost;Database=reservasi_hotel;Uid=root;Pwd=;";
        }

        public MySqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(_connectionString);
                    _connection.Open();
                }
                return _connection;
            }
        }


        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
