using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyCloudStoreApp
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public DBConnection()
        {
            Initialize();

        }
        public void Initialize()
        {
            server = "localhost";
            database = "zastitaDatabase";
            uid = "root";
            password = "";
            string conncetionString;
            conncetionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid
                + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(conncetionString);

        }

    }
    

}
