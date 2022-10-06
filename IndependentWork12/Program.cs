using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести радиус");
            double r=Convert.ToDouble(Console.ReadLine());
            double l_ = Okr.GetDlinOkr(r);
            double s_ = Okr.GetPloshOkr(r);
            Console.WriteLine("Ввести X,Y");
            double x=Convert.ToDouble(Console.ReadLine());
            double y=Convert.ToDouble(Console.ReadLine());
            double p_ = Okr.GetPrinodlesh(r, x, y);
            
                Console.WriteLine($"1)Длина окружности L={l_:.00} \n2)Площадь окружности S={s_:.00} \n3)Гепатинуза H={p_:.00}");
            if (p_ <= r)
            {
                Console.WriteLine("Точка принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит кругу"); 
            }
            Console.ReadKey();




        }

    }
}
