using System;

namespace ConsoleAppEdu
{
    public class Sphere : Circle
    {
        /// <summary>
        /// Конструктор единичной сферы в начале координат с именем по умолчанию.
        /// </summary>
        public Sphere() : base() { }

        /// <summary>
        /// Конструктор сферы в начале координат.
        /// </summary>
        /// <param name="radius">Радиус : double</param>
        public Sphere(double radius) : base(radius) { }

        /// <summary>
        /// Конструктор сферы в начале координат с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="radius">Радиус : double</param>
        public Sphere(string name, double radius) : base(name, radius) { }

        /// <summary>
        /// Конструктор сферы в трёхмерном пространстве с именем по умолчанию.
        /// </summary>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Sphere(double radius, double x_cord, double y_cord, double z_cord)
            : base(radius, x_cord, y_cord, z_cord) { }

        /// <summary>
        /// Конструктор сферы в трёхмерном пространстве с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Sphere(string name, double radius, double x_cord, double y_cord, double z_cord)
            : base(name, radius, x_cord, y_cord, z_cord) { }

        /// <summary>
        /// Рассчитывает площадь поверхности сферы.
        /// </summary>
        /// <returns>Площадь поверхности : double</returns>
        public override double GetArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Рассчитывает объем шара.
        /// </summary>
        /// <returns>Объем : double</returns>
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Вычисляет координаты случайной точки на поверхности сферы.
        /// </summary>
        /// <returns>Координаты : string</returns>
        public override string GetExamplePoint()
        {
            Random rnd = new Random();
            double u = rnd.NextDouble();
            double v = rnd.NextDouble();
            double theta = 2 * Math.PI * u;
            double phi = Math.Acos(2 * v - 1);

            double x = x_cord + radius * Math.Sin(phi) * Math.Cos(theta);
            double y = y_cord + radius * Math.Sin(phi) * Math.Sin(theta);
            double z = z_cord + radius * Math.Cos(phi);

            return $"({x:F3}; {y:F3}; {z:F3})";
        }

        protected override string GetSpecificInfo()
        {
            string output = $"Координаты центра: ({x_cord:F0}; {y_cord:F0}; {z_cord:F0}).\n";
            output += $"Радиус: {radius:F3}.\n";
            output += $"Пример точки на поверхности: {GetExamplePoint()}.\n";
            output += $"Расстояние до начала координат: {GetDistanceToZero():F3}.\n";
            output += $"Площадь поверхности: {GetArea():F3}.\n";
            output += $"Объем: {GetVolume():F3}.";

            return output;
        }
    }
}
