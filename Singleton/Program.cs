using System;
using Singleton.Database;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {            
            var db = Database.Database.GetInstance();
            Console.WriteLine(db.ID);
            db.ID = 666;
            Console.WriteLine(db.ID);

            var db2 = Database.Database.GetInstance();
            db.ID = 13;
            Console.WriteLine(db.ID);
        }
    }
}
