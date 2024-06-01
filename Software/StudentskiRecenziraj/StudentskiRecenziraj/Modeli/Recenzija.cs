using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiRecenziraj.Modeli
{
    public class Recenzija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int OcjenaOkus { get; set; }
        public int  OcjenaKolicina { get; set; }
        public string Komentar { get; set; }

    }
}
