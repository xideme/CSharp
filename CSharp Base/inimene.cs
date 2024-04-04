using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    internal class inimene
    {
        public string Nimi {get; set;}
        public int Vanus { get; set;}
        public inimene() {}
        public inimene(string nimi)
        {
            Nimi = nimi;
        }

    }
}
