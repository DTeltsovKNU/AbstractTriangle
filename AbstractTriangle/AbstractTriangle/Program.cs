using System;

namespace AbstractTriangle
{
    abstract class Triangle
    {
        protected double a;
        protected double b;
        protected double angle;

        public virtual void Perimeter() { }
        public virtual void Area() { }
    }

    class Right : Triangle
    {
        public Right(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.angle = 90;
        }

        public override void Area()
        {
            double s = 0.5 * a * b * Math.Sin(angle);
            Console.WriteLine("Площадь прямоугольного треугольника = " + Math.Round(s, 2));
        }

        public override void Perimeter()
        {
            double p = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) + a + b;
            Console.WriteLine("Периметр прямоугольного треугольника = " + Math.Round(p, 2));
        }
    }

    class Isosceles : Triangle
    {
        public Isosceles(double a, double angle)
        {
            this.a = a;
            this.b = a;
            this.angle = angle;
        }

        public override void Area()
        {
            double s = 0.5 * a * b * Math.Abs(Math.Sin(angle));
            Console.WriteLine("Площадь равнобедренного треугольника = " + Math.Round(s, 2));
        }

        public override void Perimeter()
        {
            double beta = ((180 - angle) / 2);
            double gamma = 90 - beta;
            double c = a * Math.Sin(gamma);
            double p = a + b + c;
            Console.WriteLine("Периметр равнобедренного треугольника = " + Math.Round(p, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Right r = new Right(4, 5);
            r.Perimeter();
            r.Area();
            Isosceles i = new Isosceles(5, 80);
            i.Area();
            i.Perimeter();
        }
    }
}
