using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet.Models
{
    /// <summary>
    /// Classe métier Absence
    /// </summary>
    class Absence
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int MotifID { get; set; }
        public int PersonnelID { get; set; }
        public Absence(DateTime debut, DateTime fin, int IDMotif, int IDPersonnel)
        {
            DateDebut = debut;
            DateFin = fin;
            MotifID = IDMotif;
            PersonnelID = IDPersonnel;
        }
    }
}
