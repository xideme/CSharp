using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class Senior : Inimene
    {
        public int Tööstaž = 20;
        public Senior() { }
        public Senior(int tööstaz)
        {
            Tööstaž = tööstaz;
        }
        public override double Sissetulek(double tasu)
        {
            return (double)(tasu * (1 + (double)Tööstaž / 100));
        }
    }
}
