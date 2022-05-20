using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Models
{
    class Responsable
    {
        private string Login { get; set; }
        public string Password { get; set; }

        public Responsable(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
