using System;

namespace Kolmnurk
{
    public class Triangle
    {
        public double A;
        public double B;
        public double C;
        public double S;
        public double H;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(double s, double h) 
        { 
            S = s;
            H = h;
        }

        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (A==B && B==C && A==C)
                    {
                        return "võrdkülgne";

                    }
                    else if(A==B || B==C || A==C)
                    {
                        return "võrdhaarne";

                    }
                    else
                    {
                        return "erikülgne";

                    }
                }
                else {
                    return "tundmatu tüüp";
                     }
            }
                
        }

        public bool ExistTriangle
        {
            get
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public double GetSetA
        {
            get { return A; }
            set { A = value; }
        }

        public double GetSetB
        {
            get { return B; }
            set { B = value; }
        }

        public double GetSetC
        {
            get { return C; }
            set { C = value; }
        }

        public double GetSetS
        {
            get { return S; }
            set { S = value; }
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double PerimentrL()
        { return (A + B + C)/2;}

        public double Area()
        {
            double s = 0;
            if (ExistTriangle)
            {
                double p = (A + B + C) / 2;
                s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return s;
        }

        public string OutputA()
        {
            return A.ToString();
        }

        public string OutputB()
        {
            return B.ToString();
        }

        public string OutputC()
        {
            return C.ToString();
        }
    }
}



