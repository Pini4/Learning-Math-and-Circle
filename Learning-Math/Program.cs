internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Дана окружность , измерьте радиус окружности и скажите чему равен центральный угол между радиусом и хордой , ваша задача найти Диаметр,Длину Хорды,Площадь и Периметр окружности.");
        Console.WriteLine("Чему равен радиус?");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Чему равен центральный угол между радиусом и хордой?");
        double a = Convert.ToDouble(Console.ReadLine());
        double diameter = radius * 2;
        double horda = 2 * radius * Math.Sin(a / 2);
        double area = Math.PI * Math.Pow(radius, 2);
        double pr = 2 * Math.PI * radius;
        Console.WriteLine($"Ответ:Диаметр окружности равен {diameter}см.Длина Хорды состовляет {-horda}см.Площадь равна {area}см ,а периметр окружности равен {pr}см");
    }
    //{
    //    Console.WriteLine("Дано: Радиус окружности равен 15 , центральный угол равен 60 градусов . Найти: Диаметр,Длину Хорды,Площадь и Периметр окружности ");
    //    double radius = 15;
    //    double a = 60;
    //    double diameter = radius * 2;
    //    double horda = 2 * radius * Math.Sin(a / 2);
    //    double area = Math.PI * Math.Pow(radius, 2);
    //    double pr = 2 * Math.PI * radius;
    //    Console.WriteLine($"Ответ:Диаметр окружности равен {diameter}см.Длина Хорды состовляет {-horda}см.Площадь равна {area}см ,а периметр окружности равен {pr}см");

    //}


    //{
    //    double x = 2;
    //    double y = Math.Pow(x, 4);
    //    Console.WriteLine($" {x} в четвертой степени равен {y}");
    //}


    //{
    //    double x = 4;
    //    double y = Math.Sqrt(x);
    //    Console.WriteLine($"Квадратный корень из {x} равен {y}");
    //}


    // {
    // double radius = 30;
    // double area = Math.PI * Math.Pow(radius, 2);
    // Console.WriteLine($"Площадь круга с радиусом {radius} равна {Math.Round(area, 2)}");
    //}


    //{
    //    double radius = Convert.ToDouble(Console.ReadLine());
    //    double area = Math.PI * Math.Pow(radius, 2);
    //    Console.WriteLine($"Площадь круга с радиусом {radius} равна {area} ");
    //    double pr = 2 * Math.PI * radius;
    //    Console.WriteLine($"Периметр круга равен {pr}");
    //}
}
