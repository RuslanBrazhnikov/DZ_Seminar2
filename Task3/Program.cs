// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());

int Week(int x)
{
    if (x > 5 && x <= 7)
    {
        Console.Write("Да");
    }
    else if(x > 7) 
    {
        Console.Write("Неккоректное число!");
    }
    else
    {
        Console.Write("Нет");
    }
    return -1;

}

Week(num);
