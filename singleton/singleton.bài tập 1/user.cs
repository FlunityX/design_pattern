using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.bài_tập_1
{
    internal class user
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public user(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }
}
