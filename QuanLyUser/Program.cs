using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text;

namespace QuanLyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Manager mgr = new Manager();
           

		        User user = new User("An21", "123", "An", "323");
                User user1 = new User("Binh21", "123", "Binh", "3232");
                User user2 = new User("Thanh13", "123", "Thanh", "543");
                User user3 = new User("Co12", "1423", "Co", "434");
                User user4 = new User("Trung324", "1243", "Trung", "535");
			    mgr.register(user);
                mgr.register(user1);
                mgr.register(user2);
                mgr.register(user3);
                mgr.register(user4);
                Console.WriteLine(mgr.login(user));

                mgr.sortAndPrintUserByName();   
        }
    }
}
