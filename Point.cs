using System;

namespace ConsoleAppEdu
{
    public class Point
    {
        public string name { get; private set; }
        public double x_cord { get; private set; }
        public double y_cord { get; private set; }
        public double z_cord { get; private set; }

        /// <summary>
        /// Конструктор точки в двумерном пространстве в начале координат с именем по умолчанию.
        /// </summary>
        public Point() 
        { 
            name = "A"; 
            x_cord = 0; 
            y_cord = 0; 
            z_cord = 0; 
        }

        /// <summary>
        /// Конструктор точки в двумерном пространстве в начале координат.
        /// </summary>
        /// <param name="name">Имя : string</param>
        public Point(string name) : this()
        {
            this.name = name;
        }

        /// <summary>
        /// Конструктор точки в двумерном пространстве с именем по умолчанию.
        /// </summary>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Point(double x_cord, double y_cord) : this()
        {
            this.x_cord = x_cord;
            this.y_cord = y_cord;
        }

        /// <summary>
        /// Конструктор точки в двумерном пространстве.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        public Point(string name, double x_cord, double y_cord) : this()
        {
            this.name = name;
            this.x_cord = x_cord;
            this.y_cord = y_cord;
        }

        /// <summary>
        /// Конструктор точки в трёхмерном пространстве с именем по умолчанию.
        /// </summary>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Point(double x_cord, double y_cord, double z_cord) : this()
        {
            name = "A";
            this.x_cord = x_cord;
            this.y_cord = y_cord;
            this.z_cord = z_cord;
        }

        /// <summary>
        /// Конструктор точки в трёхмерном пространстве.
        /// </summary>
        /// <param name="name">Имя : string</param>
        /// <param name="x_cord">Координата по x : double</param>
        /// <param name="y_cord">Координата по y : double</param>
        /// <param name="z_cord">Координата по z : double</param>
        public Point(string name, double x_cord, double y_cord, double z_cord)
        {
            this.name = name;
            this.x_cord = x_cord;
            this.y_cord = y_cord;
            this.z_cord = z_cord;
        }


        /// <summary>
        /// Нахождение расстояния от точки до начала координат.
        /// </summary>
        /// <returns>Расстояние : double</returns>
        public double GetDistanceToZero()
        {
            double d = 0;
            if (z_cord == 0) { d = Math.Sqrt(x_cord * x_cord + y_cord * y_cord); }
            if (z_cord != 0) { d = Math.Sqrt(x_cord * x_cord + y_cord * y_cord + z_cord * z_cord); }

            return d;
        }

        /// <summary>
        /// Вывод информации о точке.
        /// </summary>
        public virtual string GetInfo()
        {
            string output = new string('-', 70) + $"\n - Информация об объекте \"{name}\" - \n" + new string('-', 70) + "\n";

            output += GetSpecificInfo() + "\n";

            output += new string('-', 70);

            return output;
        }

        protected virtual string GetSpecificInfo()
        {
            string output = "";
            if (z_cord == 0)
            {
                output += $"Координаты точки: ({x_cord:F0}; {y_cord:F0}).\n";
            }
            if (z_cord != 0)
            {
                output += $"Координаты точки: ({x_cord:F0}; {y_cord:F0}; {z_cord:F0}).\n";
            }
            output += $"Расстояние от точки до начала координат: {GetDistanceToZero():F3}.";

            return output;
        }
    }
}

