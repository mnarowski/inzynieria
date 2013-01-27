using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripsService.AppFiles.Database
{
    public class SessionFactory
    {
        public static readonly string connectionString = "Server=localhost;Database=inzynieria;User ID=inzynieria;Password=inzynieria;";


        private static NHibernate.ISessionFactory sFactory;



        /// <summary>

        /// initializes the session for database

        /// </summary>

        private static void Init()
        {

            NHibernate.Cfg.Configuration config = new NHibernate.Cfg.Configuration();
            config.SetProperty(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.PostgreSQL82Dialect");
            //NHibernate.Driver.NpgsqlDriver
            //config.SetProperty(NHibernate.Cfg.Environment.ConnectionProvider, "NHibernate.Connection.DriverConnectionProvider");
            config.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, "NHibernate.Driver.NpgsqlDriver");
            config.SetProperty(NHibernate.Cfg.Environment.ConnectionString, SessionFactory.connectionString);
            config.AddXmlFile(".\\AppFiles\\Database\\models.xml");
            sFactory = config.BuildSessionFactory();

        }





        /// <summary>

        /// checks wheteher the session already exists. if not then creates it

        /// </summary>

        /// <returns></returns>

        public static NHibernate.ISessionFactory GetSessionFactory()
        {

            if (sFactory == null)
            {

                Init();

            }

            return sFactory;



        }



        /// <summary>

        /// creates a database connection and opens up a session

        /// </summary>

        /// <returns></returns>

        public static NHibernate.ISession GetNewSession()
        {

            return GetSessionFactory().OpenSession();

        }

    }
}
