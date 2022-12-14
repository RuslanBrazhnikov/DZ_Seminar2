// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int Sec(int number)
{
    if (number >= 100 && number < 1000)
    {
        number = number / 10;
        return number % 10;
    }
    else
    {
        return -1;
    }
}

int res = Sec(num);

if (res != -1)
{
    Console.Write($"Вторая цифра числа {num} ==> {res}");
}
else
{
    Console.Write($"Число не трехзначное!");
}
