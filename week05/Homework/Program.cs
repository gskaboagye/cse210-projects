using System;

// Base class
public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

// Derived class
public class Student : Person
{
    public string StudentID { get; set; }
    public double Grade { get; set; }

    public Student(string name, string studentID, double grade) : base(name)
    {
        StudentID = studentID;
        Grade = grade;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Grade: {Grade}");
        Console.WriteLine($"Status: {(Grade >= 60 ? "Pass" : "Fail")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Student Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Student ID:");
        string id = Console.ReadLine();

        Console.WriteLine("Enter Grade:");
        double grade = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(name, id, grade);

        Console.WriteLine("\n--- Grade Report ---");
        student.DisplayInfo();
    }
}
