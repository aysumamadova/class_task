using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Models
{
   interface IAccount
    {
        public bool PasswordChecker(string password);
        void ShowInfo();
    }
}
