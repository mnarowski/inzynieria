using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using TripsService.AppFiles.Database;

namespace TripsService
{
    sealed class UserFactory
    {
        /// <summary>
        /// Tworzy nowego użytkownika i umieszcza rekord w bazie danych
        /// </summary>
        public static User createUser(String name, String surname, DateTime birthDate, UserRole role, SexEnum sex, String login, String pass)
        {
            User user = new User();
            List<User> list = SessionFactory.GetNewSession().CreateQuery("from User u WHERE u.login = :login").SetParameter("login", login).List<User>().ToList<User>();
            if (list.Count > 0)
            {
                throw new Exception("User with given login exists");
            }
            user.vlogin = login;
            user.vpassword = EncodePassword(pass);
            user.vRole = role.vid;
            user.vsex = sex;
            user.vname = name;
            user.vSureName = surname;
            user.vDateOfBirth = birthDate;
            return user;
        }

        /// <summary>
        /// Sprawdza czy dany użytkownik ma rozszerzone uprawnienia
        /// </summary>
        public static bool isRoot(User user)
        {
            if (user.vname == "system")
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Zamienia ciąg znaków na hash md5
        /// </summary>

        public static string EncodePassword(string originalPassword)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(originalPassword);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
    }
}