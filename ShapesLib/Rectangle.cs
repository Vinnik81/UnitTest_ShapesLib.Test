using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle: IShape
    {
        /// <summary>
        /// стороны а
        /// </summary>
        public double A { get; }
        /// <summary>
        /// стороны b
        /// </summary>
        public double B { get; }
        /// <summary>
        /// стороны c
        /// </summary>
        public double C { get; }
        /// <summary>
        /// стороны d
        /// </summary>
        public double D { get; }

        /// <summary>
        /// Является ли прямоугольник квадратом
        /// </summary>
        public bool IsSquare => A == B && C == D && B == C && A == D;

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        public double Area => A * B;

        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="a">сторона а</param>
        /// <param name="b">сторона b</param>
        /// <param name="c">сторона с</param>
        /// <param name="d">сторона d</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключения о существовании прямоугольника</exception>
        public Rectangle(double a, double b, double c, double d)
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

            if (d <= 0 || double.IsInfinity(d) || double.IsNaN(d))
            {
                throw new ArgumentOutOfRangeException(nameof(d));
            }

            if (!IsRectangle(a, b, c, d))
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            A = a;
            B = b;
            C = c;
            D = d;
        }

        private static bool IsRectangle(double a, double b, double c, double d)
        {
            return a + c >= b && b + d >= a && a + c >= d && b + d >= c && a == c && b == d;
        }
    }
}
