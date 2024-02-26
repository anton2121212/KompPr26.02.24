using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26._02
{
    /// <summary>
    /// Разработать абстрактный класс Figure, в котором определить следующие элементы:
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// скрытое внутреннее поле name (название фигуры);
        /// </summary>
        string name;

        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public Figure() { }


        /// <summary>
        /// конструктор с одним параметром, инициализирующий поле name указанным значением;
        /// </summary>
        /// <param name="name"></param>
        public Figure (string name)
        {
            this.name = name;
        }

        /// <summary>
        /// свойство Name для доступа к внутреннему полю name;
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// абстрактный метод Area(), предназначенный для получения площади фигуры
        /// </summary>
        public abstract double Area();


        /// <summary>
        ///  абстрактный метод Perimeter(), предназначенный для получения периметра фигуры
        /// </summary>
        public abstract double Perimeter();


        /// <summary>
        /// Виртуальный метод для вывода
        /// </summary>
        virtual public void Print()
        {
            Console.WriteLine($"Название фигуры: {name}");
        }
        

    }
}
