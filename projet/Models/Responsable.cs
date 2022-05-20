using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace projet.Models
{
    /// <summary>
    /// Classe métier Responsable
    /// </summary>
    class Responsable
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Responsable(string login, string password)
        {
            Login = login;
            Password = CalculateSHA256(password);
        }
        /// <summary>
        /// Méthode qui encrypte le mot de passe de l'utilisateur
        /// </summary>
        private static string CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            return Encoding.Default.GetString(hashValue);
        }
    }
}
