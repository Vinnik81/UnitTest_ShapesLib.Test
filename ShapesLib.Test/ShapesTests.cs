
namespace ShapesLib.Test
{
    public class ShapesTests
    {
        [Fact]
        public void Circle_is_created()
        {
            var circle = new Circle(radius: 10d);
            circle.Radius.Should().Be(10d);
        }

        [Theory]
        [InlineData(-1d)]
        [InlineData(0d)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [InlineData(double.NaN)]
        public void Creation_of_circle_with_incorrect_radius_is_rejected(double radius)
        {
            FluentActions.Invoking(() => new Circle(radius))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Circle_area_is_calculated()
        {
            var circle = new Circle(radius: 10d);
            circle.Area.Should().BeApproximately(314.1592653589793d, 0.000000000001d);
        }

        [Fact]
        public void Triangle_is_created()
        {
            var triangle = new Triangle(a: 10d, b: 20d, c: 29d);
            triangle.A.Should().Be(10d);
            triangle.B.Should().Be(20d);
            triangle.C.Should().Be(29d);
        }

        [Theory]
        [InlineData(-1d, 2d, 3d)]
        [InlineData(1d, -2d, 3d)]
        [InlineData(1d, 2d, -3d)]
        [InlineData(0d, 2d, 3d)]
        [InlineData(1d, 0d, 3d)]
        [InlineData(1d, 2d, 0d)]
        [InlineData(double.NegativeInfinity, 2d, 3d)]
        [InlineData(1d, double.NegativeInfinity, 3d)]
        [InlineData(1d, 2d, double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity, 2d, 3d)]
        [InlineData(1d, double.PositiveInfinity, 3d)]
        [InlineData(1d, 2d, double.PositiveInfinity)]
        [InlineData(double.NaN, 2d, 3d)]
        [InlineData(1d, double.NaN, 3d)]
        [InlineData(1d, 2d, double.NaN)]
        public void Creation_of_triangle_with_incorrect_sides_is_rejected(double a, double b, double c)
        {
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1d, 2d, 4d)]
        [InlineData(4d, 1d, 2d)]
        [InlineData(1d, 2d, 3d)]
        [InlineData(1d, 2d, 3.5)]
        public void Creation_of_not_existed_triangle_is_rejected(double a, double b, double c)
        {
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Circle_and_triangle_and_rectangle_are_shapes()
        {
            var circle = new Circle(radius: 10d);
            var triangle = new Triangle(a: 10d, b: 21d, c: 30d);
            var rectangle = new Rectangle(a: 10d, b: 20d, c: 10d, d: 20d);
            circle.Should().BeAssignableTo<IShape>();
            triangle.Should().BeAssignableTo<IShape>();
            rectangle.Should().BeAssignableTo<IShape>();
        }

        [Theory]
        [InlineData(3d, 4d, 5d, true)]
        [InlineData(2d, 4d, 5d, false)]
        public void Right_triangle(double a, double b, double c, bool isRight)
        {
            var triangle = new Triangle(a, b, c);
            triangle.IsRight.Should().Be(isRight);
        }

        [Fact]
        public void Triangle_area_is_calculated()
        {
            var triangle = new Triangle(a: 10d, b: 20d, c: 29d);
            triangle.Area.Should().BeApproximately(52.27272233201558, 0.000000000001d);
        }

        [Fact]
        public void Rectangle_is_created()
        {
            var rectangle = new Rectangle(a: 10d, b: 20d, c: 10d, d: 20d);
            rectangle.A.Should().Be(10d);
            rectangle.B.Should().Be(20d);
            rectangle.C.Should().Be(10d);
            rectangle.D.Should().Be(20d);
        }

        [Theory]
        [InlineData(-1d, 4d, -1d, 4d)]
        [InlineData(1d, -4d, 1d, -4d)]
        [InlineData(1d, 4d, -1d, 4d)]
        [InlineData(0d, 4d, 0d, 4d)]
        [InlineData(1d, 0d, 1d, 0d)]
        [InlineData(1d, 4d, 0d, 4d)]
        [InlineData(1d, 4d, 1d, 0d)]
        [InlineData(double.NegativeInfinity, 4d, double.NegativeInfinity, 4d)]
        [InlineData(1d, double.NegativeInfinity, 1d, double.NegativeInfinity)]
        [InlineData(1d, 4d, double.NegativeInfinity, 4d)]
        [InlineData(double.PositiveInfinity, 4d, double.PositiveInfinity, 4d)]
        [InlineData(1d, double.PositiveInfinity, 1d, double.PositiveInfinity)]
        [InlineData(1d, 4d, double.PositiveInfinity, 4d)]
        [InlineData(double.NaN, 4d, double.NaN, 4d)]
        [InlineData(1d, double.NaN, 1d, double.NaN)]
        [InlineData(1d, 4d, double.NaN, 4d)]
        public void Creation_of_rectangle_with_incorrect_sides_is_rejected(double a, double b, double c, double d)
        {
            FluentActions.Invoking(() => new Rectangle(a, b, c, d))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1d, 2d, 4d, 5d)]
        [InlineData(4d, 1d, 2d, 5d)]
        public void Creation_of_not_rectangle_is_rejected(double a, double b, double c, double d)
        {
            FluentActions.Invoking(() => new Rectangle(a, b, c, d))
                .Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(3d, 3d, 3d, 3d, true)]
        [InlineData(2d, 4d, 2d, 4d, false)]
        public void Square(double a, double b, double c, double d, bool isSquare)
        {
            var rectangle = new Rectangle(a, b, c, d);
            rectangle.IsSquare.Should().Be(isSquare);
        }

        [Fact]
        public void Rectangle_area_is_calculated()
        {
            var rectangle = new Rectangle(a: 10d, b: 20d, c: 10d, d: 20d);
            rectangle.Area.Should().BeApproximately(200d, 0.000000000001d);
        }
    }
}