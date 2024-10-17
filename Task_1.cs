using System;

class Rectangle
{
    // Поля, що описують сторони прямокутника
    private double side1;
    private double side2;

    // Конструктор, що ініціалізує сторони
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметра прямокутника
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Властивість для доступу до площі (тільки для читання)
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для доступу до периметра (тільки для читання)
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        // Запитуємо користувача для введення довжин сторін
        Console.WriteLine("Введіть довжину першої сторони:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створюємо об'єкт прямокутника
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виводимо периметр та площу прямокутника
        Console.WriteLine("Периметр прямокутника: " + rectangle.Perimeter);
        Console.WriteLine("Площа прямокутника: " + rectangle.Area);
    }
}
