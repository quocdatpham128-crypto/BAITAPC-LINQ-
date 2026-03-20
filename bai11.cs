using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}
class bai11
{
    static void GT()
    {
        Console.WriteLine("Pham Quoc Dat");
        Console.WriteLine("2415053122205");
        Console.WriteLine("----------------------------");
        Console.WriteLine("\n\n");
    }
    static void Main(string[] args)
    {
        GT();
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 }
        };
        var stg = students.OrderByDescending(x => x.Score).Take(1);
        Console.WriteLine("Sinh vien co diem cao nhat:");
        foreach (var x in stg)
        {

            Console.WriteLine($"ID: {x.Id}, Name: {x.Name}, Score: {x.Score}");
        }
    }
}
