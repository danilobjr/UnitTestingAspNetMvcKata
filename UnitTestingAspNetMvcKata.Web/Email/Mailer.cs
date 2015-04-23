using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestingAspNetMvcKata.Web.Email
{
    public class Mailer
    {
        public virtual void Send(string p1, string p2, string p3, string p4)
        {
            Console.WriteLine("EXTERNAL DEPENDENCY - seding email to new user...");
        }
    }
}
