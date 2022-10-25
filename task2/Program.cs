// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double WRiteNumbers(string message)
{
    System.Console.WriteLine(message);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double k1 = WRiteNumbers("Кофициент к1= ");
double k2 = WRiteNumbers("Кофициент к2= ");
double b1 = WRiteNumbers("член выражения b1= ");
double b2= WRiteNumbers("член выражения b2= ");
{
    if(b1==b2)
    {
        System.Console.WriteLine($"Прямые пересекаются в точке (0;{b1})");
    }
    if(k1==k2)
    {
        System.Console.WriteLine("Прямые параллельные");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*((b2-b1)/(k1-k2))+b1;
        System.Console.WriteLine($"Точка пересечения двух прямых с координатами ({x};{y})");
    }
}
