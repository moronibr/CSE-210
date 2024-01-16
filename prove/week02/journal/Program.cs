using System;
using System.Collections.Generic;
using System.IO;

public class Person
{
    public string _firstName = "";
    public string _lastName = "";

    public Person()
    {
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Moroni";
        p1._lastName = "";



        List<Person> people = new List<Person>();
        people.Add(p1);

        foreach(Person p in people)
        {
            Console.WriteLine($"{p._firstName} {p._lastName}");
        }

        SaveToFile(people);
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName} {p._lastName}");
            }

        }
    }

}