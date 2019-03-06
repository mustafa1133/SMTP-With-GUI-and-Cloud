using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class UserService
    {

        //add user
        public static bool CreateUser(string name, string email, out string msg)
        {
            msg = "user added";
            var user = new Users()
            {
                Email = name,
                Name = email
            };

            if (string.IsNullOrEmpty(name))
            {
                msg = "fields must be filled";
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                msg = "fields must be filled";
                return false;
            }
            //check if user exists
            if (Users.HasUser(email))
            {
                msg = "email already exists";
                return false;
            }
            Users.CreateUsers(user);
            return true;
        }
        //search user
        public static bool CreateUser(string email, out Users user)
        {
            user = null;
            return false;
        }
        //edit user
        public static bool UpdateUser(string name, string email, out string msg)
        {
            msg = "user updated";
            
            var user = new Users()
            {
                Email = email,
                Name = name
            };

            if (string.IsNullOrEmpty(name))
            {
                msg = "fields must be filled";
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                msg = "fields must be filled";
                return false;
            }
            //check if user exists
            if (!Users.HasUser(email))
            {
                msg = "email does not exists, please check again";
                return false;
            }
            Users.UpdateUser(user);
                return true;
        }
        //delete user
        public static bool DeleteUser(string email, out string msg)
        {
            msg = "user deleted";
            if (string.IsNullOrEmpty(email))
            {
                msg = "fields must be filled";
                return false;
            }
            if (!Users.HasUser(email))
            {
                msg = "email does not exists, please check again";
                return false;
            }
            Users.DeleteUser(email);
            return true;
        }
        public static bool SelectUser(string email, out Users user)
        {
            user = null;
            if (!Users.HasUser(email))
                return false;
            user = Users.SelectAllUsers().Find(d=>d.Email==email);
            return true;
        }

    }
}
