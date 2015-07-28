using System;
using NHibernate;
using NHibernate.Cfg;

namespace SuperPOS.Common
{
    public class SessionFactory
    {
        private static ISessionFactory _sessions;
        private static readonly object PadLock = new object();
        private static Configuration _cfg;

        public static ISession OpenSession()
        {
            if (_sessions != null) return _sessions.OpenSession();

            lock (PadLock)
            {
                if (_sessions == null) BuildSessionFactory();
            }

            return _sessions.OpenSession();
        }

        private static void BuildSessionFactory()
        {
            _cfg = new Configuration();

            try
            {
                _sessions = _cfg.Configure("hibernate.cfg.xml").BuildSessionFactory();
            }
            catch (Exception)
            {
                //Resources.DBNotConnected:Database not started up or connected, please contact system administrator                
                throw new DALException("Database not started up or connected, please contact system administrator");
            }
        }
    }
}