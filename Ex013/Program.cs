/* Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);

if(number >= 100 && number <= 999)
{
    int result = Math.Abs(number % 10);
    Console.WriteLine($"Третья цифра заданного числа {result}");
}

if(number >= 1000 && number <= 9999)
{
    int result = Math.Abs(number % 100 / 10);
    Console.WriteLine($"Третья цифра заданного числа {result}");
}

if(number >= 10000 && number <= 99999)
{
    int result = Math.Abs(number % 1000 / 100);
    Console.WriteLine($"Третья цифра заданного числа {result}");
}

if(number >= 100000 && number <= 999999)
{
    int result = Math.Abs(number % 10000 / 1000);
    Console.WriteLine($"Третья цифра заданного числа {result}");
}
else
{
    Console.WriteLine($"Третей цифры нет");
}
