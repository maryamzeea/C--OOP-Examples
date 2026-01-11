// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Abstraction
using System.Diagnostics;
using System.Security.Cryptography;

public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void Introduce();  // Abstract method
}

//encapsulation
public class Student : Person
{
    private int _grade;  
    public int Grade
    {
       get{ return _grade; }
        set
        {
            if (value > 0)
            {
                _grade = value;
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
    }
    public Student(string name, int age, int grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public override void Introduce()
    {
        Console.WriteLine("Hi, I'm " + Name + "I’m" + Age + "years old and in grade" + Grade);
    }
}

// Inheritance
public class GraduateStudent : Student
{
    public string Project { get; set; }
    public GraduateStudent(string name, int age, int grade, string Project) : base(name, age, grade)
    {
        this.Project = Project;
    }
    public override void Introduce()
    {
        Console.WriteLine("Hi, I'm " + Name + "I’m " + Age + " years old and in grade " + Grade + ", working on " + Project);
    }
}

class StudentModel
{
    static void Main(string[] args)
    {
         GraduateStudent graduateStudent = new GraduateStudent("Maryam", 20, 13, "C# OOP");
        graduateStudent.Introduce();
    }
}


