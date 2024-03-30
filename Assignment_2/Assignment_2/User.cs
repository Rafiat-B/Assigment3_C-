using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class User
    {
        public string UserId { get; set; }
        public string Password { get; set; }

        public User(string userId, string password)
        {
            UserId = userId;
            Password = password;

        }
        public override bool Equals(object obj)
        {
            //comparing the obj1 to the obj of other if it's equal
            return obj is User user &&
                   UserId == user.UserId;
        }
    }
     class UserDB
    {
        // create a file to input user login details
        private static readonly string Path = @"C:\Users\Admin\Desktop\JUZT-OYIN\APP.DEV.C#\Assignment_2\Assignment_2\users.txt";
        private const char Delimiter = '|';

        private static readonly List<User> usersDB = new List<User>();

        public static List<User> GetUser()
        {
            List<User> users = new List<User>();
            
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
                {
                    string row; //row
                    while ((row = sr.ReadLine()) != null)
                    {
                        string[] column = row.Split(Delimiter); //columns

                        if (column.Length == 2)
                        {
                            User user = new User(
                            column[0],
                            column[1]);

                            users.Add(user);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured trying to read user " +ex.Message);
            }
            return users;
        }
        public static void saveUser(string userId, string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path, true))
                {
                    writer.Write(userId.ToString() + Delimiter);
                    writer.WriteLine(password);

                }

                UserDB.saveUser("Admin", "password");
                UserDB.saveUser("Admin1", "password");
                UserDB.saveUser("Admin2", "password");
            }
            catch (Exception ex)
            {
                Console.WriteLine("User could not be saved " +ex.Message);
            }

        }

    }
}
