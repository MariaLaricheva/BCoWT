using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCollections
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

        static void Main()
        {
            double rect_w, rect_h, circle_r,square_s;

            rect_w = ReadDouble("Введите длину прямоугольника");
            rect_h = ReadDouble("Введите ширину прямоугольника");
            circle_r = ReadDouble("Введите радиус окружности");
            square_s = ReadDouble("Введите длину стороны квадрата");

            Console.Write("\nСоздаём фигуры..");

            Rectangle RECT = new Rectangle(rect_w, rect_h);
            Circle CIRC = new Circle(circle_r);
            Square SQUA = new Square(square_s);

            Console.Write("\nВыводим характеристику фигур..");

            Console.WriteLine();
            RECT.Print();
            Console.WriteLine();
            CIRC.Print();
            Console.WriteLine();
            SQUA.Print();

            rect_h = ReadDouble("\nВведите любое число чтобы выйти");

        }
    }
}
