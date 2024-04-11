using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class Inimene
    {
        public string Nimi {get; set;}
        public int Sünniaasta;
        public int vanus;
        public int Vanus
        {
            get { return DateTime.Now.Year - Sünniaasta; }
            set { vanus = value; }
        }


        public inimene() {}
        public inimene(string nimi, int vanus=100)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void ÜtleVanus() 
        {
            Console.WriteLine("Ma olen" + Vanus + "aastat vana");
        }

        public virtual decimal Sissetulek(decimal tasu)
        {
            return tasu;
        }
    }
}
