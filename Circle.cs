using System;

namespace ConsoleAppEdu
{
    public class Circle : Point
    {
        private double _radius;
        public double radius
        {
            get => _radius;
            private set => _radius = value > 0 ? value : 1;
        }

        /// <summary>
        /// Конструктор единичной окружности в двумерном пространстве с именем по умолчанию.
        /// </summary>
        public Circle() : base()
        {
            radius = 1;
        }

        /// <summary>
        /// Конструктор единичной окружности в двумерном пространстве в начале координат с именем по умолчанию.
        /// </summary>
        /// <param name="radius">Радиус : double</param>
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }

        /// <summary>
        /// Конструтор единичной окружности в двумерном пространстве в начале координат с именем.
        /// </summary>
        /// <param name="name">Имя для круга : string</param>
        /// <param name="radius">Радиус : double</param>
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Конструктор окружности в двумерном пространстве с именем по умолчанию.
        /// </summary>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Circle(double radius, double x_cord, double y_cord) : base(x_cord, y_cord)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Конструктор окружности в двумерном пространстве с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Circle(string name, double radius, double x_cord, double y_cord) : base(name, x_cord, y_cord)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Конструктор окружности в трёхмерном пространстве с именем по умолчанию.
        /// </summary>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Circle(double radius, double x_cord, double y_cord, double z_cord) : base(x_cord, y_cord, z_cord)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Конструктор окружности в трёхмерном пространстве с именем.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="radius">Радиус : double</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Circle(string name, double radius, double x_cord, double y_cord, double z_cord) : base(name, x_cord, y_cord, z_cord)
        {
            this.radius = radius;
        }
        
        /// <summary>
        /// Метод для подсчёта длины окружности.
        /// </summary>
        /// <returns>Длина окружности : double</returns>
        public double GetLength()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Метод для подсчёта площади круга.
        /// </summary>
        /// <returns>Площадь круга : double</returns>
        public virtual double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Возвращает случайную точку, лежащую на данной окружности.
        /// </summary>
        /// <returns>Координаты : string</returns>
        public virtual string GetExamplePoint()
        {
            Random rnd = new Random();
            double angle = rnd.NextDouble() * 2 * Math.PI;
            double x = x_cord + radius * Math.Cos(angle);
            double y = y_cord + radius * Math.Sin(angle);

            return $"({x:F3}; {y:F3})";
        }

        protected override string GetSpecificInfo()
        {
            string output = "";

            output += $"Координаты центра: ({x_cord:F0}; {y_cord:F0}).\n";
            output += $"Радиус: {radius:F3}.\n";
            output += $"Пример точки на окружности: {GetExamplePoint()}.\n";
            output += $"Расстояние от центра окружности до начала координат: {GetDistanceToZero():F3}.\n";
            output += $"Длина окружности: {GetLength():F3}.\n";
            output += $"Площадь: {GetArea():F3}.";

            return output;
        }

    }
}
