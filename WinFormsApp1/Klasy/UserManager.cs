﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ListaZadan.Klasy
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = DbHelper.LoadUsers();
        }

        public User WyszukajUzytkownika(string login, string haslo)
        {
            foreach(User user in users)
            {
                if(user.Login == login && user.Haslo == haslo)
                {
                    return user;
                }
            }

            return null;
        }

        public bool CzyLoginWolny(string login)
        {
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    return false;
                }
            }

            return true;
        }

        public void DodajUzytkownika(User user)
        {
            DbHelper.SaveUser(user);
            users = DbHelper.LoadUsers();
        }
    }
}
