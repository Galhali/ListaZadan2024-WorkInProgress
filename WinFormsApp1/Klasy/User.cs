using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    internal class User
    {
        public string Id;
        public string Imie;
        public string Login;
        public string Haslo;

        public User(
            string id,
            string imie,
            string login,
            string haslo)
        {
            Id = id;
            Imie = imie;
            Login = login;
            Haslo = haslo;
        }
    }
}
