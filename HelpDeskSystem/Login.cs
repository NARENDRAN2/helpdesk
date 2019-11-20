using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HelpDeskSystem
{
    class Login
    {
        DataAccessLayer dl = new DataAccessLayer();
        public string Username { get; set; }
        public string Password { get; set; }

        public Login()
        {

        }
        public DataTable GetAdminLogin(string username,string password)
        {
            return dl.getAdminLogin(username,password);
        }

    }
}
