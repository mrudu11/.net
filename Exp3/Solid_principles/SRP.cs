using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid_principles
{
    //single responsibility principle-one class should have only one job
    
        class UserRepo
        {
            public void UserSaveEmail()
            {
                Console.WriteLine("Email is saved");
            }
        }
        class EmailRepo
        {
            public void SendEmail()
            {
                Console.WriteLine("Email is sent by user");
            }
        }
    }

