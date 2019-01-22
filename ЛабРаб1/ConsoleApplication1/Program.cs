using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double ReadDouble(string message)
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write(message);
                resultString = Console.ReadLine();
                flag = double.TryParse(resultString, out resultDouble);
           
                if (!flag)
                {
                    Console.WriteLine("Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }
         
        static void Main(string[] args)
        {
            bool quit;
            do
            {
                Console.WriteLine("Введите коэффициенты квадратного уравнения");

                double A, B, C;

                A = ReadDouble("\nA=");
                B = ReadDouble("\nB=");
                C = ReadDouble("\nC=");

                Console.WriteLine("\nВы ввели числа:{0}; {1}; {2};\nПроводим вычисления...", A, B, C);

                double D;
                D = B * B - 4 * A * C;

                Console.WriteLine("Дискриминант выражения - {0}", D);

                if (D > 0)
                {
                    D = Math.Sqrt(D);
                    double x1 = (-B - D) / 2;
                    double x2 = (-B + D) / 2;

                    Console.WriteLine("\nКорни уравнения:{0}; {1};\nВведите 0 чтобы выйти...", x1, x2);
                }
                else if (D == 0)
                {
                    Console.WriteLine("\nУ уравнения один корень: {0};\nВведите 0 чтобы выйти...", -B / 2);
                }
                else 
                {
                    Console.WriteLine("\nУ уравнения нет вещественных корней;\nВведите 0 чтобы выйти...");
                }

                string str = Console.ReadLine();
                if (str == "0") quit = false;
                else quit = true;

            } while (quit);


        }
    }
}
