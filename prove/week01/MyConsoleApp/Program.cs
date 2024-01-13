using System;
using System.Collections.Generic;

int x;
x = 5;
Console.WriteLine(x);


int y = 10;
Console.WriteLine(y);

Console.WriteLine("Hello World!");


Console.WriteLine("What is your name? ");

string name = Console.ReadLine()!;

Console.WriteLine($"Hello {name}!");



Console.WriteLine("Type a number");
if (int.TryParse(Console.ReadLine(), out int number))
if (number > 0)
{
    Console.WriteLine("Your number is positive");
}
else if (number == 0)
{
    Console.WriteLine("Your number is 0");
}
else 
{
    Console.WriteLine("Your number is negative");
}

int count = 0;
while (count < 11)
{
    Console.WriteLine(count);
    count++;
}

List<string> names = new List<string>();

Console.WriteLine("Write your and your siblings names");

names.Add(Console.ReadLine()!);

foreach (var i in names)
        {
            Console.WriteLine($"The names are {i}");
        }


static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

DisplayMessage();