/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void GetAndCountNumbers(string message)
{
    int result = 0;
    int count = 0;
    Console.WriteLine(message);
    while (true)
    {


        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 0)
            {
                count++;
            }
            Console.WriteLine("Введите еще число или нажмите любую клавишу");
        }

        else
        {
            Console.WriteLine($"Количество введенных чисел больше 0: {count} ");
            break;
        }
    }

}

GetAndCountNumbers("Введите число:");