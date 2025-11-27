using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gym_Mngt_System.Backend.Singleton
{
    internal class SingletonDB
    {
        private static SingletonDB _instance;
        private SqlConnection _connectionString;

        private SingletonDB()
        {
        }

        public static SingletonDB getInstance()
        {
            {
                if (_instance == null)
                {
                    _instance = new SingletonDB();
                }
                return _instance;
            }
        }
        public SqlConnection getConnection()
        {
            try
            {
                _connectionString = new SqlConnection(getConnectionString());

                while (_connectionString.State == System.Data.ConnectionState.Connecting)
                {
                    Task.Delay(5);
                }

                if (_connectionString.State != System.Data.ConnectionState.Open)
                {
                    _connectionString.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return _connectionString;
        }
        public void closeConnection()
        {
            if (_connectionString != null && _connectionString.State == ConnectionState.Open)
            {
                _connectionString.Close();
            }

        }
        private string getConnectionString()
        {
            return new SqlConnectionStringBuilder
            {
                DataSource = @"JIEM\SQLEXPRESS",
                InitialCatalog = "gym_db",
                IntegratedSecurity = true
            }.ConnectionString;
        }
    }
}


