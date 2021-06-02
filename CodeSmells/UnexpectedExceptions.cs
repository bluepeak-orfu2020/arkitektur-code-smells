using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class UnexpectedExceptions
    {

        public void PrintInfo()
        {
            List<User> users = new List<User>();
            users.Add(new User());
            users.Add(new User());
            users.Add(new SpecialUser() { ExtraSpecial = true }); // will throw unexpected exception

            foreach (User user in users)
            {
                Console.WriteLine($"User: {user.ToString()}");
            }
        }
    }

    class User
    {
        // User properties
        public override string ToString()
        {
            return @"I'm a user!";
        }
    }

    class SpecialUser : User
    {
        public bool ExtraSpecial;

        public override string ToString()
        {
            if (ExtraSpecial)
            {
                throw new Exception(@"I'm to special to print stuff");
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
