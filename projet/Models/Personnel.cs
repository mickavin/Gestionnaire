using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Models
{
    /// <summary>
    /// Classe métier Responsable
    /// </summary>
    class Personnel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int Service { get; set; }

        public Personnel(string nom, string prenom, string tel, string mail, int service)
        {
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Service = service;
        }
    }
}
