using System;

public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}


public class Student : Person
{
    private string _number;
    public Student(string name, string number) : base(name)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}

class Program
{
    static void Main()
    {
    
        Student student = new Student("John Doe", "12345");
        Console.WriteLine("Name: " + student.GetName());
        Console.WriteLine("Number: " + student.GetNumber());
    }
}
