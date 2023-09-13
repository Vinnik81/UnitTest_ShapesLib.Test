using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle: IShape
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        public double A { get; }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; }
        /// <summary>
        /// Полупериметр
        /// </summary>
        double S => (A + B + C) / 2;
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public double Area => Math.Sqrt(S * (S - A) * (S - B) * (S - C));
        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        public bool IsRight =>
            Math.Abs(A * A + B * B - C * C) < 0.000000000001d
            || Math.Abs(A * A + C * C - B * B) < 0.000000000001d
            || Math.Abs(B * B + C * C - A * A) < 0.000000000001d;
        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="a">Сторона а</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона с</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключения по существованию треугольника</exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || double.IsInfinity(a) || double.IsNaN(a))
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }
            if (b <= 0 || double.IsInfinity(b) || double.IsNaN(b))
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }
            if (c <= 0 || double.IsInfinity(c) || double.IsNaN(c))
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }
            if (!IsExist(a, b, c))
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            A = a;
            B = b;
            C = c;
        }
       
        private static bool IsExist(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
