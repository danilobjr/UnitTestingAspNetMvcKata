using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestingAspNetMvcKata.Web.Models;

namespace UnitTestingAspNetMvcKata.Web.Repositories
{
    public class UserRepository
    {
        internal void Create(Models.User newUser)
        {
            Console.WriteLine("EXTERNAL DEPENDENCY - creating new user in db...");
        }

        internal User FindById(int id)
        {
            Console.WriteLine(string.Format("EXTERNAL DEPENDENCY - looking for user with id {0}...", id));

            return new User
            {
                Id = id,
                Email = "user.found@email.com",
                Password = "abCD12!_"
            };
        }

        internal void Delete(int id)
        {
            Console.WriteLine("EXTERNAL DEPENDENCY - removing user from db...");
        }
    }
}