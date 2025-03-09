using System;
using System.Collections.Generic;
using System.Linq;

class Rectangle
{
    // Захищені поля
    protected int a, b;
    protected int color;

    // Конструктор
    public Rectangle(int a, int b, int color)
    {
        this.a = a;
        this.b = b;
        this.color = color;
    }

    // Властивості
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int Color
    {
        get { return color; }
    }

    // Методи
    public void Display()
    {
        Console.WriteLine($"Прямокутник: Сторони = {a}, {b}; Колір = {color}");
    }

    public int Perimeter()
    {
        return 2 * (a + b);
    }

    public int Area()
    {
        return a * b;
    }

    public bool IsSquare()
    {
        return a == b;
    }
}

class task1
{
    static void Main()
    {
        List<Rectangle> rectangles = new List<Rectangle>
        {
            new Rectangle(4, 5, 1),
            new Rectangle(6, 6, 2),
            new Rectangle(3, 4, 3),
            new Rectangle(5, 5, 4),
            new Rectangle(7, 8, 5)
        };

        int squareCount = 0;

        foreach (var rect in rectangles)
        {
            rect.Display();
            Console.WriteLine($"Периметр: {rect.Perimeter()}");
            Console.WriteLine($"Площа: {rect.Area()}");
            if (rect.IsSquare())
            {
                Console.WriteLine("Це квадрат!");
                squareCount++;
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}


