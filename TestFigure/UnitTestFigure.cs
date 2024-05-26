using FigureLibrary;

namespace TestFigure
{
    public class UnitTestFigure
    {
        [Fact]
        public void CircleTest()
        {
            // Arrange
            Figure.Circle circle = new Figure.Circle();

            // Act
            double resultcircle1 = circle.Square(0);
            double resultcircle2 = circle.Square(2);

            // Assert
            Assert.Equal(0, resultcircle1);
            Assert.Equal(13, Math.Round(resultcircle2));
        }

        [Fact]
        public void TriangleTest()
        {
            // Arrange
            Figure.Triangle triangle = new Figure.Triangle();

            // Act
            double resulttriangle1 = triangle.Square(0, 1, 1);
            double resulttriangle2 = triangle.Square(3, 4, 5);
            bool resulttriangletype1 = triangle.IsRectangular(3, 4, 5);
            bool resulttriangletype2 = triangle.IsRectangular(2, 2, 4);

            // Assert
            Assert.Equal(0, resulttriangle1);
            Assert.Equal(6, resulttriangle2);
            Assert.Equal(true, resulttriangletype1);
            Assert.Equal(false, resulttriangletype2);
        }
    }
}