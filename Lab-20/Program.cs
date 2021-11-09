using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус = ");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(Dlinna);
            Console.WriteLine("Длинна окружности = {0}", myDelegate?.Invoke(r));
            MyDelegate myDelegate2 = new MyDelegate(Square);
            Console.WriteLine("Площадь круга = {0}", myDelegate2?.Invoke(r));
            MyDelegate myDelegate3 = new MyDelegate(Volume);
            Console.WriteLine("Объем шара = {0}", myDelegate3?.Invoke(r));
            Console.ReadKey();
        }
        static double Dlinna(double r)
        {
            double D = 2 * Math.PI * r;
            return D;
        }
        static double Square(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }
        static double Volume(double r)
        {
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            return V;
        }
    }
}
