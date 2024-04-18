
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Sünniaasta;
        private int vanus;
        public int Vanus
        {
            get
            {
                vanus = DateTime.Now.Year - Sünniaasta;
                return vanus;
            }
            set
            { vanus = value; }
        }
        public Inimene() { }
        public Inimene(string nimi)
        {
            Nimi = nimi;
        }
        public Inimene(string nimi, int vanus = 100)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public void ÜtleVanus()
        {
            Console.WriteLine("Ma olen " + Vanus + " aastat vana");
        }
        public virtual double Sissetulek(double tasu)
        {
            return tasu;
        }
    }
}
