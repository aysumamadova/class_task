using System;
using IAccount_task.Models;

namespace IAccount_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            string email = "";
            string password = "";
            //User u = new User("jhsed","kjd","ahsjdjr2345A");
            //Console.WriteLine(u.PasswordChecker("ahsjdjr2345"));
            //Grop g = new Grop("AP205", 18);
            //Console.WriteLine(g.CheckGroupNo("AP205"));
            int key;
            do
            {
                User u = new User(fullname, email, password);
                Console.WriteLine("full");
                fullname = Console.ReadLine();
                Console.WriteLine("email");
                email = Console.ReadLine();
                Console.WriteLine("pass");
                password = Console.ReadLine();

                Console.WriteLine(u.PasswordChecker("ahsjdjr2345"));
              
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {

                    default:
                        break;
                }
                break;
            } while (key!=8);
            
        }
    }
}
