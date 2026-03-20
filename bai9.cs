using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}
class bai9
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
        var stg = students.Select(x => x.Name);
        Console.WriteLine("Danh sach ten sinh vien: ");
        foreach (var s in stg)
        {
            Console.Write($"{s} ");
        }
    }
}
