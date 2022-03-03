using System;

namespace CreateLinearSplineFunctions
{
    class Spline
    {
        public string LinearSplineFunc(double x, double x1, double fx, double fx1)
        {
            double a1 = (fx1 - fx) / (x1 - x);
            double a0 = fx - a1 * x;
            string func = a0.ToString() + " + " + a1.ToString() + "x";
            return func;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Oraqlar soni: i = ");

            int n = int.Parse(Console.ReadLine());

            double[] x = new double[n];

            double[] fx = new double[n];

            Console.WriteLine("x lar qiymatini kiriting: ");

            for (int i = 0; i < n; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("f(x) lar qiymatini kiriting: ");

            for (int i = 0; i < n; i++)
            {
                fx[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Chiziqli Splayn funksiyalar: ");

            Spline spline = new Spline();

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(spline.LinearSplineFunc(x[i + 1], x[i], fx[i+1], fx[i]));
            }

            Console.ReadKey();
        }
    }
}
