using System;

namespace MediaTek86.Models
{
    public class Absence
    {
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }
    }
}
