using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SQLite;


namespace ListaZadan.Klasy
{
    public class DbHelper
    {
        public static List<User> LoadUsers()
        {
            using(IDbConnection conn = new SQLiteConnection(LoadConnectinString()))
            { 
                return conn.Query<User>("SELECT * FROM User", new DynamicParameters()).ToList();
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectinString()))
            {
                conn.Execute($"INSERT INTO User (Id, Imie, Login, Haslo) VALUES('{user.Id}','{user.Imie}','{user.Login}','{user.Haslo}')");
            }
        }

        private static string LoadConnectinString(string name = "Default")
        {
            string configString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            var basePath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent;
            configString = configString.Replace(".\\ToDoTasksDB.db", basePath + "\\ToDoTasksDB.db");
            return configString;
        }
    }
}
