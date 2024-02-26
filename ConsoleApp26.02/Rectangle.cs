using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26._02
{
    /// <summary>
    /// Производный класс Rectangle который наследует возможности класса Figure
    /// </summary>
    class Rectangle:Figure
    {
        /// <summary>
        /// Скрытые внутренние поля
        /// </summary>
        int side1;
        int side2;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Конструтор с параметрами
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(string name,int side1, int side2):base(name) 
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Свойства к полям для доступа к ним
        /// </summary>
        public int Side1
        { 
            get { return side1; }
            set { side1 = value; }
        }
        public int Side2
        {
            get { return side2; } 
            set { side2 = value; }
        }

        /// <summary>
        /// метод Area(), возвращающий площадь прямоугольника по его сторонам; 
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side1 * side2;
        }


        /// <summary>
        /// метод Perimeter(), возвращающий периметр прямоугольника по его сторонам;
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return (side1+side2)*2;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Имя фигуры: {Name}");
        }




    }
}
