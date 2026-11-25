using System;

int totalExercises = 8;
for (int number = totalExercises; number >= 1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}
Console.WriteLine("Домашнее задание готово");

Console.WriteLine();

for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}

Console.WriteLine();

int totalWeeks = 3;
for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("^_^");
}

Console.WriteLine();

int skippedTickets = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        skippedTickets++;
        continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");
    Console.WriteLine($"Пропущено билетов: {skippedTickets}");
    break;
}

Console.WriteLine();

for (; ; )
{
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход")
    {
        break;
    }

    Console.WriteLine($"Записан код группы: {groupCode}");
}
Console.WriteLine("Работа с журналом завершена");

Console.WriteLine();

// Задача А
int n = 15;
for (int i = 1; i <= n; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

// Задача В
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

// Вариант 1
int limit = 20;
for (int i = 1; i <= limit; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

// Вариант 3
int cubesLimit = 5;
for (int i = 1; i <= cubesLimit; i++)
{
    Console.WriteLine($"{i} -> {i * i * i}");
}
