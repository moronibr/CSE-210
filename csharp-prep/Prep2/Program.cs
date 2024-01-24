using System;

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