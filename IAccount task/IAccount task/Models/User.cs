using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Models
{
    class User:IAccount
    {
        private static int _Id=0;
        private string _Fullname;
        private string _Email;
        private string _Password;

        public int Id { get; }

        public string Fullname
        {
            get { return _Fullname; }
            set
            {
                _Fullname = value;
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                    _Email = value;
            }
        }
        public string Password
        {
            get { return _Password; }
            set
            {
                    _Password = value;
            }
        }

        private User()
        {
            _Id++;
            Id = _Id;
        }

        public User(string fullName, string email, string password):this()
        {
            Fullname = fullName;
            Email = email;
            Password = password;
              
        }

        public void ShowInfo()
        {
                Console.WriteLine($" ID->{Id}\n Fullname->{Fullname}\n Emil->{Email}\n ");
            
        }

        public bool PasswordChecker(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) isUpper = true;
                    else if (char.IsLower(item)) isLower = true;
                    else if (char.IsDigit(item)) isDigit = true;
                }
                if (isDigit && isLower && isUpper)
                    return true;
            }
            return false;
        }
    }
}
