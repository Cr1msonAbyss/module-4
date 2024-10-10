using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    internal interface IFigureArPr
    {
        double Area();

        double Perim();
    }



    public class Circle : IFigureArPr
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public  double Area()
        {   
            return Math.PI * Radius * Radius;
        }



        public  double Perim()
        {
            return Math.PI * Radius * 2;
        }
    }


    public class Rectangle : IFigureArPr
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public  double Area()
        {
            return Width * Height;
        }
        public double Perim()
        {
            return (Width + Height)*2;
        }
    }


    public class Triangle : IFigureArPr
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double SideA, double SideB, double SideC)
        {
            Side1 = SideA;
            Side2 = SideB;
            Side3 = SideC;
        }

        public  double Area()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        public  double Perim()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
