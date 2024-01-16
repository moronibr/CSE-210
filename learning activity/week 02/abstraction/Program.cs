using System;

public class Person
{
    public string _givenName = "";
    public string _familyName = "";
    
    public string _job = "";

    public int _age = 0;

    public Person()
    {
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }

    public void job()
    {
        Console.WriteLine($"{_job}");
    }

    public void age()
    {
        Console.WriteLine($"{_age}");
    }

    // Main method serves as the entry point for the console application
    public static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Set the given name and family name
        person._givenName = "Moroni";
        person._familyName = "Bamvakiades Ramos";
        person._job ="Web Developer";
        person._age = 28;
        // Display names
        Console.WriteLine("Eastern Name:");
        person.ShowEasternName();

        Console.WriteLine("\nWestern Name:");
        person.ShowWesternName();

        Console.WriteLine("\nJob:");
        person.job();

        Console.WriteLine("\nAge:");
        person.age();
    }
}
