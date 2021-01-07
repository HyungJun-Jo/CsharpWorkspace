using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class CurrentUser
    {
        #region singleton
        private static CurrentUser _instance = null;

        private CurrentUser()
        {
        }

        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentUser();
                }
                return _instance;
            }
        }
        #endregion

        public string Uuid { get; set; }
        public string AutodeskUserId { get; set; }
        public string EmpNo { get; set; }
        public string UserName { get; set; }
        public string DeptName { get; set; }
        public string TitleName { get; set; }
        public string Email { get; set; }
    }
}
