using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public string ID { get; set; }
    public double Marks { get; set; }

    // Constructor
    public Student(string name, string id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Method to get grade
    public virtual string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 80) return "B";
        else if (Marks >= 70) return "C";
        else if (Marks >= 60) return "D";
        else return "F";
    }

    // Method to display student details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }

    public static void StudentMain()
    {
        // Create and display regular student
        Student regularStudent = new Student("Aryan", "22110038", 85.5);
        Console.WriteLine("Regular Student Details:");
        regularStudent.DisplayDetails();
    }
}

class StudentIITGN : Student
{
    // Additional property
    public string HostelNameIITGN { get; set; }

    // Constructor
    public StudentIITGN(string name, string id, double marks, string hostelName)
        : base(name, id, marks)
    {
        HostelNameIITGN = hostelName;
    }

    // Override display method to include hostel name
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Hostel Name: {HostelNameIITGN}");
    }

    public static new void IITGNMain()
    {
        // Create and display IITGN student
        StudentIITGN iitgnStudent = new StudentIITGN("Aryan Sahu", "22110038", 92.3, "Lekhaag");
        Console.WriteLine("\nIITGN Student Details:");
        iitgnStudent.DisplayDetails();
    }
}