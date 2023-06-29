using MySql.Data.MySqlClient;

namespace MinhaWebAPI
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "DBCLIENTE";
        private static string User = "root";
        private static string Password = "";
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;charset=utf8;";

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

            //Executa: INSERT, UPDATE, DELETE
            public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

    }
}

