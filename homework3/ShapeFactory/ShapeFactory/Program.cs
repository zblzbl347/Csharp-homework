using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
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
                return -1;
        }
    }

    public class ShapeFactory    //简单工厂模式
    {
        public static Shape Create(int shapeNumber, double x, double y, double z)
        {
            switch (shapeNumber)
            {
                case 0:
                    return new Rectangle(x, y);
                case 1:
                    return new Square(x);
                case 2:
                    return new Triangle(x, y, z);
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double AreaSum = 0;
            Random random = new Random();
            int i = 0;
            while (i < 10)
            {
                int temp = random.Next(0, 3);
                int a = random.Next(1, 100);
                int b = random.Next(1, 100);
                int c = random.Next(1, 100);
                Shape shape = ShapeFactory.Create(temp, a, b, c);   //工厂创建对象
                if (shape.IsLegel() == false)
                {
                    continue;    //当图形不合法时，重新生成图形
                }
                Console.WriteLine("第" + (i + 1) + "个图形的面积是：" + shape.Area());
                AreaSum = AreaSum + shape.Area();
                i = i + 1;
            }
            Console.WriteLine("10个图形的面积之和是：" + AreaSum);
        }
    }
}
