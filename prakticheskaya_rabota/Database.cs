using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prakticheskaya_rabota
{
    class Database
    {
        private MySqlConnection myConnection;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataSet DataSet = new DataSet();
        DataTable table = new DataTable();

        public Database()
        {
            this.myConnection = this.Connect();
        }

        public MySqlConnection Connect()
        {
            MySqlConnection myConnection = new MySqlConnection(
                "server=;" +
                "username=;" +
                "password=;" +
                "database=;" +
                "charset=utf8"
            );
            return myConnection;
        }

        public void OpenConnection()
        {
            if (this.myConnection.State == System.Data.ConnectionState.Closed)
                this.myConnection.Open();
        }

        public void ClouseConnection()
        {
            if (this.myConnection.State == System.Data.ConnectionState.Open)
                this.myConnection.Close();
        }

        public DataTable SelecttUser(string login, string password)
        {
            MySqlCommand myCommand = new MySqlCommand(
                "SELECT * FROM `users` WHERE `login` = @login AND `password` = @password"
            , this.myConnection);
            myCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            myCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = myCommand;
            adapter.Fill(table);
            return table;
        }
    }
}
