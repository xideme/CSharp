using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{

public class Tootaja : Inimene
{
	public string Asutus;
	public string Amet;
	public decimal Töötasu;
}

public override decimal Sissetulek(decimal tasu)
{
	tasu = ((tasu - 654) / 100) * 80 + 654;
	return tasu;

}
}