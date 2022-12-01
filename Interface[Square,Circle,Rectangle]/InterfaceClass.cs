using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Square_Circle_Rectangle_
{
   
        interface IGeometry
        {
            void FindArea();

            void FindPerimeter();

        }

        class Circle : IGeometry
        {
            double pi = 3.147;
            public float radius;
            public void Radius()
            {

                Console.WriteLine("Enter The Radius of Circle : ");
                radius = float.Parse(Console.ReadLine());

            }
            public void FindArea()
            {
                double circlearea = pi * radius * radius;
                Console.WriteLine("The Area Of Circle : " + circlearea);
            }

            public void FindPerimeter()
            {
                double circleperimeter = 2 * pi * radius;
                Console.WriteLine("The Perimeter Of Circle : " + circleperimeter);
            }

        }

        class Rectangle : IGeometry
        {
            public float rectanglebredth;
            public float rectanglelength;

            public void RectangleParameters()
            {

                Console.WriteLine("Enter The Length of Rectangle : ");
                rectanglelength = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Bredth of Rectangle : ");
                rectanglebredth = float.Parse(Console.ReadLine());

            }
            public void FindArea()
            {
                float rectanglearea = rectanglelength * rectanglebredth;
                Console.WriteLine("The Area Of Rectangle : " + rectanglearea);
            }

            public void FindPerimeter()
            {
                float rectangleperimeter = 2 * (rectanglelength + rectanglebredth);
                Console.WriteLine("The Perimeter Of Rectangle : " + rectangleperimeter);
            }
        }

        class Square : IGeometry
        {
            public float squareside;
            public void Squareside()
            {

                Console.WriteLine("Enter The Length of Square : ");
                squareside = float.Parse(Console.ReadLine());

            }

            public void FindArea()
            {
                float squarearea = squareside * squareside;
                Console.WriteLine("The  Area Of Square : " + squarearea);
            }

            public void FindPerimeter()
            {
                float squareperimeter = 4 * squareside;
                Console.WriteLine("The Perimeter Of Square : " + squareperimeter);

            }

        }
}
