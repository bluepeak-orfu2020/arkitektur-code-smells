using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class LongMethods
    {
        public int LongMethod(string userId, string categoryId)
        {
            if (userId == null || userId == "")
            {
                throw new Exception("Invalid user");
            }
            if (categoryId == null || categoryId == "")
            {
                throw new Exception("Invalid category");
            }

            string uid = userId;
            if (!userId.StartsWith("abc:"))
            {
                uid = $"abc:{userId}";
            }

            Category category = new Category() { Cid = categoryId };
            User user = new User() { Uid = uid, Category = category };

            int result = user.ComputeStuff();

            if (result < 20)
            {
                user.Category = null;
            }
            else if (result > 50)
            {
                user.Category = new Category() { Cid = "123" };
            }

            int newResult = user.ComputeMoreStuff();

            if (newResult > 5)
            {
                return 10;
            }
            else
            {
                return newResult;
            }
        }

        class User
        {
            public string Uid { get; set; }
            public Category Category { get; set; }

            public int ComputeStuff()
            {
                return 42;
            }

            public int ComputeMoreStuff()
            {
                return 1337;
            }
        }

        class Category
        {
            public string Cid { get; set; }
        }
    }
}
