using _01._Students;
using System.Diagnostics;

int numberStudent = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 0; i < numberStudent; i++)
{
    string[] data = Console.ReadLine().Split(" ").ToArray();

    Student student = new Student()
    {
        FirstName = data[0],
        LastName = data[1],
        Grade = double.Parse(data[2]),
    };

    students.Add(student);
}

students = students
    .OrderByDescending(student => student.Grade)
    .ToList();

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}