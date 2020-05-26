using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public interface Shape
    {
        double Area();
        bool IsLegel();
    }

    class Rectangle : Shape
    {
        private double xWidth;
        private double yHeight;
        public Rectangle(double width, double height)
        {
            xWidth = width;
            yHeight = height;
        }
        public bool IsLegel()
        {
            if (xWidth > 0 && yHeight > 0)
            {
                return true;
            }
            return false;
        }
        public double Area()
        {
            if (IsLegel())
            {
                return xWidth * yHeight;
            }
            else
                Console.WriteLine("图形不合法！");
            return -1;
        }
    }

    class Square : Shape
    {
        private double xSide;
        public Square(double side)
        {
            xSide = side;
        }
        public bool IsLegel()
        {
            if (xSide > 0)
            {
                return true;
            }
            return false;
        }
        public double Area()
        {
            if (IsLegel())
            {
                return xSide * xSide;
            }
            else
                Console.WriteLine("图形不合法！");
            return -1;
        }
    }

    class Triangle : Shape
    {
        private double aLength;
        private double bLength;
        private double cLength;
        public Triangle(double a, double b, double c)
        {
            aLength = a;
            bLength = b;
            cLength = c;
        }
        public bool IsLegel()
        {
            if (aLength > 0 && bLength > 0 && cLength > 0 && aLength + bLength > cLength && bLength + cLength > aLength && aLength + cLength > bLength)
            {
                return true;
            }
            else
                return false;
        }
        public double Area()
        {
            if (IsLegel())
            {
                double p = (aLength + bLength + cLength) / 2;
                double tSquare = Math.Sqrt(p * (p - aLength) * (p - bLength) * (p - cLength));
                return tSquare;
            }
            else
                Console.WriteLine("图形不合法！");
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(3, 5);
            Console.WriteLine("长方形的面积是：" + rectangle.Area());
            Square square = new Square(8);
            Console.WriteLine("正方形的面积是：" + square.Area());
            Triangle triangle = new Triangle(7, 8, 9);
            Console.WriteLine("三角形的面积是：" + triangle.Area());
        }
    }
}
