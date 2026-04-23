using Solid_principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles
{
    //DIP-Dependency Inversion Principle
    //High level classes should not depend on low level classes.
    //Both should depend on abstraction (interfaces).

    interface Database
    {
        void connect();
    }

    class MySQLDatabase : Database
    {
        public void connect()
        {
            Console.WriteLine("MySQL Connected");
        }
    }

    class Application
    {
        Database db;

        public Application(Database db)
        {
            this.db = db;
        }

        public void Start()
        {
            db.connect();
        }
    }
}
