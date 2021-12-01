using System;

namespace z1_1
{
    class Circle
    {
        private double Radius = 0.0;
        private double Area = 0.0;
        private double Pi = Math.PI;
        public Circle()
        {
            fillArea();
        }

        public void fillArea()
        {
            Try:
            Console.Write("Введите площадь: ");
            if (Double.TryParse(Console.ReadLine(), out Area))
            {
                showCircle();
            }
            else
            {
                Console.Write("Попробуйте ещё раз:\n");
                goto Try;
            }
        }
        public void showCircle()
        {
            Radius = Math.Sqrt(Area / Pi);
            Console.Write("R = " + Radius);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.ReadKey();
        }
    }
}
