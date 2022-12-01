using System;


namespace Interface_Square_Circle_Rectangle_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice 1.Circle 2.Square 3.Rectangle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

            case 1:

            Circle circle = new Circle();
            circle.Radius();

            Console.WriteLine("AREA OF CIRCLE");
            circle.FindArea();


            Console.WriteLine("PERIMETER OF CIRCLE");
            circle.FindPerimeter();
            
            break;

            case 2:

            Square square = new Square();
            square.Squareside();

            Console.WriteLine("AREA OF SQUARE");
            square.FindArea();


            Console.WriteLine("PERIMETER OF SQUARE");
            square.FindPerimeter();

            break;

            case 3:

             Rectangle rectangle = new Rectangle();
             rectangle.RectangleParameters();

             Console.WriteLine("AREA OF RECTANGLE");
             rectangle.FindArea();

             Console.WriteLine("PERIMETER OF RECTANGLE");
             rectangle.FindPerimeter();

            break;

            default:

            Console.WriteLine("Invalid choice");
            break;

            }
        }    
    }
}




