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
    
        string answer = " ";
        while (answer != "5")
        {
            Console.WriteLine("Please select one of the following choices: \n");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

              switch (answer)
            {
                case "1":
                    Console.WriteLine("Creating person...");
                    Create(args);
                    break;

                case "2":
                    Console.WriteLine("Displaying people...");
                    // Add code to display people
                    break;

                case "3":
                    Console.WriteLine("Loading from file...");
                    // Add code to load from file
                    break;

                case "4":
                    Console.WriteLine("Saving to file...");
                    // Add code to save to file
                    break;

                case "5":
                    Console.WriteLine("Quitting...");
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

    }

    public static void Create(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Moroni";
        p1._lastName = "";
        List<Person> people = new List<Person>();
        people.Add(p1);

        foreach (Person p in people) // Remove the semicolon here
        {
            Console.WriteLine($"{p._firstName} {p._lastName}");
        } // Keep this closing brace

        SaveToFile(people);

        List<Person> newPeople = ReadFromFile();

        foreach (Person p in newPeople)
        {
            Console.WriteLine($"{p._firstName} {p._lastName}");
        }
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

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(' ');
            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            people.Add(newPerson);
        }

        return people;

    }

    

}

