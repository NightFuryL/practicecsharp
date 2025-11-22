using practicecsharp.task_1;
using practicecsharp.task_2;
using practicecsharp.task_3;
using practicecsharp.task_4;
using System;
using System.Text;
using System.Text.Unicode;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //1
        var builder = new Builder("Лев", 30, "Майстер");
        var sailor = new Sailor("Левка", 25, "Старшина");
        var pilot = new Pilot("Левв", 40, 150);
        builder.DoWork();
        sailor.DoWork();
        pilot.DoWork();
        Console.WriteLine(builder);
        Console.WriteLine(sailor);
        Console.WriteLine(pilot);
        //2
        var passport = new Passport("Лев левв", 123456);
        var foreignPassport = new ForeignPassport("Лев левв", 123456, 987654, new List<string> { "USA", "Canada", "Japan" });
        Console.WriteLine(passport);
        Console.WriteLine(foreignPassport);
        //3
        Animal tiger = new Tiger("Тигр", "Хижак швидкий");
        Animal crocodile = new Crocodile("Крокодил", "Водний хижак");
        Animal kangaroo = new Kangaroo("Кенгуру", "Стрибає високо");
        tiger.DoSound();
        crocodile.DoSound();
        kangaroo.DoSound();
        Console.WriteLine(tiger);
        Console.WriteLine(crocodile);
        Console.WriteLine(kangaroo);
        //4
        Figure triangle = new Triangle(3, 4, 5);
        Figure rectangle = new Rectangle(4, 6);
        Figure rhombus = new Rhombus(5, 8, 4);
        Figure parallelogram = new Parallelogram(6, 4, 3);
        Figure trapezoid = new Trapezoid(5, 7, 4);
        Figure circle = new Circle(3);
        Figure ellipse = new Ellipse(4, 2);
        Console.WriteLine(triangle.Area());
        Console.WriteLine(rectangle.Area());
        Console.WriteLine(rhombus.Area());
        Console.WriteLine(parallelogram.Area());
        Console.WriteLine(trapezoid.Area());
        Console.WriteLine(circle.Area());
        Console.WriteLine(ellipse.Area());
        var composite = new CompositeFigure();
        composite.Add(triangle);
        composite.Add(rectangle);
        composite.Add(circle);
        composite.Add(ellipse);
        Console.WriteLine(composite.Area());
    }

}
