﻿using System; using System.Collections; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;  namespace TARgv23_C_põhikonstruktsioonid {     public class ClassMain     {         public static void Main(string[] args)          {                Console.OutputEncoding= Encoding.UTF8;             //. 3 osa Massivid             string[]tähed=new string[5] {"A", "E", "U", "I", "O"};             int nr = 0;             while (nr<5)              {

                nr++;                 Console.WriteLine("{0}. tnt on {1}", nr, tähed[nr-1]);                          }

            //for
            //foreach
            Random random= new Random();
            int n=random.Next(5, 10);
            double d=random.NextDouble()*10;
            double[,] determ=new double[n, n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j< n; j++)
                {
                    determ[i,j] = Math.Round(d,2);
                    Console.Write("{0} ", determ[i,j]);

                }
                Console.WriteLine();

            }

            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Yellow;
            int N=random.Next(1, 5);
            int M=random.Next(6, 15);
            int[] arvud_N_M = new int[M-N+1];
            Console.WriteLine("N={0}, M={1}", N, M);
            for (int i=0; i<arvud_N_M.Length ; i++)
            {
                arvud_N_M[i] = N;
                Console.WriteLine("{0} ", Math.Pow(arvud_N_M[i], 2));
                N++;

            }

            for (int i = 0; i < tähed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", tähed[i]);
            }
            foreach (var nimi in tähed)
            {
                Console.WriteLine("Tere, {0} õpilane", tähed);
            }
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} õpilane", tähed[nr]);
                nr++;
            } while (nr != tähed.Length);


            ConsoleKeyInfo key= new ConsoleKeyInfo();             do             {                 Console.WriteLine("Vajuta backspace");                 key= Console.ReadKey();             } while (key.Key!=ConsoleKey.Backspace);                int a=0;             while (a < 10)             {                 Console.WriteLine(a);                 a++;              }              /*inimene naine=new inimene();             naine.Nimi = "Kati";             naine.Vanus = 18;             inimene mees=new inimene("Mati");             mees.Vanus = 100;             List<inimene> inimesed = new List<inimene>();             inimesed.Add(naine);             inimesed.Add(mees);             inimesed.Add(naine);             inimesed.Add(mees);             inimesed.Add(new inimene() {Nimi= "Kadri", Vanus= 25});             foreach (inimene inimene in inimesed)             {                  Console.WriteLine(inimene.Nimi+" tema vanus on "+inimene.Vanus);                          }             Dictionary<int,inimene> õpilased= new Dictionary<int,inimene>();             õpilased.Add(501,naine);             õpilased.Add(601, naine);             õpilased.Add(602, new inimene() { Nimi="Kadri", Vanus= 25});             foreach (inimene item in õpilased.Values)             {                 Console.WriteLine(item.Nimi);              }             foreach (KeyValuePair<int, inimene> item in õpilased)             {                 Console.WriteLine(item.Key+ ": "+ item.Value.Nimi+"("+item.Value.Vanus+")");             }                 /*ArrayList arrayList= new ArrayList();             arrayList.Add("Esimene");             arrayList.Add("Teine");             arrayList.Add("Kolmas");             Console.WriteLine("Mida otsime:");             string value=Console.ReadLine();             if (value != null )              {                          if (arrayList.Contains(value))                                      {                     Console.WriteLine("Kokku:" + arrayList.Count);                     Console.WriteLine("Otsitav sõna on olemas\n Ta asub" + arrayList.IndexOf(value) + ". kohal");                 }                 else                 {                     Console.WriteLine("Oli vaja midagi otsida:");                 }             arrayList.Insert(3, "Neljas");              arrayList.RemoveAt(0);             arrayList.Remove(value);              for (int i=0; i<arrayList.Count; i++)                  {                     Console.WriteLine(arrayList[i]);                                                   }             }                 //2.osa Tsuklid, Jarjendid, Massivid             /*List<string> kuude_list = new List<string>();             try             {                 foreach (var rida in File.ReadAllLines(@"..\..\..\Kuud.txt"))                 {                     kuude_list.Add(rida);                 }             }             catch (Exception)             {                  Console.WriteLine("Viga failiga!");             }             foreach (string kuu in kuude_list)             {                 Console.WriteLine(kuu);                          }             kuude_list.Remove("Juuni");             foreach (string kuu in kuude_list)             {                 Console.WriteLine(kuu);              }              //I.Osa andmetuubid, if, case, Alamfuntsioonid, random             /*Console.WriteLine("Hello, World!");              string nimi = "Python";             Funktisioonid.Tervitus(nimi);               int a = 0;             string tekst = "Tere";             char taht= 'A';             double arv = 3.55555;             float arv1 = 2;             int korrutis = Funktisioonid.Korruta((int)arv, (int)arv1);             Console.WriteLine(korrutis);              Console.WriteLine(tekst);             Console.WriteLine(taht);             Console.Write("Sisesta uus parameeter a: ");             a=int.Parse(Console.ReadLine());              Console.Write("Tehe: ");             taht=char.Parse(Console.ReadLine());             if (taht=='+') // && - and, || - or, ! - not             {                 Console.WriteLine("Arvude {0}, {1} ja {2} summa={3}",a,arv,arv1,arv+arv1+a);             }             else if (taht == '*')             {                 Console.WriteLine("Arvude {0}, {1} ja {2} korrutis={3}", a, arv, arv1, arv * arv1 * a);             }             else             {                 Console.WriteLine("Kirjuta ise!");             }             /*              nimi: Juku-ga lähame kinno!               vanus: Kui vana Juku on.               pilet: Tasuta,Laste,Täis,Soodus. Viga! kui <0, >123             */             /*Console.WriteLine("Tere!\nMis on sinu nimi?");             nimi = Console.ReadLine();             Console.WriteLine("Tere " + nimi);             if (nimi.ToUpper() == "JUKU")             {                 Console.WriteLine("Lähme kinno!");                 try                 {                     Console.WriteLine("{0},\nKui vana sa oled?", nimi);                     int vanus = int.Parse(Console.ReadLine());                     if (vanus <= 0 || vanus > 123)                     {Console.WriteLine("Viga!");}                     else if (vanus > 0 && vanus <= 6)                     {Console.WriteLine("Tasuta pilet!");}                     else if (vanus <= 15)                     {Console.WriteLine("Lastepilet!");}                     else if (vanus <= 65)                     {Console.WriteLine("Täispilet!");}                     else if (vanus <= 100)                     {Console.WriteLine("Sooduspilet!");}                 }                 catch (Exception e)                 {                     Console.WriteLine(e);                 }             }             else             {                 Console.WriteLine("Mõtle ise reaktsioon välja!");             }             Console.WriteLine("Switch'i kasutamine");             Random random = new Random();             int paeva_nr = random.Next(1, 7);             string paev;             Console.WriteLine(paeva_nr);             switch (paeva_nr)             {                 case 1: paev = "Esmaspäev"; break;                 case 2: paev = "Teisipäev"; break;                 case 3: paev = "Kolmapäev"; break;                 case 4: paev = "Neljapäev"; break;                 case 5: paev = "Reede"; break;                 case 6: paev = "Laupäev"; break;                 case 7: paev = "Pühapäev"; break;                 default:                     paev = "Tundmatu päev";                     break;             }             Console.WriteLine(paev);*/         }     } } 