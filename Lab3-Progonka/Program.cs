using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Progonka
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new double[] { 0, 1, -1, 1 };
            var b = new double[] { 3, 4, 5, 2 };
            var c = new double[] { 1, -1, 1, 0};
            var d = new double[] { 5, 3, 12, 6};
            var u = new double[4];
            var v = new double[4];
            var x = new double[4];
            u[0] = -c[0] / b[0];
            v[0] = d[0] / b[0];
            for (var i = 1; i < 4; i++)
            {
                u[i] = -c[i] / (a[i] * u[i - 1] + b[i]);
                v[i] = (d[i] - a[i] * v[i - 1]) / (a[i] * u[i - 1] + b[i]);
            }
            x[3] = v[3];
            for (var i = 2; i >=0; i--)
            {
                x[i] = u[i] * x[i + 1] + v[i];
            }
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"x{i + 1} = {x[i]}");
            }
            Console.ReadKey();
        }
    }
}
