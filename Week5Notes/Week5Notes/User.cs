using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Notes
{
    internal class User
    {
        private string name;
        private string email;

        //public string Name { get { return name; } set { } }
        public string Name
        {
            get { return name; }
            set { 
                //name = value;
            if(string.IsNullOrEmpty(value) == false)
                {
                    name = value;
                }
            else
                {
                    name = "Invalid Name"; // could throw an exception here instead 
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if(value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    email = "bad@email.com";
                }
            }
        }

        public string UserId { get; set; }


        public User(string name, string email, string userID)
        {
            Name = name;
            Email = email;
            UserId = userID;
        }
    }
}
