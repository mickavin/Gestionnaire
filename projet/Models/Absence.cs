using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Models
{
    class Absence
    {
        public string DateDebut { get; set; }
        public string Datefin { get; set; }
        public string Motif { get; set; }
        public Absence(string debut, string fin, string motif)
        {
            DateDebut = debut;
            Datefin = fin;
            Motif = motif;
        }
    }
}
