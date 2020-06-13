using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    class UserRepository
    {
        List<User> users = new List<User>();
        // Function to add the user to im memory dummy DB
        public void AddUser(User user)
        {
            users.Add(user);
        }
        // Function to retrieve the user based on user id
        public User GetUser(string userid)
        {
            return users.Single(u => u.UserId == userid);
        }

        public string[] GetAllUserNames()
        {
            string[] arr = new string[users.Count];
            User[] arrUsers = users.ToArray();

            for(int i = 0; i < arr.Length; i++)
            {

                arr[i] = arrUsers[i].UserId;
            }

            return arr;
        }
    }
}
