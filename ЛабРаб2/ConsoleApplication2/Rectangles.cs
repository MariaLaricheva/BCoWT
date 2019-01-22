using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureCollections
{
    class Rectangle : Figure, IPrint
    {
        /// Высота
        double height;
        
        /// Ширина
        double width;
        
        /// Основной конструктор
        public Rectangle(double ph, double pw)
         {
             this.height = ph;
             this.width = pw;
             this.Type = "Прямоугольник";
         }
       
        /// Вычисление площади
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
