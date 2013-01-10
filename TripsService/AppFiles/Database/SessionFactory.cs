using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripsService.AppFiles.Database
{
    public class SessionFactory
    {



        private static NHibernate.ISessionFactory sFactory;



        /// <summary>

        /// initializes the session for database

        /// </summary>

        private static void Init()
        {

            NHibernate.Cfg.Configuration config = new NHibernate.Cfg.Configuration();

            config.AddFile(".\\AppFiles\\Database\\db.cfg.xml");//adds all the embedded resources .hbm.xml
            config.AddFile(".\\AppFiles\\Database\\models.xml");
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
