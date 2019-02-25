using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasspackWebApi.Models
{
    public class Art
    {
        public int Nr { get; set; }
        public int Bestand { get; set; }
        public string Bezeichnung { get; set; }
        public string Artikeltext1 { get; set; }
        public string Artikeltext2 { get; set; }
        public string Artikeltext3 { get; set; }
        public decimal Stueckzahl { get; set; }
        public decimal Verpackungseinheit { get; set; }

    }
}