using System;

namespace ConsoleAppEdu
{
    public class Parallelepiped : Rectangle
    {
        private double _side_c;

        public double side_c
        {
            get => _side_c;
            private set => _side_c = value > 0 ? value : 1;
        }

        /// <summary>
        /// Конструктор единичного куба в начале координат с именем по умолчанию.
        /// </summary>
        public Parallelepiped() : base()
        {
            side_c = 1;
        }

        /// <summary>
        /// Конструктор куба в начале координат с именем по умолчанию.
        /// </summary>
        /// <param name="side">Сторона : double</param>
        public Parallelepiped(double side) : base(side)
        {
            side_c = side;
        }

        /// <summary>
        /// Конструктор куба в начале координат с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="side">Сторона : double</param>
        public Parallelepiped(string name, double side) : base(name, side)
        {
            side_c = side;
        }

        /// <summary>
        /// Конструктор параллелепипеда с именем по умолчанию.
        /// </summary>
        /// <param name="side_a">Ширина : double</param>
        /// <param name="side_b">Длина : double</param>
        /// <param name="side_c">Высота : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Parallelepiped(double side_a, double side_b, double side_c, double x_cord, double y_cord, double z_cord)
            : base(side_a, side_b, x_cord, y_cord, z_cord)
        {
            this.side_c = side_c;
        }

        /// <summary>
        /// Конструктор параллелепипеда с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="side_a">Ширина : double</param>
        /// <param name="side_b">Длина : double</param>
        /// <param name="side_c">Высота : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Parallelepiped(string name, double side_a, double side_b, double side_c, double x_cord, double y_cord, double z_cord)
            : base(name, side_a, side_b, x_cord, y_cord, z_cord)
        {
            this.side_c = side_c;
        }

        /// <summary>
        /// Рассчитывает длину пространственной диагонали параллелепипеда.
        /// </summary>
        /// <returns>Пространственная диагональ : double</returns>
        public override double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(side_a, 2) + Math.Pow(side_b, 2) + Math.Pow(side_c, 2));
        }

        /// <summary>
        /// Рассчитывает площадь полной поверхности параллелепипеда.
        /// </summary>
        /// <returns>Площадь поверхности : double</returns>
        public override double GetArea()
        {
            return 2 * (side_a * side_b + side_a * side_c + side_b * side_c);
        }

        /// <summary>
        /// Рассчитывает сумму длин всех рёбер параллелепипеда.
        /// </summary>
        /// <returns>Сумма длин ребер : double</returns>
        public override double GetPerimeter()
        {
            return 4 * (side_a + side_b + side_c);
        }

        /// <summary>
        /// Рассчитывает объём параллелепипеда.
        /// </summary>
        /// <returns>Объём : double</returns>
        public double GetVolume()
        {
            return side_a * side_b * side_c;
        }

        /// <summary>
        /// Формирует строку с координатами всех восьми вершин параллелепипеда.
        /// </summary>
        /// <returns>Список координат вершин : string</returns>
        public override string GetCornersCoordinates()
        {
            double hA = side_a / 2;
            double hB = side_b / 2;
            double hC = side_c / 2;

            string corners = "\n  Нижний слой (Z-):";
            corners += $"\n    Верхний-Левый: ({x_cord - hA:F1}; {y_cord + hB:F1}; {z_cord - hC:F1})";
            corners += $"\n    Верхний-Правый: ({x_cord + hA:F1}; {y_cord + hB:F1}; {z_cord - hC:F1})";
            corners += $"\n    Нижний-Левый: ({x_cord - hA:F1}; {y_cord - hB:F1}; {z_cord - hC:F1})";
            corners += $"\n    Нижний-Правый: ({x_cord + hA:F1}; {y_cord - hB:F1}; {z_cord - hC:F1})";

            corners += "\n  Верхний слой (Z+):";
            corners += $"\n    Верхний-Левый: ({x_cord - hA:F1}; {y_cord + hB:F1}; {z_cord + hC:F1})";
            corners += $"\n    Верхний-Правый: ({x_cord + hA:F1}; {y_cord + hB:F1}; {z_cord + hC:F1})";
            corners += $"\n    Нижний-Левый: ({x_cord - hA:F1}; {y_cord - hB:F1}; {z_cord + hC:F1})";
            corners += $"\n    Нижний-Правый: ({x_cord + hA:F1}; {y_cord - hB:F1}; {z_cord + hC:F1})";

            return corners;
        }

        protected override string GetSpecificInfo()
        {
            string output = $"Центр: ({x_cord:F0}; {y_cord:F0}; {z_cord:F0}).\n";
            output += $"Стороны: A = {side_a:F1}; B = {side_b:F1}; C = {side_c:F1}.\n";
            output += $"Координаты углов: {GetCornersCoordinates()}\n";
            output += $"Расстояние до начала координат: {GetDistanceToZero():F3}.\n";
            output += $"Пространственная диагональ: {GetDiagonal():F3}.\n";
            output += $"Сумма длин всех ребер: {GetPerimeter():F3}.\n";
            output += $"Площадь поверхности: {GetArea():F3}.\n";
            output += $"Объем: {GetVolume():F3}.";

            return output;
        }
    }
}
