using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SRP
            UserRepo u = new UserRepo();
            u.UserSaveEmail();

            EmailRepo e = new EmailRepo();
            e.SendEmail();

            //OCP
            Demo d=new Demo();
            d.myMeth();

            //ISP
            Human h = new Human();
            h.workable();
            h.eatable();
            Robot robot = new Robot();
            robot.workable();

            //DIP
            Database db = new MySQLDatabase();
            Application app = new Application(db);
            app.Start();

            //LSP
            FlyingBird bird = new Sparrow();
            bird.Fly();

            Ostrich o = new Ostrich();
            o.Run();
        }
    }
}
