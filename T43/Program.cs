/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

*/

double GetNumber(string message)
{
    double result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}

(double, double) Find(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 || b1 == b2)
    {
        Console.WriteLine("Прямые параллельные (т.е. не имеют точек пересечения)");
    }

    else
    {
        x = (b1 - b2) / (k2 - k1);
        y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
    }

    return (x, y);
}

double b1 = GetNumber("Введите значение b1:");
double k1 = GetNumber("Введите значение к1:");
double b2 = GetNumber("Введите значение b2:");
double k2 = GetNumber("Введите значение к2:");


(double x, double y) = Find(k1, b1, k2, b2);
