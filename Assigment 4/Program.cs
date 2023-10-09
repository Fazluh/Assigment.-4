using System;

namespace Assigment4
{
class Student
{
    public int Studid { get; set; }
    public string Studname { get; set; }
    public int Age { get; set; }
    public int Maths { get; set; }
    public int Science { get; set; }
    public int English { get; set; }

    // Default constructor
    public Student()
    {
    }

    // Parameterized constructor with Studid and Studname
    public Student(int studid, string studname)
    {
        Studid = studid;
        Studname = studname;
    }

    // Parameterized constructor with Studid, Studname, and Age
    public Student(int studid, string studname, int age)
    {
        Studid = studid;
        Studname = studname;
        Age = age;
    }

    // Method to calculate total marks
    public int Calculate()
    {
        return Maths + Science + English;
    }
}

class Employee : Student
{
    public int Empid { get; set; }
    public string Ename { get; set; }
    public double Sal { get; set; }

    // Constructor for Employee
    public Employee(int empid, string ename, double sal)
    {
        Empid = empid;
        Ename = ename;
        Sal = sal;
    }

    // Method to calculate salary
    public double CalculateSalary()
    {
        double hra, da, specialAllowance;

        if (Sal > 10000 && Sal < 20000)
        {
            hra = 0.10 * Sal;
            da = 0.05 * Sal;
            specialAllowance = 0.10 * Sal;
        }
        else if (Sal > 20000 && Sal < 30000)
        {
            hra = 0.129 * Sal;
            da = 0.07 * Sal;
            specialAllowance = 0.129 * Sal;
        }
        else
        {
            hra = 0;
            da = 0;
            specialAllowance = 0;
        }

        return Sal + hra + da + specialAllowance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get student data from the user
        Console.WriteLine("Enter Student Details:");
        Console.Write("Student ID: ");
        int studId = int.Parse(Console.ReadLine());

        Console.Write("Student Name: ");
        string studName = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Maths Marks: ");
        int mathsMarks = int.Parse(Console.ReadLine());

        Console.Write("Science Marks: ");
        int scienceMarks = int.Parse(Console.ReadLine());

        Console.Write("English Marks: ");
        int englishMarks = int.Parse(Console.ReadLine());

        // Create a Student object
        Student student = new Student(studId, studName, age)
        {
            Maths = mathsMarks,
            Science = scienceMarks,
            English = englishMarks
        };

        // Calculate and display total marks
        int totalMarks = student.Calculate();
        Console.WriteLine($"Total Marks: {totalMarks}");

        // Get employee data from the user
        Console.WriteLine("\nEnter Employee Details:");
        Console.Write("Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        Console.Write("Employee Name: ");
        string empName = Console.ReadLine();

        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        // Create an Employee object
        Employee employee = new Employee(empId, empName, salary);

        // Calculate and display salary
        double calculatedSalary = employee.CalculateSalary();
        Console.WriteLine($"Calculated Salary: {calculatedSalary}");
        Console.ReadLine();
    }
}
}

