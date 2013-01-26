using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace TripsService.AppFiles.Database
{
    class DbService
    {
        /// <summary>
        /// DbService.getAll<User>();
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>

            public static ICollection<T> GetAll<T>()
            {

                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {

                    return session.CreateCriteria(typeof(T)).List<T>();



                }



            }

            public static T Find<T>(int id)
            {



                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {

                    return session.Get<T>(id);



                }



            }


            public static void Add<T>(T obj)
            {

                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {

                    using (NHibernate.ITransaction transaction = session.BeginTransaction())
                    {

                        session.Save(obj);

                        transaction.Commit();

                    }

                }

            }


            public static void Delete<T>(T obj)
            {

                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {

                    using (NHibernate.ITransaction transaction = session.BeginTransaction())
                    {

                        session.Delete(obj);

                        transaction.Commit();

                    }

                }

            }

            public static void Update<T>(T obj)
            {

                using (NHibernate.ISession session = SessionFactory.GetNewSession())
                {

                    using (NHibernate.ITransaction transaction = session.BeginTransaction())
                    {

                        session.SaveOrUpdate(obj);

                        transaction.Commit();

                    }

                }

            }


        
    }

    
}
