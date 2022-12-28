using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractices.Controllers
{
    public class AccountController
    {
        public void login()
        {
            Console.WriteLine("Add email");
            string email=Console.ReadLine();
            Console.WriteLine("Add password");
            string password=Console.ReadLine();

            int roleId = 2;

            IAccountService account = new AccountService();

            string result=account.Login(email, password, roleId);

            Console.WriteLine(result);
        }
    }
}
