using System;

public class Point
{
    private double x;
    private double y;
    private string name;

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }

    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}

public class Figure
{
    private Point[] points;

    // Конструктор для 3-5 точек
    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("The number of points must be between 3 and 5.");
        }

        this.points = points;
    }

    // Метод для обчислення довжини сторони
    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Метод для обчислення периметру
    public void CalculatePerimeter()
    {
        double perimeter = 0.0;

        for (int i = 0; i < points.Length; i++)
        {
            perimeter += GetSideLength(points[i], points[(i + 1) % points.Length]);
        }

        Console.WriteLine($"The perimeter of the figure is: {perimeter}");
    }

    // Метод для виведення назви фігури (за кількістю точок)
    public void PrintName()
    {
        string name = points.Length switch
        {
            3 => "Triangle",
            4 => "Quadrilateral",
            5 => "Pentagon",
            _ => "Polygon"
        };
        Console.WriteLine($"The name of the figure is: {name}");
    }
}

public class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(3, 0, "B");
        Point p3 = new Point(3, 4, "C");
        Point p4 = new Point(0, 4, "D");

        Figure figure = new Figure(p1, p2, p3, p4);

        figure.PrintName();
        figure.CalculatePerimeter();
    }
}
