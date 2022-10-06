using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork12
{
    internal class Okr
    {
        static public double GetDlinOkr(double r) 
        {
            return 2*Math.PI*r;
        }
        static public double GetPloshOkr(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }
        static public double GetPrinodlesh(double r, double x, double y)
        { 
          
            return Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y, 2));
  
        }
    }
}
