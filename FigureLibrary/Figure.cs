namespace FigureLibrary
{
    public class Figure
    {
        public class Circle
        {
            public double Square(double radius)
            {
                if (IsAcceptable(radius))
                {
                    return Math.PI * Math.Pow(radius, 2);
                }
                else
                {
                    return 0;
                }
            }

            private bool IsAcceptable(double radius)
            {
                if (radius > 0)
                {
                    return true;
                }
                return false;
            }
        }


        public class Triangle
        {
            public double Square(double a, double b, double c)
            {
                if (IsAcceptable(a, b, c))
                {
                    double perimeter = Perimeter(a, b, c);
                    return Math.Sqrt((perimeter / 2) * ((perimeter / 2) - a) * ((perimeter / 2) - b) * ((perimeter / 2) - c));
                }
                else
                {
                    return 0;
                }
            }

            public bool IsRectangular(double a, double b, double c)
            {
                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                {
                    return true;
                }
                return false;
            }

            private double Perimeter(double a, double b, double c)
            {
                return (a + b + c);
            }

            private bool IsAcceptable(double a, double b, double c)
            {
                if (((a + b) > c) & ((b + c) > a) && ((a + c) > b) && a > 0 && b > 0 && c > 0)
                {
                    return true;
                };
                return false;
            }
        }
    }
}
