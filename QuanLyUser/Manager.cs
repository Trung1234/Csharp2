using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace QuanLyUser
{
    public class Manager
    {

        private const string FILE_PATH = "user.txt";
        private List<User> listUser;
        List<string> accountstring;
        public Manager()
        {
            listUser = new List<User>();
            initUserList();
        }

        private void initUserList()
        {

            try
            {

                List<string> accounts = File.ReadAllLines(FILE_PATH).ToList();
                foreach (var acc in accounts)
                {

                    List<string> split = acc.Split('-').ToList();
                    string userName = split[0];
                    string pass = split[1];
                    string name = split[2];
                    string phone = split[3];
                    listUser.Add(new User(name, phone, userName, pass));

                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public List<User> findUserByName(string name)
        {
            List<User> data = new List<User>();
            for (int i = 0; i < listUser.Count; i++)
            {
                User user = listUser[i];
                if (user.Name.Equals(name))
                {
                    data.Add(user);
                }
            }
            return data;
        }

        public bool deleteUserByUserName(string userName)
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].UserName.Equals(userName))
                {
                    listUser.RemoveAt(i);
                    saveListUser();
                    return true;
                }
            }
            return false;
        }

        public void sortAndPrintUserByName()
        {
            listUser.OrderBy(acc => acc.Name);
            foreach (var user in listUser)
            {
                Console.WriteLine(user.Name);
            }
        }

        public bool register(User user)
        {
            int index = listUser.IndexOf(user);
            if (index > -1) return false;

            listUser.Add(user);
            saveListUser();
            return true;
        }

        private void saveListUser()
        {
            try
            {
                accountstring = new List<string>();

                foreach (var acc in listUser)
                {
                    string info = acc.UserName+ "-" + acc.Pass + "-" + acc.Name + "-" + acc.Phone;
                    accountstring.Add(info);
                }

                File.WriteAllLines(FILE_PATH, accountstring);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public bool login(User user)
        {
            int index = listUser.IndexOf(user);
            if (index == -1) return false;

            User userFound = listUser[index];
            return userFound.Pass.Equals(user.Pass);
        }
    }
}