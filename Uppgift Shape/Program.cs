using System;
using System.Drawing;

namespace ShapeProgram
{
    class Shape
    {
        protected double width;
        protected double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) 
        { 
        }

        public double Area()
        {
            return width * height;
        }

        public double Circumference()
        {
            double x = width * 2;
            double y = height * 2;
            return x + y;
        }

    }

    class Triangel : Shape
    {
        public Triangel(double width, double height) : base(width, height)
        {
        }

        public double Area()
        {
            return (width * height) / 2;
        }

        public double Circumference()
        {
            double hypotenusa = Math.Sqrt((width * width) + (height*height)); //Räknar ut hypotenusan
            double omkrets = hypotenusa + width + height;
            return omkrets;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange formens bredd");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange formens höjd");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Är det en rektangel eller en rätvinklig triangel?");
            string figur = Console.ReadLine().ToLower();

            if (figur == "rektangel")
            {
                Rectangle rektangel = new Rectangle(width, height);
                Console.WriteLine($"Arean av rektanglen är: {rektangel.Area()}");
                Console.WriteLine($"Omkretsen av rektanglen är: {rektangel.Circumference()}");
            }
            else if (figur == "triangel")
            {
                Triangel triangel = new Triangel(width, height);
                Console.WriteLine($"Arean av trianglen är: {triangel.Area()}");
                Console.WriteLine($"Omkretsen av trianglen är: {triangel.Circumference()}");
            }
            else
            {
                Console.WriteLine("Du kan bara välja rektangel eller rätvinklig triangel...");
            }
          
        
        }
    }
}


