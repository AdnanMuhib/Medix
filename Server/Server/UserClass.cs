using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class UserClass
    {
        private String username;
        private String password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}