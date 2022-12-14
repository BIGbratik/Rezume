using System;

namespace Rezume
{
    public static class Areas
    {
        public static double AreaTriangle(double a, double b, double c) //Calculating the area of a triangle
        {
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    return b * c / 2 * Math.Sin(90 * Math.PI / 180);
                else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    return a * c / 2 * Math.Sin(90 * Math.PI / 180);
                else if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    return a * b / 2 * Math.Sin(90 * Math.PI / 180);
                else
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }
            else
                throw new Exception("Треугольника с такими сторонами не существует!");

        }

        public static double AreaCircle(double r) //Calculating the area of a circle
        {
            if (r >= 0)
                return Math.PI * Math.Pow(r, 2);
            else
                throw new Exception("Окружности с заданным радиусом не существует!");
        }
    }
}