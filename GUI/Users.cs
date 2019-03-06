using Dos.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Users
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Users(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public Users()
        {
        }

        public static void CreateUsers(Users user)
        {
            var users = SelectAllUsers();
            users.Add(user);
            UpdateUsersSave(users);
        }

        public static List<Users> SelectAllUsers()
        {
            try
            {
                string usersstring = File.ReadAllText(ConfigurationManager.AppSettings["path"]);
                if (string.IsNullOrEmpty(usersstring))
                {
                    return new List<Users>();
                }
                return JSON.ToObject<List<Users>>(usersstring);
            }
        catch(Exception e)
            {
                return new List<Users>();
            }
        }

        public static bool HasUser(string email)
        {
            //check if user email exists
            var users = SelectAllUsers();
            if (users.Exists(d => d.Email == email))
                return true;
            return false;
        }


        public static void UpdateUsersSave(List<Users> users)
        {
            string usersstring = JSON.ToJSON(users);
            File.WriteAllText(ConfigurationManager.AppSettings["path"], usersstring);
        }

        public static void UpdateUser(Users user)
        {
            var users = SelectAllUsers();
            users.RemoveAll(d => d.Email == user.Email);

            users.Add(user);
            UpdateUsersSave(users);
        }
        public static void DeleteUser(string email)
        {
            var users = SelectAllUsers();
            users.RemoveAll(d => d.Email == email);
            UpdateUsersSave(users);
        }
    }
}
