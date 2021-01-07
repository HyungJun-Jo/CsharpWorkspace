using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public static class UserInfoDisplay
    {

        public static void Display()
        {
            Console.WriteLine("사번: {0}", CurrentUser.Instance.UserName);
            Console.WriteLine("이름: {0}", CurrentUser.Instance.EmpNo);
        }
    }
}
