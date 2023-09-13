namespace ShapesLib
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle: IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }
        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Area => Math.PI * Radius * Radius;
        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус меньше или равен нулю или равен бесконечности или равен NaN</exception>
        public Circle(double radius)
        {
            if (radius <= 0d || double.IsInfinity(radius) || double.IsNaN(radius))
            {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }
            Radius = radius;
        }
    }
}