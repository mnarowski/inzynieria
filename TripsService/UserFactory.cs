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
            user.vRole = role;
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
            if (user.vname == "root")
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
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }
    }
}