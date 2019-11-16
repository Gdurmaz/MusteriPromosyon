using System;
using Project.Core.Connection;

namespace Project.Core.Singleton
{
    public class SingletonBase
    {
        protected static ConnectionDb _connDb  { get; set; }
        private static object _lock = new object();
        protected SingletonBase()
        {
            GetConnection();
        }
        protected ConnectionDb GetConnection()
        {
            if (_connDb==null)
            {
                lock (_lock)
                {
                    if (_connDb==null)
                    {
                        _connDb = new ConnectionDb();
                    }
                }
            }
            return _connDb;
        }
    }
}
