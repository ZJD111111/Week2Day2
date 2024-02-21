using System;
using System.Collections.Generic;

public interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary(decimal baseSalary);
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    double CalculateGPA(Dictionary<string, char> courseGrades);
}

public interface IInstructorService : IPersonService
{
    decimal CalculateBonusSalary(DateTime joinDate);
}

public interface ICourseService
{
    List<string> GetEnrolledStudents();
}

public interface IDepartmentService
{
    void AssignHeadInstructor(Instructor headInstructor);
}

public abstract class Person : IPersonService
{
    protected DateTime BirthDate { get; set; }
    protected List<string> Addresses { get; set; }

    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
        Addresses = new List<string>();
    }

    public int CalculateAge(DateTime birthDate)
    {
        DateTime now = DateTime.Now;
        int age = now.Year - birthDate.Year;
        if (now < birthDate.AddYears(age)) age--;
        return age;
    }

    public decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0)
            throw new ArgumentException("Base salary cannot be negative.");
        return baseSalary;
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}

public class Instructor : Person, IInstructorService
{
    public string Department { get; set; }
    public DateTime JoinDate { get; set; }

    public Instructor(DateTime birthDate, DateTime joinDate) : base(birthDate)
    {
        JoinDate = joinDate;
    }

    public decimal CalculateBonusSalary(DateTime joinDate)
    {
        TimeSpan experience = DateTime.Now - joinDate;
        int yearsExperience = (int)(experience.TotalDays / 365);
        return yearsExperience * 1000;
    }
}

public class Student : Person, IStudentService
{
    public Dictionary<string, char> CourseGrades { get; set; }

    public Student(DateTime birthDate) : base(birthDate)
    {
        CourseGrades = new Dictionary<string, char>();
    }

    public double CalculateGPA(Dictionary<string, char> courseGrades)
    {
        int totalCredits = courseGrades.Count;
        int totalPoints = 0;
        foreach (var grade in courseGrades.Values)
        {
            switch (grade)
            {
                case 'A':
                    totalPoints += 4;
                    break;
                case 'B':
                    totalPoints += 3;
                    break;
                case 'C':
                    totalPoints += 2;
                    break;
                case 'D':
                    totalPoints += 1;
                    break;
            }
        }
        return totalPoints / (double)totalCredits;
    }
}

public class Course : ICourseService
{
    public List<Student> EnrolledStudents { get; set; }

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public List<string> GetEnrolledStudents()
    {
        List<string> studentNames = new List<string>();
        foreach (var student in EnrolledStudents)
        {
            studentNames.Add(student.ToString());
        }
        return studentNames;
    }
}

public class Department : IDepartmentService
{
    public Instructor HeadInstructor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> CoursesOffered { get; set; }

    public Department()
    {
        CoursesOffered = new List<Course>();
    }

    public void AssignHeadInstructor(Instructor headInstructor)
    {
        HeadInstructor = headInstructor;
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         DateTime instructorBirthDate = new DateTime(1997, 10, 17);
//         DateTime instructorJoinDate = new DateTime(2021, 8, 1);
//         Instructor instructor = new Instructor(instructorBirthDate, instructorJoinDate);
//         Console.WriteLine("Salary: " + instructor.CalculateBonusSalary(instructorJoinDate));

//         DateTime studentBirthDate = new DateTime(2005, 10, 17);
//         Student student = new Student(studentBirthDate);
//         Dictionary<string, char> courseGrades = new Dictionary<string, char>();
//         courseGrades.Add("Math", 'A');
//         courseGrades.Add("Science", 'B');
//         courseGrades.Add("History", 'C');
//         Console.WriteLine("GPA: " + student.CalculateGPA(courseGrades));
//     }
// }
