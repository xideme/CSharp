using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class Senior:Inimene
    {
        public int Tööstaz;

        public override decimal Sissetulek(decimal tasu)
        {
            tasu = tasu * (1+(Tööstaz/100));
            return tasu;
        }


    }
}
