using System;

class Circle
{
    public double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public bool IsPointInsideCircle(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return distance <= Radius;
    }

    public static int GetNumberOfCirclesFromUser()
    {
        Console.WriteLine("Enter the number of circles you want to create:");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static Circle[] CreateCircles(int numberOfCircles)
    {
        Circle[] circles = new Circle[numberOfCircles];
        for (int i = 0; i < numberOfCircles; i++)
        {
            Console.WriteLine($"Enter the radius for circle {i + 1}:");
            double radius = Convert.ToDouble(Console.ReadLine());
            circles[i] = new Circle(radius);
        }
        return circles;
    }

   static void PrintCircleInformation(Circle[] circles)
    {
        Console.WriteLine("\nCircle Information:");
        for (int i = 0; i < circles.Length; i++)
        {
            Console.WriteLine($"Circle {i + 1} - Radius: {circles[i].Radius}, Area: {circles[i].CalculateArea()}, Perimeter: {circles[i].CalculatePerimeter()}");
        }
    }

    static void CheckPointInCircles(Circle[] circles)
    {
        Console.WriteLine("\nEnter the coordinates of a point to check if it's inside the circles:");
        Console.Write("X coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < circles.Length; i++)
        {
            bool isInside = circles[i].IsPointInsideCircle(x, y);
            Console.WriteLine($"Point ({x},{y}) {(isInside ? "is" : "is not")} inside Circle {i + 1}");
        }


    }

class Program
{
    static void Main(string[] args)
    {
        int numberOfCircles = GetNumberOfCirclesFromUser();
        Circle[] circles = CreateCircles(numberOfCircles);
        PrintCircleInformation(circles);
        CheckPointInCircles(circles);
        Console.ReadLine(); 
    }
}