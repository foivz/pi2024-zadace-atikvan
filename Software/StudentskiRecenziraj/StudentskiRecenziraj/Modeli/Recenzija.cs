using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiRecenziraj.Modeli
{
    public class Recenzija
    {
        public int idJelo { get; set; }
        public string naziv { get; set; }
        public int ocjenaOkus { get; set; }
        public string ocjenaKolicina { get; set; }
        public string komentar { get; set; }

    }
}
