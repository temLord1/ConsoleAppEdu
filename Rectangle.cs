using System;

namespace ConsoleAppEdu
{
    public class Rectangle : Point
    {
        private double _side_a;
        private double _side_b;

        public double side_a
        {
            get => _side_a;
            private set => _side_a = value > 0 ? value : 1;
        }

        public double side_b
        {
            get => _side_b;
            private set => _side_b = value > 0 ? value : 1;
        }

        /// <summary>
        /// Конструктор квадрата стороной 1 в начале координат с именем по умолчанию.
        /// </summary>
        public Rectangle() : base()
        {
            side_a = 1;
            side_b = 1;
        }

        /// <summary>
        /// Конструктор квадрата в начале координат с именем по умолчанию.
        /// </summary>
        /// <param name="side">Сторона : double</param>
        public Rectangle(double side) : base()
        {
            side_a = side;
            side_b = side;
        }

        /// <summary>
        /// Конструктор квадрата в начале координат с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="side">Сторона : double</param>
        public Rectangle(string name, double side) : base(name)
        {
            side_a = side;
            side_b = side;
        }

        /// <summary>
        /// Конструктор прямоугольника с именем по умолчанию.
        /// </summary>
        /// <param name="side_a">Ширина : double</param>
        /// <param name="side_b">Длина : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Rectangle(double side_a, double side_b, double x_cord, double y_cord) : base(x_cord, y_cord)
        {
            this.side_a = side_a;
            this.side_b = side_b;
        }

        /// <summary>
        /// Конструктор прямоугольника с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="side_a">Ширина : double</param>
        /// <param name="side_b">Длина : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Rectangle(string name, double side_a, double side_b, double x_cord, double y_cord) : base(name, x_cord, y_cord)
        {
            this.side_a = side_a;
            this.side_b = side_b;
        }

        protected Rectangle(double side_a, double side_b, double x_cord, double y_cord, double z_cord) : base(x_cord, y_cord, z_cord)
        {
            this.side_a = side_a;
            this.side_b = side_b;
        }

        protected Rectangle(string name, double side_a, double side_b, double x_cord, double y_cord, double z_cord) : base(name, x_cord, y_cord, z_cord)
        {
            this.side_a = side_a;
            this.side_b = side_b;
        }

        /// <summary>
        /// Рассчитывает длину диагонали четырёхугольника.
        /// </summary>
        /// <returns>Диагональ : double</returns>
        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(side_a, 2) + Math.Pow(side_b, 2));
        }

        /// <summary>
        /// Рассчитывает площадь четырёхгольника.
        /// </summary>
        /// <returns>Площадь : double</returns>
        public virtual double GetArea()
        {
            return side_a * side_b;
        }

        /// <summary>
        /// Рассчитывает периметр четырёхугольника.
        /// </summary>
        /// <returns>Периметр : double</returns>
        public virtual double GetPerimeter()
        {
            return 2 * (side_a + side_b);
        }

        /// <summary>
        /// Формирует строку с координатами всех четырех углов прямоугольника.
        /// </summary>
        /// <returns>Список координат углов : string</returns>
        public virtual string GetCornersCoordinates()
        {
            double half_a = side_a / 2;
            double half_b = side_b / 2;

            string corners = $"\n  Верх-Лево:  ({x_cord - half_a:F1}; {y_cord + half_b:F1})";
            corners += $"\n  Верх-Право: ({x_cord + half_a:F1}; {y_cord + half_b:F1})";
            corners += $"\n  Низ-Лево:   ({x_cord - half_a:F1}; {y_cord - half_b:F1})";
            corners += $"\n  Низ-Право:  ({x_cord + half_a:F1}; {y_cord - half_b:F1})";

            return corners;
        }

        protected override string GetSpecificInfo()
        {
            string output = $"Центр (пересечение диагоналей): ({x_cord:F0}; {y_cord:F0}).\n";
            output += $"Стороны: A = {side_a:F1}; B = {side_b:F1}.\n";
            output += $"Координаты углов: {GetCornersCoordinates()}\n";
            output += $"Расстояние до начала координат: {GetDistanceToZero():F3}.\n";
            output += $"Диагональ: {GetDiagonal():F3}.\n";
            output += $"Периметр: {GetPerimeter():F3}.\n";
            output += $"Площадь: {GetArea():F3}.";

            return output;
        }
    }
}
