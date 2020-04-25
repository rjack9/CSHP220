using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_CSHP_220

{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
            users.Add(new Models.User { Name = "Ron", Password = "super" });
            users.Add(new Models.User { Name = "Frank", Password = "hello" });
            users.Add(new Models.User { Name = "Cindy", Password = "cindy" });

            var newUsers = users.Where(t => t.Password == "hello").ToList();
            Console.WriteLine("These users have hello as thier password:");

            foreach (var user in newUsers)
            {
                Console.WriteLine("Name = {0} Password = {1}", user.Name, user.Password);
            }

            Console.WriteLine();

            users.RemoveAll(t => t.Password == t.Name.ToLower());
            Console.WriteLine("Password as name has been removed:");

            foreach (var user in users)
            {
                Console.WriteLine("Name = {0} Password = {1}", user.Name, user.Password);
            }

            Console.WriteLine();

            newUsers.Remove(newUsers.First());
            Console.WriteLine("The first user to have hello as their password has been deleted:");

            foreach (var user in newUsers)
            {
                Console.WriteLine("Name = {0} Password = {1}", user.Name, user.Password);
            }
            Console.ReadLine();
        }
    }
}


