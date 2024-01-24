using System;

List<string> names = new List<string>();

Console.WriteLine("Write your and your siblings names");

names.Add(Console.ReadLine()!);

foreach (var i in names)
        {
            Console.WriteLine($"The names are {i}");
        }
